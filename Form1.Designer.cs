namespace Pomodoro
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( SettingsForm ) );
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon( this.components );
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip( this.components );
			this.startPomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetPomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.interruptPomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resumePomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.nudPomodoroDuration = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.nudMaxInterruptionDuration = new System.Windows.Forms.NumericUpDown();
			this.cbTickingSound = new System.Windows.Forms.CheckBox();
			this.cbShowTimeCounter = new System.Windows.Forms.CheckBox();
			this.cbAskPomodoroNameOnStart = new System.Windows.Forms.CheckBox();
			this.cbAlarmOnPomodoroEnd = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.nudBreakDuration = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.cbAlarmOnBreakEnd = new System.Windows.Forms.CheckBox();
			this.cbAskInterruptReason = new System.Windows.Forms.CheckBox();
			this.cbTickingSoundOnBreak = new System.Windows.Forms.CheckBox();
			this.cbResetOnInterruptTimeout = new System.Windows.Forms.CheckBox();
			this.cbMessageOnPomodoroEnd = new System.Windows.Forms.CheckBox();
			this.tbMessageOnPomodoroEnd = new System.Windows.Forms.TextBox();
			this.tbMessageOnBreakEnd = new System.Windows.Forms.TextBox();
			this.cbMessageOnBreakEnd = new System.Windows.Forms.CheckBox();
			this.contextMenuStrip1.SuspendLayout();
			( (System.ComponentModel.ISupportInitialize)( this.nudPomodoroDuration ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.nudMaxInterruptionDuration ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.nudBreakDuration ) ).BeginInit();
			this.SuspendLayout();
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
			this.notifyIcon1.Icon = ( (System.Drawing.Icon)( resources.GetObject( "notifyIcon1.Icon" ) ) );
			this.notifyIcon1.Text = "Pomodoro is not active now";
			this.notifyIcon1.Visible = true;
			this.notifyIcon1.DoubleClick += new System.EventHandler( this.notifyIcon1_DoubleClick );
			this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler( this.notifyIcon1_MouseClick );
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.startPomodoroToolStripMenuItem,
            this.resetPomodoroToolStripMenuItem,
            this.toolStripSeparator1,
            this.interruptPomodoroToolStripMenuItem,
            this.resumePomodoroToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.statsToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem} );
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.ShowImageMargin = false;
			this.contextMenuStrip1.Size = new System.Drawing.Size( 148, 176 );
			// 
			// startPomodoroToolStripMenuItem
			// 
			this.startPomodoroToolStripMenuItem.Name = "startPomodoroToolStripMenuItem";
			this.startPomodoroToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
			this.startPomodoroToolStripMenuItem.Text = "Start Pomodoro";
			this.startPomodoroToolStripMenuItem.Click += new System.EventHandler( this.startPomodoroToolStripMenuItem_Click );
			// 
			// resetPomodoroToolStripMenuItem
			// 
			this.resetPomodoroToolStripMenuItem.Name = "resetPomodoroToolStripMenuItem";
			this.resetPomodoroToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
			this.resetPomodoroToolStripMenuItem.Text = "Reset Pomodoro";
			this.resetPomodoroToolStripMenuItem.Click += new System.EventHandler( this.resetPomodoroToolStripMenuItem_Click );
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size( 144, 6 );
			// 
			// interruptPomodoroToolStripMenuItem
			// 
			this.interruptPomodoroToolStripMenuItem.Name = "interruptPomodoroToolStripMenuItem";
			this.interruptPomodoroToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
			this.interruptPomodoroToolStripMenuItem.Text = "Interrupt  Pomodoro";
			this.interruptPomodoroToolStripMenuItem.Click += new System.EventHandler( this.interruptPomodoroToolStripMenuItem_Click );
			// 
			// resumePomodoroToolStripMenuItem
			// 
			this.resumePomodoroToolStripMenuItem.Name = "resumePomodoroToolStripMenuItem";
			this.resumePomodoroToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
			this.resumePomodoroToolStripMenuItem.Text = "Resume Pomodoro";
			this.resumePomodoroToolStripMenuItem.Click += new System.EventHandler( this.resumePomodoroToolStripMenuItem_Click );
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size( 144, 6 );
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler( this.settingsToolStripMenuItem_Click );
			// 
			// statsToolStripMenuItem
			// 
			this.statsToolStripMenuItem.Name = "statsToolStripMenuItem";
			this.statsToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
			this.statsToolStripMenuItem.Text = "Statistics";
			this.statsToolStripMenuItem.Click += new System.EventHandler( this.statsToolStripMenuItem_Click );
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size( 144, 6 );
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size( 147, 22 );
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 12, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 99, 13 );
			this.label1.TabIndex = 0;
			this.label1.Text = "Pomodoro duration:";
			// 
			// nudPomodoroDuration
			// 
			this.nudPomodoroDuration.Location = new System.Drawing.Point( 161, 7 );
			this.nudPomodoroDuration.Maximum = new decimal( new int[] {
            999,
            0,
            0,
            0} );
			this.nudPomodoroDuration.Name = "nudPomodoroDuration";
			this.nudPomodoroDuration.Size = new System.Drawing.Size( 44, 20 );
			this.nudPomodoroDuration.TabIndex = 1;
			this.nudPomodoroDuration.ValueChanged += new System.EventHandler( this.nudPomodoroDuration_ValueChanged );
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point( 208, 9 );
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size( 43, 13 );
			this.label2.TabIndex = 2;
			this.label2.Text = "minutes";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point( 12, 219 );
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size( 150, 13 );
			this.label3.TabIndex = 3;
			this.label3.Text = "Maximum interruption duration:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point( 208, 219 );
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size( 47, 13 );
			this.label4.TabIndex = 5;
			this.label4.Text = "seconds";
			// 
			// nudMaxInterruptionDuration
			// 
			this.nudMaxInterruptionDuration.Location = new System.Drawing.Point( 161, 217 );
			this.nudMaxInterruptionDuration.Maximum = new decimal( new int[] {
            999,
            0,
            0,
            0} );
			this.nudMaxInterruptionDuration.Name = "nudMaxInterruptionDuration";
			this.nudMaxInterruptionDuration.Size = new System.Drawing.Size( 44, 20 );
			this.nudMaxInterruptionDuration.TabIndex = 4;
			this.nudMaxInterruptionDuration.ValueChanged += new System.EventHandler( this.nudMaxInterruptionDuration_ValueChanged );
			// 
			// cbTickingSound
			// 
			this.cbTickingSound.AutoSize = true;
			this.cbTickingSound.Checked = true;
			this.cbTickingSound.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbTickingSound.Location = new System.Drawing.Point( 15, 35 );
			this.cbTickingSound.Name = "cbTickingSound";
			this.cbTickingSound.Size = new System.Drawing.Size( 93, 17 );
			this.cbTickingSound.TabIndex = 6;
			this.cbTickingSound.Text = "Ticking sound";
			this.cbTickingSound.UseVisualStyleBackColor = true;
			this.cbTickingSound.CheckedChanged += new System.EventHandler( this.cbTickingSound_CheckedChanged );
			// 
			// cbShowTimeCounter
			// 
			this.cbShowTimeCounter.AutoSize = true;
			this.cbShowTimeCounter.Checked = true;
			this.cbShowTimeCounter.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbShowTimeCounter.Location = new System.Drawing.Point( 15, 58 );
			this.cbShowTimeCounter.Name = "cbShowTimeCounter";
			this.cbShowTimeCounter.Size = new System.Drawing.Size( 114, 17 );
			this.cbShowTimeCounter.TabIndex = 8;
			this.cbShowTimeCounter.Text = "Show time counter";
			this.cbShowTimeCounter.UseVisualStyleBackColor = true;
			this.cbShowTimeCounter.CheckedChanged += new System.EventHandler( this.cbShowTimeCounter_CheckedChanged );
			// 
			// cbAskPomodoroNameOnStart
			// 
			this.cbAskPomodoroNameOnStart.AutoSize = true;
			this.cbAskPomodoroNameOnStart.Checked = true;
			this.cbAskPomodoroNameOnStart.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAskPomodoroNameOnStart.Location = new System.Drawing.Point( 15, 81 );
			this.cbAskPomodoroNameOnStart.Name = "cbAskPomodoroNameOnStart";
			this.cbAskPomodoroNameOnStart.Size = new System.Drawing.Size( 162, 17 );
			this.cbAskPomodoroNameOnStart.TabIndex = 9;
			this.cbAskPomodoroNameOnStart.Text = "Ask Pomodoro name on start";
			this.cbAskPomodoroNameOnStart.UseVisualStyleBackColor = true;
			this.cbAskPomodoroNameOnStart.CheckedChanged += new System.EventHandler( this.cbAskPomodoroNameOnStart_CheckedChanged );
			// 
			// cbAlarmOnPomodoroEnd
			// 
			this.cbAlarmOnPomodoroEnd.AutoSize = true;
			this.cbAlarmOnPomodoroEnd.Checked = true;
			this.cbAlarmOnPomodoroEnd.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAlarmOnPomodoroEnd.Location = new System.Drawing.Point( 15, 104 );
			this.cbAlarmOnPomodoroEnd.Name = "cbAlarmOnPomodoroEnd";
			this.cbAlarmOnPomodoroEnd.Size = new System.Drawing.Size( 139, 17 );
			this.cbAlarmOnPomodoroEnd.TabIndex = 10;
			this.cbAlarmOnPomodoroEnd.Text = "Alarm on Pomodoro end";
			this.cbAlarmOnPomodoroEnd.UseVisualStyleBackColor = true;
			this.cbAlarmOnPomodoroEnd.CheckedChanged += new System.EventHandler( this.cbAlarmOnPomodoroEnd_CheckedChanged );
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point( 208, 264 );
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size( 43, 13 );
			this.label5.TabIndex = 13;
			this.label5.Text = "minutes";
			// 
			// nudBreakDuration
			// 
			this.nudBreakDuration.Location = new System.Drawing.Point( 161, 262 );
			this.nudBreakDuration.Maximum = new decimal( new int[] {
            999,
            0,
            0,
            0} );
			this.nudBreakDuration.Name = "nudBreakDuration";
			this.nudBreakDuration.Size = new System.Drawing.Size( 44, 20 );
			this.nudBreakDuration.TabIndex = 12;
			this.nudBreakDuration.ValueChanged += new System.EventHandler( this.nudBreakDuration_ValueChanged );
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point( 12, 264 );
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size( 79, 13 );
			this.label6.TabIndex = 11;
			this.label6.Text = "Break duration:";
			// 
			// cbAlarmOnBreakEnd
			// 
			this.cbAlarmOnBreakEnd.AutoSize = true;
			this.cbAlarmOnBreakEnd.Checked = true;
			this.cbAlarmOnBreakEnd.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAlarmOnBreakEnd.Location = new System.Drawing.Point( 15, 280 );
			this.cbAlarmOnBreakEnd.Name = "cbAlarmOnBreakEnd";
			this.cbAlarmOnBreakEnd.Size = new System.Drawing.Size( 119, 17 );
			this.cbAlarmOnBreakEnd.TabIndex = 14;
			this.cbAlarmOnBreakEnd.Text = "Alarm on Break end";
			this.cbAlarmOnBreakEnd.UseVisualStyleBackColor = true;
			this.cbAlarmOnBreakEnd.CheckedChanged += new System.EventHandler( this.cbAlarmOnBreakEnd_CheckedChanged );
			// 
			// cbAskInterruptReason
			// 
			this.cbAskInterruptReason.AutoSize = true;
			this.cbAskInterruptReason.Checked = true;
			this.cbAskInterruptReason.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbAskInterruptReason.Location = new System.Drawing.Point( 15, 199 );
			this.cbAskInterruptReason.Name = "cbAskInterruptReason";
			this.cbAskInterruptReason.Size = new System.Drawing.Size( 126, 17 );
			this.cbAskInterruptReason.TabIndex = 15;
			this.cbAskInterruptReason.Text = "Ask Interrupt Reason";
			this.cbAskInterruptReason.UseVisualStyleBackColor = true;
			this.cbAskInterruptReason.CheckedChanged += new System.EventHandler( this.cbAskInterruptReason_CheckedChanged );
			// 
			// cbTickingSoundOnBreak
			// 
			this.cbTickingSoundOnBreak.AutoSize = true;
			this.cbTickingSoundOnBreak.Checked = true;
			this.cbTickingSoundOnBreak.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbTickingSoundOnBreak.Location = new System.Drawing.Point( 15, 351 );
			this.cbTickingSoundOnBreak.Name = "cbTickingSoundOnBreak";
			this.cbTickingSoundOnBreak.Size = new System.Drawing.Size( 138, 17 );
			this.cbTickingSoundOnBreak.TabIndex = 16;
			this.cbTickingSoundOnBreak.Text = "Ticking sound on break";
			this.cbTickingSoundOnBreak.UseVisualStyleBackColor = true;
			this.cbTickingSoundOnBreak.CheckedChanged += new System.EventHandler( this.cbTickingSoundOnBreak_CheckedChanged );
			// 
			// cbResetOnInterruptTimeout
			// 
			this.cbResetOnInterruptTimeout.AutoSize = true;
			this.cbResetOnInterruptTimeout.Checked = true;
			this.cbResetOnInterruptTimeout.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbResetOnInterruptTimeout.Location = new System.Drawing.Point( 15, 179 );
			this.cbResetOnInterruptTimeout.Name = "cbResetOnInterruptTimeout";
			this.cbResetOnInterruptTimeout.Size = new System.Drawing.Size( 198, 17 );
			this.cbResetOnInterruptTimeout.TabIndex = 17;
			this.cbResetOnInterruptTimeout.Text = "Reset Pomodoro on interrupt timeout";
			this.cbResetOnInterruptTimeout.UseVisualStyleBackColor = true;
			this.cbResetOnInterruptTimeout.CheckedChanged += new System.EventHandler( this.cbResetOnInterruptTimeout_CheckedChanged );
			// 
			// cbMessageOnPomodoroEnd
			// 
			this.cbMessageOnPomodoroEnd.AutoSize = true;
			this.cbMessageOnPomodoroEnd.Checked = true;
			this.cbMessageOnPomodoroEnd.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbMessageOnPomodoroEnd.Location = new System.Drawing.Point( 15, 127 );
			this.cbMessageOnPomodoroEnd.Name = "cbMessageOnPomodoroEnd";
			this.cbMessageOnPomodoroEnd.Size = new System.Drawing.Size( 156, 17 );
			this.cbMessageOnPomodoroEnd.TabIndex = 18;
			this.cbMessageOnPomodoroEnd.Text = "Message on Pomodoro end";
			this.cbMessageOnPomodoroEnd.UseVisualStyleBackColor = true;
			this.cbMessageOnPomodoroEnd.CheckedChanged += new System.EventHandler( this.cbMessageOnPomodoroEnd_CheckedChanged );
			// 
			// tbMessageOnPomodoroEnd
			// 
			this.tbMessageOnPomodoroEnd.Location = new System.Drawing.Point( 34, 149 );
			this.tbMessageOnPomodoroEnd.Name = "tbMessageOnPomodoroEnd";
			this.tbMessageOnPomodoroEnd.Size = new System.Drawing.Size( 217, 20 );
			this.tbMessageOnPomodoroEnd.TabIndex = 19;
			this.tbMessageOnPomodoroEnd.Text = "Hey, stop! Time to have a break!";
			this.tbMessageOnPomodoroEnd.TextChanged += new System.EventHandler( this.tbMessageOnPomodoroEnd_TextChanged );
			// 
			// tbMessageOnBreakEnd
			// 
			this.tbMessageOnBreakEnd.Location = new System.Drawing.Point( 34, 324 );
			this.tbMessageOnBreakEnd.Name = "tbMessageOnBreakEnd";
			this.tbMessageOnBreakEnd.Size = new System.Drawing.Size( 217, 20 );
			this.tbMessageOnBreakEnd.TabIndex = 21;
			this.tbMessageOnBreakEnd.Text = "Break is finished! Get back to work!";
			this.tbMessageOnBreakEnd.TextChanged += new System.EventHandler( this.tbMessageOnBreakEnd_TextChanged );
			// 
			// cbMessageOnBreakEnd
			// 
			this.cbMessageOnBreakEnd.AutoSize = true;
			this.cbMessageOnBreakEnd.Checked = true;
			this.cbMessageOnBreakEnd.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbMessageOnBreakEnd.Location = new System.Drawing.Point( 15, 302 );
			this.cbMessageOnBreakEnd.Name = "cbMessageOnBreakEnd";
			this.cbMessageOnBreakEnd.Size = new System.Drawing.Size( 156, 17 );
			this.cbMessageOnBreakEnd.TabIndex = 20;
			this.cbMessageOnBreakEnd.Text = "Message on Pomodoro end";
			this.cbMessageOnBreakEnd.UseVisualStyleBackColor = true;
			this.cbMessageOnBreakEnd.CheckedChanged += new System.EventHandler( this.cbMessageOnBreakEnd_CheckedChanged );
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size( 279, 374 );
			this.Controls.Add( this.tbMessageOnBreakEnd );
			this.Controls.Add( this.cbMessageOnBreakEnd );
			this.Controls.Add( this.tbMessageOnPomodoroEnd );
			this.Controls.Add( this.cbMessageOnPomodoroEnd );
			this.Controls.Add( this.cbResetOnInterruptTimeout );
			this.Controls.Add( this.label3 );
			this.Controls.Add( this.label6 );
			this.Controls.Add( this.nudMaxInterruptionDuration );
			this.Controls.Add( this.nudBreakDuration );
			this.Controls.Add( this.label4 );
			this.Controls.Add( this.label5 );
			this.Controls.Add( this.cbAskInterruptReason );
			this.Controls.Add( this.cbTickingSoundOnBreak );
			this.Controls.Add( this.cbAlarmOnBreakEnd );
			this.Controls.Add( this.cbAlarmOnPomodoroEnd );
			this.Controls.Add( this.cbAskPomodoroNameOnStart );
			this.Controls.Add( this.cbShowTimeCounter );
			this.Controls.Add( this.cbTickingSound );
			this.Controls.Add( this.label2 );
			this.Controls.Add( this.nudPomodoroDuration );
			this.Controls.Add( this.label1 );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ( (System.Drawing.Icon)( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size( 285, 400 );
			this.MinimumSize = new System.Drawing.Size( 285, 299 );
			this.Name = "SettingsForm";
			this.Opacity = 0.9;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pomodoro Settings";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.SettingsForm_FormClosing );
			this.Resize += new System.EventHandler( this.SettingsForm_Resize );
			this.contextMenuStrip1.ResumeLayout( false );
			( (System.ComponentModel.ISupportInitialize)( this.nudPomodoroDuration ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.nudMaxInterruptionDuration ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.nudBreakDuration ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPomodoroDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMaxInterruptionDuration;
        private System.Windows.Forms.CheckBox cbTickingSound;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startPomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem interruptPomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumePomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbShowTimeCounter;
        private System.Windows.Forms.CheckBox cbAskPomodoroNameOnStart;
        private System.Windows.Forms.CheckBox cbAlarmOnPomodoroEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudBreakDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbAlarmOnBreakEnd;
        private System.Windows.Forms.CheckBox cbAskInterruptReason;
        private System.Windows.Forms.CheckBox cbTickingSoundOnBreak;
		private System.Windows.Forms.CheckBox cbResetOnInterruptTimeout;
		private System.Windows.Forms.CheckBox cbMessageOnPomodoroEnd;
		private System.Windows.Forms.TextBox tbMessageOnPomodoroEnd;
		private System.Windows.Forms.TextBox tbMessageOnBreakEnd;
		private System.Windows.Forms.CheckBox cbMessageOnBreakEnd;
    }
}

