namespace Pomodoro
{
    partial class InterruptionNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterruptionNameForm));
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnkOK = new System.Windows.Forms.Button();
            this.lbReasons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReason
            // 
            this.txtReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReason.Location = new System.Drawing.Point(12, 145);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(279, 20);
            this.txtReason.TabIndex = 0;
            // 
            // btnkOK
            // 
            this.btnkOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkOK.Location = new System.Drawing.Point(216, 171);
            this.btnkOK.Name = "btnkOK";
            this.btnkOK.Size = new System.Drawing.Size(75, 23);
            this.btnkOK.TabIndex = 1;
            this.btnkOK.Text = "OK";
            this.btnkOK.UseVisualStyleBackColor = true;
            this.btnkOK.Click += new System.EventHandler(this.btnkOK_Click);
            // 
            // lbReasons
            // 
            this.lbReasons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbReasons.FormattingEnabled = true;
            this.lbReasons.Location = new System.Drawing.Point(12, 25);
            this.lbReasons.Name = "lbReasons";
            this.lbReasons.Size = new System.Drawing.Size(279, 95);
            this.lbReasons.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose a reason for Interruption:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OR type your reason:";
            // 
            // InterruptionNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(303, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbReasons);
            this.Controls.Add(this.btnkOK);
            this.Controls.Add(this.txtReason);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterruptionNameForm";
            this.Opacity = 0.95;
            this.Text = "Interrupt Reason";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnkOK;
        private System.Windows.Forms.ListBox lbReasons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}