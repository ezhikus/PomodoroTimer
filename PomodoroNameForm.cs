using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pomodoro
{
    public partial class PomodoroNameForm : Form
    {
        public string PomodoroDescription
        {
            get { return txtPomodoroDescription.Text; }
        }

        public PomodoroNameForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtPomodoroDescription.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter a description for the Pomodoro.");
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
