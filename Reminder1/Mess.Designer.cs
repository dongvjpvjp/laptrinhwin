namespace Reminder1
{
    partial class Mess
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
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_snooze = new System.Windows.Forms.Button();
            this.tb_mess = new System.Windows.Forms.TextBox();
            this.lb_TB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(43, 135);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(75, 23);
            this.bt_OK.TabIndex = 0;
            this.bt_OK.Text = "OK";
            this.bt_OK.UseVisualStyleBackColor = true;
            this.bt_OK.Click += new System.EventHandler(this.bt_OK_Click);
            // 
            // bt_snooze
            // 
            this.bt_snooze.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_snooze.Location = new System.Drawing.Point(182, 135);
            this.bt_snooze.Name = "bt_snooze";
            this.bt_snooze.Size = new System.Drawing.Size(75, 23);
            this.bt_snooze.TabIndex = 1;
            this.bt_snooze.Text = "Snooze";
            this.bt_snooze.UseVisualStyleBackColor = true;
            this.bt_snooze.Click += new System.EventHandler(this.bt_snooze_Click);
            // 
            // tb_mess
            // 
            this.tb_mess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_mess.Enabled = false;
            this.tb_mess.Location = new System.Drawing.Point(43, 46);
            this.tb_mess.Multiline = true;
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.Size = new System.Drawing.Size(214, 83);
            this.tb_mess.TabIndex = 2;
            // 
            // lb_TB
            // 
            this.lb_TB.AutoSize = true;
            this.lb_TB.Location = new System.Drawing.Point(40, 19);
            this.lb_TB.Name = "lb_TB";
            this.lb_TB.Size = new System.Drawing.Size(66, 13);
            this.lb_TB.TabIndex = 3;
            this.lb_TB.Text = "Thông Báo: ";
            this.lb_TB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 170);
            this.Controls.Add(this.lb_TB);
            this.Controls.Add(this.tb_mess);
            this.Controls.Add(this.bt_snooze);
            this.Controls.Add(this.bt_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Mess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mess";
            this.Load += new System.EventHandler(this.Mess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_snooze;
        private System.Windows.Forms.TextBox tb_mess;
        private System.Windows.Forms.Label lb_TB;
    }
}