using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Timers;
using System.Media;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Timer=System.Timers.Timer;

namespace Pomodoro
{
    class Pomodoro
    {
        private long startTime;
        private long endTime;
        private long interruptionTime;
        private string description;
        private List<String> interruptions;
        private long totalInterruptDuration;

        public enum State
        {
            IDLE,
            RUNNING,
            INTERRUPTED,
            BREAK,
            CLOSED
        }
        private State state;

        private SoundPlayer spTicks;
        private SoundPlayer spSpeech;
        private Timer timer;
        //private SpeechSynthesizer speak;

        public delegate void PomodoroTimeElapsedHandler();
        public event PomodoroTimeElapsedHandler PomodoroTimeElapsed;

        public delegate void BreakTimeElapsedHandler();
        public event BreakTimeElapsedHandler BreakTimeElapsed;

        public delegate void PomodoroEndedHandler();
        public event PomodoroEndedHandler PomodoroEnded;

        public delegate void PomodoroResetHandler();
        public event PomodoroResetHandler PomodoroReset;

        public delegate void BreakEndedHandler();
        public event BreakEndedHandler BreakEnded;

        public string Description
        {
            get { return this.description; }
        }

        public List<String> Interruptions
        {
            get { return interruptions; }
        }

        public State Status
        {
            get { return this.state; }
        }

        public long TotalInterruptDuration
        {
            get { return this.totalInterruptDuration; }
        }

        public Pomodoro(string description)
        {
            this.state = State.IDLE;
            this.description = description;
            this.interruptions = new List<string>();
            this.totalInterruptDuration = 0;
            /*
            speak = new SpeechSynthesizer();
            speak.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
            speak.Rate = 2;
             */
            timer = new Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(OnTimeElapsed);
            spTicks = new SoundPlayer("sounds/tick.wav");
            spSpeech = new SoundPlayer("sounds/pomodoroStart.wav");
            spSpeech.Load();
        }

        public void Start()
        {
            if (state != State.IDLE)
            {
                return;
            }
            timer.Start();
            startTime = DateTime.Now.Ticks;
            this.state = State.RUNNING;
            spSpeech.SoundLocation = "sounds/pomodoroStart.wav";
            spSpeech.PlaySync();
            SetTickingSound();
            // speak.Speak(Settings.read(Settings.SPEECH_START));
        }

        public void Reset()
        {
            //startTime = 0;
            spTicks.Stop();
            timer.Stop();
            state = State.CLOSED;
        }

        public void Interrupt(string reason)
        {
            spTicks.Stop();
            interruptionTime = DateTime.Now.Ticks;
            this.interruptions.Add(reason);
            this.state = State.INTERRUPTED;
            spSpeech.SoundLocation = "sounds/interrupted.wav";
            spSpeech.Play();
            // speak.Speak(Settings.read(Settings.SPEECH_INTERRUPT));
        }

        public void Resume()
        {
            long interruptDuration = DateTime.Now.Ticks - interruptionTime;
            startTime += interruptDuration;
            totalInterruptDuration += interruptDuration;
            this.state = State.RUNNING;
            SetTickingSound();
            spSpeech.SoundLocation = "sounds/resume.wav";
            spSpeech.PlaySync();
            SetTickingSound();
            //speak.Speak(Settings.read(Settings.SPEECH_RESUME));
        }

        private void OnTimeElapsed(object source, ElapsedEventArgs e)
        {
            if (state == State.RUNNING) 
            {
                if (GetRemainingTicks() <= 0)
                {
                    PomodoroEnd();
                }
                else
                {
                    PomodoroTimeElapsed();
                }
            }
            else if(state == State.BREAK)
            {
                long breakDurationTicks = TimeSpan.FromMinutes(Settings.readInt(Settings.BREAK_DURATION)).Ticks;
                if (GetRemainingTicks() <= -breakDurationTicks)
                {
                    BreakEnd();
                }
                else
                {
                    BreakTimeElapsed();
                }
            }
            else if (state == State.INTERRUPTED)
            {
                if ( Settings.readBool(Settings.RESET_ON_INTERRUPT_TIMEOUT) &&
                     GetRemainingInterruptTicks() <= 0 )
                {
                    Reset();
                    PomodoroReset();
                }
            }
        }

        public void SetTickingSound()
        {
            spTicks.Stop();
            if ( (  
                    Settings.readBool(Settings.TICKING_SOUND) &&
                    this.state == State.RUNNING
                 ) || 
                 (  
                    Settings.readBool(Settings.TICKING_SOUND_FOR_BREAK) &&
                    this.state == State.BREAK
                 )
               )
            {
                spTicks.PlayLooping();
            }
        }

        private void PomodoroEnd()
        {
            endTime = DateTime.Now.Ticks;
            spTicks.Stop();
            state = State.BREAK;
            PomodoroEnded();
            if (Settings.readBool(Settings.ALARM_ON_POMODORO_END))
            {
                spSpeech.SoundLocation = "sounds/pomodoroEnd.wav";
                spSpeech.PlaySync();
                SetTickingSound();
                //speak.Speak(Settings.read(Settings.SPEECH_END));
            }
			if(Settings.readBool(Settings.MESSAGE_ON_POMODORO_END))
			{
				MessageBox.Show( Settings.read( Settings.MESSAGE_TEXT_ON_POMODORO_END ), "Pomodoro is end", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
        }

        private void BreakEnd()
        {
            timer.Stop();
            spTicks.Stop();
            state = State.CLOSED;
            BreakEnded();
            if (Settings.readBool(Settings.ALARM_ON_BREAK_END))
            {
                spSpeech.SoundLocation = "sounds/breakEnd.wav";
                spSpeech.Play();
                //speak.Speak(Settings.read(Settings.SPEECH_BREAK_END));
            }

			if( Settings.readBool( Settings.MESSAGE_ON_BREAK_END ) )
			{
				MessageBox.Show( Settings.read( Settings.MESSAGE_TEXT_ON_BREAK_END ), "Break is end", MessageBoxButtons.OK, MessageBoxIcon.Information );
			}
        }

        public long GetRemainingTicks()
        {
            return new DateTime(startTime)
                    .AddMinutes(Settings.readInt(Settings.POMODORO_DURATION))
                    .Ticks 
                   - DateTime.Now.Ticks;
        }

        public long GetRemainingBreakTicks()
        {
            return new DateTime(startTime)
                    .AddMinutes(Settings.readInt(Settings.POMODORO_DURATION) + Settings.readInt(Settings.BREAK_DURATION))
                    .Ticks
                   - DateTime.Now.Ticks;
        }

        public long GetRemainingInterruptTicks()
        {
            long maxIterruptTicks = TimeSpan.FromSeconds( Settings.readInt(Settings.MAX_INTERRUPT_DURATION) ).Ticks;
            long elapsedInterruptTicks = DateTime.Now.Ticks - interruptionTime;
            return maxIterruptTicks - elapsedInterruptTicks;
        }

        public long GetPomodoroDuration()
        {
            if (Status == State.RUNNING || Status == State.INTERRUPTED)
            {
                return Math.Max(0, DateTime.Now.Ticks - startTime - totalInterruptDuration);
            }
            else if(Status == State.CLOSED || Status == State.BREAK)
            {
                return Math.Max(0, endTime - startTime - totalInterruptDuration);
            }
            return 0;
        }

    }
}
