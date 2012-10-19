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
    public partial class InterruptionNameForm : Form
    {
        public string Reason
        {
            get 
            {
                if (lbReasons.SelectedItem == null || txtReason.Text.Trim().Length > 0)
                {
                    return txtReason.Text.Trim(); 
                }
                else
                {
                    return lbReasons.SelectedItem.ToString();
                }
            }
        }

        public InterruptionNameForm(string[] reasons)
        {
            InitializeComponent();
            lbReasons.Items.AddRange(reasons);
        }

        private void btnkOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
