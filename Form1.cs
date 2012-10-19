using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace Pomodoro
{
    public partial class SettingsForm : Form
    {
        private Pomodoro pomodoro;
        private HashSet<String> interruptReasons;
        private const string filename = "pomodorosLog.xml";

        public delegate void UpdateContextMenuGhostingCallback();
        private UpdateContextMenuGhostingCallback updateContextMenuGhostingCallback;

        public SettingsForm()
        {
            InitializeComponent();
            updateContextMenuGhostingCallback = new UpdateContextMenuGhostingCallback(UpdateContextMenuGhosting);
            InitInterruptReasons();
            SetupUserSettings();
            UpdateContextMenuGhosting();
        }

        private void SetupUserSettings()
        {
            nudPomodoroDuration.Value = Settings.readInt(Settings.POMODORO_DURATION);
            nudMaxInterruptionDuration.Value = Settings.readInt(Settings.MAX_INTERRUPT_DURATION);
            cbAskInterruptReason.Checked = Settings.readBool(Settings.ASK_INTERRUPT_REASON);
            nudBreakDuration.Value = Settings.readInt(Settings.BREAK_DURATION);
            cbTickingSound.Checked = Settings.readBool(Settings.TICKING_SOUND);
            cbAlarmOnPomodoroEnd.Checked = Settings.readBool(Settings.ALARM_ON_POMODORO_END);
			cbMessageOnPomodoroEnd.Checked = Settings.readBool(Settings.MESSAGE_ON_POMODORO_END);
			tbMessageOnPomodoroEnd.Text = Settings.read( Settings.MESSAGE_TEXT_ON_POMODORO_END );
            cbAskPomodoroNameOnStart.Checked = Settings.readBool(Settings.ASK_POMODORO_NAME_ON_START);
            cbShowTimeCounter.Checked = Settings.readBool(Settings.SHOW_TIME_COUNTER);
            cbAlarmOnBreakEnd.Checked = Settings.readBool(Settings.ALARM_ON_BREAK_END);
			cbMessageOnBreakEnd.Checked = Settings.readBool( Settings.MESSAGE_ON_BREAK_END );
			tbMessageOnBreakEnd.Text = Settings.read( Settings.MESSAGE_TEXT_ON_BREAK_END );
            cbTickingSoundOnBreak.Checked = Settings.readBool(Settings.TICKING_SOUND_FOR_BREAK);
            cbResetOnInterruptTimeout.Checked = Settings.readBool(Settings.RESET_ON_INTERRUPT_TIMEOUT);
        }

        #region Window State

        private void SettingsForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        #endregion

        #region Pomodoro Handlers

        public void PomodoroTimeElapsedHandler()
        {
            TimeSpan timeSpan = TimeSpan.FromTicks(pomodoro.GetRemainingTicks());
            string iconFilename = @"icons/min" + (timeSpan.Minutes + 1) + ".ico";
            if ( !File.Exists(iconFilename) )
            {
                iconFilename = @"icons/domatis.ico";
            }
            notifyIcon1.Icon = new Icon(iconFilename);

            if (Settings.readBool(Settings.SHOW_TIME_COUNTER))
            {
                ShowRemainingTime();
            }

        	notifyIcon1.Text = "Pomodoro \"" + pomodoro.Description + "\" is running";
        }

        public void BreakTimeElapsedHandler()
        {
            TimeSpan timeSpan = TimeSpan.FromTicks(pomodoro.GetRemainingBreakTicks());
            notifyIcon1.Icon = new Icon(@"icons/min" + (timeSpan.Minutes + 1) + ".ico");
            if (Settings.readBool(Settings.SHOW_TIME_COUNTER))
            {
                ShowRemainingTime();
            }
        }

        public void PomodoroEndedHandler()
        {
            this.Invoke(updateContextMenuGhostingCallback);
            LogPomodoro();
            InitInterruptReasons();

			notifyIcon1.Text = "Break after pomodoro \"" + pomodoro.Description + "\"";
        }

        public void PomodoroResetHandler()
        {
            this.Invoke(updateContextMenuGhostingCallback);
        }

        public void BreakEndedHandler()
        {
            this.Invoke(updateContextMenuGhostingCallback);
        	notifyIcon1.Text = "Pomodoro is not active now";
        }

        #endregion

        #region Settings Change Handlers

        private void nudPomodoroDuration_ValueChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.POMODORO_DURATION, nudPomodoroDuration.Value.ToString());
        }

        private void nudMaxInterruptionDuration_ValueChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.MAX_INTERRUPT_DURATION, nudMaxInterruptionDuration.Value.ToString());
        }

        private void cbAskInterruptReason_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.ASK_INTERRUPT_REASON, cbAskInterruptReason.Checked.ToString());
        }

        private void nudBreakDuration_ValueChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.BREAK_DURATION, nudBreakDuration.Value.ToString());
        }

        private void cbTickingSound_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.TICKING_SOUND, cbTickingSound.Checked.ToString());
            if (pomodoro != null)
            {
                pomodoro.SetTickingSound();
            }
        }

        private void cbShowTimeCounter_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.SHOW_TIME_COUNTER, cbShowTimeCounter.Checked.ToString());
        }

        private void cbAlarmOnBreakEnd_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.ALARM_ON_BREAK_END, cbAlarmOnBreakEnd.Checked.ToString());
        }

        private void cbAlarmOnPomodoroEnd_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.ALARM_ON_POMODORO_END, cbAlarmOnPomodoroEnd.Checked.ToString());
        }

        private void cbAskPomodoroNameOnStart_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.ASK_POMODORO_NAME_ON_START, cbAskPomodoroNameOnStart.Checked.ToString());
        }

        private void cbTickingSoundOnBreak_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.TICKING_SOUND_FOR_BREAK, cbTickingSoundOnBreak.Checked.ToString());
            if (pomodoro != null)
            {
                pomodoro.SetTickingSound();
            }
        }

        private void cbResetOnInterruptTimeout_CheckedChanged(object sender, EventArgs e)
        {
            Settings.set(Settings.RESET_ON_INTERRUPT_TIMEOUT, cbResetOnInterruptTimeout.Checked.ToString());
        }

        #endregion

        #region Context Menu Handlers

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startPomodoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Settings.readBool(Settings.ASK_POMODORO_NAME_ON_START))
            {
                PomodoroNameForm f = new PomodoroNameForm();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    StartNewPomodoro(f.PomodoroDescription);
                }
            }
            else
            {
                StartNewPomodoro("");
            }
        }

        private void interruptPomodoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string reason = "";
            if (Settings.readBool(Settings.ASK_INTERRUPT_REASON))
            {
                InterruptionNameForm f = new InterruptionNameForm(interruptReasons.ToArray<string>());
                if (f.ShowDialog() == DialogResult.OK)
                {
                    reason = f.Reason;
                }
                AddInterruptReason(reason);
            }
            pomodoro.Interrupt(reason);
            UpdateContextMenuGhosting();
        }

        private void resetPomodoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pomodoro.Reset();
            UpdateContextMenuGhosting();
        }

        private void resumePomodoroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pomodoro.Resume();
            UpdateContextMenuGhosting();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void statsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = GetLogDataSet();
            StatisticsForm f = new StatisticsForm(ds.Tables["pomodoros"]);
            f.Show();
        }

        #endregion

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowRemainingTime();
            }
        }

        private void UpdateContextMenuGhosting()
        {
            if (pomodoro == null || pomodoro.Status == Pomodoro.State.IDLE || 
                                    pomodoro.Status == Pomodoro.State.CLOSED )
            {
                contextMenuStrip1.Items["startPomodoroToolStripMenuItem"].Enabled = true;
                contextMenuStrip1.Items["resetPomodoroToolStripMenuItem"].Enabled = false;
                contextMenuStrip1.Items["interruptPomodoroToolStripMenuItem"].Enabled = false;
                contextMenuStrip1.Items["resumePomodoroToolStripMenuItem"].Enabled = false;
                notifyIcon1.Icon = new Icon(@"icons/domatis.ico");
            }
            else if(pomodoro != null)
            {
                if (pomodoro.Status == Pomodoro.State.RUNNING)
                {
                    contextMenuStrip1.Items["startPomodoroToolStripMenuItem"].Enabled = false;
                    contextMenuStrip1.Items["resetPomodoroToolStripMenuItem"].Enabled = true;
                    contextMenuStrip1.Items["interruptPomodoroToolStripMenuItem"].Enabled = true;
                    contextMenuStrip1.Items["resumePomodoroToolStripMenuItem"].Enabled = false;
                }
                else if (pomodoro.Status == Pomodoro.State.INTERRUPTED)
                {
                    contextMenuStrip1.Items["startPomodoroToolStripMenuItem"].Enabled = false;
                    contextMenuStrip1.Items["resetPomodoroToolStripMenuItem"].Enabled = true;
                    contextMenuStrip1.Items["interruptPomodoroToolStripMenuItem"].Enabled = false;
                    contextMenuStrip1.Items["resumePomodoroToolStripMenuItem"].Enabled = true;
                }
                else if (pomodoro.Status == Pomodoro.State.BREAK)
                {
                    contextMenuStrip1.Items["startPomodoroToolStripMenuItem"].Enabled = true;
                    contextMenuStrip1.Items["resetPomodoroToolStripMenuItem"].Enabled = false;
                    contextMenuStrip1.Items["interruptPomodoroToolStripMenuItem"].Enabled = false;
                    contextMenuStrip1.Items["resumePomodoroToolStripMenuItem"].Enabled = false;
                }
            }
        }

        private void ShowRemainingTime()
        {
            if (pomodoro != null)
            {
                long ticks;
                if (pomodoro.Status == Pomodoro.State.RUNNING)
                {
                    ticks = pomodoro.GetRemainingTicks();
                }
                else if (pomodoro.Status == Pomodoro.State.BREAK)
                {
                    ticks = pomodoro.GetRemainingBreakTicks();
                }
                else if (pomodoro.Status == Pomodoro.State.INTERRUPTED)
                {
                    ticks = pomodoro.GetRemainingInterruptTicks();
                }
                else
                {
                    return;
                }

                TimeSpan timeSpan = TimeSpan.FromTicks(ticks);
                notifyIcon1.BalloonTipText = timeSpan.Minutes + ":" + timeSpan.Seconds;
                // int milliseconds = (int)timeSpan.TotalMilliseconds;
                notifyIcon1.ShowBalloonTip(1000 * 2);
            }
        }

        private void StartNewPomodoro(string desc)
        {
            if (pomodoro != null)
            {
                pomodoro.Reset();
            }
            pomodoro = new Pomodoro(desc);
            pomodoro.PomodoroTimeElapsed += this.PomodoroTimeElapsedHandler;
            pomodoro.BreakTimeElapsed += this.BreakTimeElapsedHandler;
            pomodoro.PomodoroEnded += this.PomodoroEndedHandler;
            pomodoro.BreakEnded += this.BreakEndedHandler;
            pomodoro.PomodoroReset += this.PomodoroResetHandler;
            pomodoro.Start();
            notifyIcon1.BalloonTipText = "Have a nice Pomodoro";
            notifyIcon1.ShowBalloonTip(2 * 1000);
            UpdateContextMenuGhosting();
        }

        private DataSet GetLogDataSet()
        {
            DataSet ds = new DataSet("Pomodoros");
            DataTable dt;
            if (!File.Exists(filename))
            {
                dt = new DataTable("pomodoros");
                dt.Columns.Add("Name");
                dt.Columns.Add("EndDate");
                dt.Columns.Add("Duration");
                dt.Columns.Add("InterruptDuration");
                dt.Columns.Add("InterruptionCount");
                dt.Columns.Add("Interruptions");
                ds.Tables.Add(dt);
            }
            else
            {
                ds.ReadXml(filename);
            }
            return ds;
        }

        private void LogPomodoro()
        {
            DataSet ds = GetLogDataSet();
            DataTable dt = ds.Tables["pomodoros"];

            object[] row = new object[6];
            row[0] = pomodoro.Description;
            row[1] = DateTime.Now.ToString("g");
            row[2] = TicksToMinutes( pomodoro.GetPomodoroDuration()  ) + " min";
            row[3] = TicksToSeconds( pomodoro.TotalInterruptDuration ) + " sec";
            row[4] = pomodoro.Interruptions.Count;
            string interruptions = "";
            foreach (string interruption in pomodoro.Interruptions)
            {
                interruptions += interruption + ", ";
            }
            row[5] = interruptions.Trim(new char[]{' ',','});

            dt.Rows.Add(row);
            ds.WriteXml(filename);
        }

        private void AddInterruptReason(string reason)
        {
            if (reason.Trim().Length > 0)
            {
                interruptReasons.Add(reason.Trim());
            }
        }

        private void InitInterruptReasons()
        {
            interruptReasons = new HashSet<string>();
            interruptReasons.Add("Email");
            interruptReasons.Add("Telephone");
            interruptReasons.Add("Conversation");

            if (File.Exists(filename))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(filename);
                DataTable dt = ds.Tables["pomodoros"];
                foreach (DataRow row in dt.Rows)
                {
                    string[] reasons = ((string)row[5]).Split(',');
                    foreach (string reason in reasons)
                    {
                        AddInterruptReason(reason);
                    }
                }
            }
        }

        private String TicksToSeconds(long ticks)
        {
            return TimeSpan.FromTicks(ticks).TotalSeconds.ToString("F2");
        }
        private String TicksToMinutes(long ticks)
        {
            return TimeSpan.FromTicks(ticks).TotalMinutes.ToString("F2");
        }

		private void cbMessageOnPomodoroEnd_CheckedChanged( object sender, EventArgs e )
		{
			Settings.set( Settings.MESSAGE_ON_POMODORO_END, cbMessageOnPomodoroEnd.Checked.ToString() );
			Settings.set( Settings.MESSAGE_TEXT_ON_POMODORO_END, tbMessageOnPomodoroEnd.Text );

			tbMessageOnPomodoroEnd.Enabled = cbMessageOnPomodoroEnd.Checked;
		}

		private void cbMessageOnBreakEnd_CheckedChanged( object sender, EventArgs e )
		{
			Settings.set( Settings.MESSAGE_ON_BREAK_END, cbMessageOnBreakEnd.Checked.ToString() );
			Settings.set( Settings.MESSAGE_TEXT_ON_BREAK_END, tbMessageOnBreakEnd.Text );

			tbMessageOnBreakEnd.Enabled = cbMessageOnBreakEnd.Checked;
		}

		private void tbMessageOnPomodoroEnd_TextChanged( object sender, EventArgs e )
		{
			Settings.set( Settings.MESSAGE_TEXT_ON_POMODORO_END, tbMessageOnPomodoroEnd.Text );
		}

		private void tbMessageOnBreakEnd_TextChanged( object sender, EventArgs e )
		{
			Settings.set( Settings.MESSAGE_TEXT_ON_BREAK_END, tbMessageOnBreakEnd.Text );
		}
    }
}
