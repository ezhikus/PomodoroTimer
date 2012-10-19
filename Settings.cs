using System;
using System.Configuration;

namespace Pomodoro
{
    public class Settings
    {
        public const string POMODORO_DURATION				= "PomodoroDuration";
        public const string ALARM_ON_POMODORO_END			= "AlarmOnPomodoroEnd";
		public const string MESSAGE_ON_POMODORO_END			= "MessageOnPomodoroEnd";
		public const string MESSAGE_TEXT_ON_POMODORO_END	= "MessageTextOnPomodoroEnd";
        public const string ASK_POMODORO_NAME_ON_START		= "AskPomodoroNameOnStart";
        public const string TICKING_SOUND					= "TickingSound";
        public const string SHOW_TIME_COUNTER				= "ShowTimeCounter";

        // Interrupt Settings
        public const string RESET_ON_INTERRUPT_TIMEOUT  = "ResetOnInterruptTimeout";
        public const string MAX_INTERRUPT_DURATION      = "MaxInterruptDuration";
        public const string ASK_INTERRUPT_REASON        = "AskInterruptReason";

        // Break Settings
        public const string BREAK_DURATION					= "BreakDuration";
        public const string ALARM_ON_BREAK_END				= "AlarmOnBreakEnd";
		public const string MESSAGE_ON_BREAK_END			= "MessageOnBreakEnd";
		public const string MESSAGE_TEXT_ON_BREAK_END		= "MessageTextOnBreakEnd";
        public const string TICKING_SOUND_FOR_BREAK			= "TickingSoundForBreak";
        public const string CAN_START_DURING_BREAK			= "CanStartDuringBreak";

        // Sound Settings
        public const string SPEECH_START            = "SpeechStart";
        public const string SPEECH_END              = "SpeechEnd";
        public const string SPEECH_INTERRUPT        = "SpeechInterrupt";
        public const string SPEECH_RESUME           = "SpeechResume";
        public const string SPEECH_BREAK_END        = "SpeechBreakEnd";

        private static Configuration config;

        static Settings() {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public static string read(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static int readInt(string key)
        {
            return Int32.Parse( read(key) );
        }

        public static bool readBool(string key)
        {
            return read(key).Equals("True");
        }


        public static void set(string key, string value)
        {
            config.AppSettings.Settings[key].Value = value;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
