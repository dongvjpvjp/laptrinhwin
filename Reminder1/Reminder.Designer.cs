namespace Reminder1
{
    partial class Reminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reminder));
            this.lb_nowtime = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.mtb_time = new System.Windows.Forms.MaskedTextBox();
            this.lb_mess = new System.Windows.Forms.Label();
            this.tb_mess = new System.Windows.Forms.TextBox();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_hide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lb_nexttime = new System.Windows.Forms.Label();
            this.mtb_day = new System.Windows.Forms.MaskedTextBox();
            this.tb_audio = new System.Windows.Forms.TextBox();
            this.bt_select_audio = new System.Windows.Forms.Button();
            this.lb_rington = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nowtime
            // 
            this.lb_nowtime.AutoSize = true;
            this.lb_nowtime.Location = new System.Drawing.Point(12, 9);
            this.lb_nowtime.Name = "lb_nowtime";
            this.lb_nowtime.Size = new System.Drawing.Size(30, 13);
            this.lb_nowtime.TabIndex = 0;
            this.lb_nowtime.Text = "Time";
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(25, 45);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(74, 13);
            this.lb_time.TabIndex = 1;
            this.lb_time.Text = "Day And Time";
            // 
            // mtb_time
            // 
            this.mtb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_time.Location = new System.Drawing.Point(28, 104);
            this.mtb_time.Mask = "00:00";
            this.mtb_time.Name = "mtb_time";
            this.mtb_time.Size = new System.Drawing.Size(97, 26);
            this.mtb_time.TabIndex = 2;
            // 
            // lb_mess
            // 
            this.lb_mess.AutoSize = true;
            this.lb_mess.Location = new System.Drawing.Point(25, 199);
            this.lb_mess.Name = "lb_mess";
            this.lb_mess.Size = new System.Drawing.Size(50, 13);
            this.lb_mess.TabIndex = 4;
            this.lb_mess.Text = "Message";
            // 
            // tb_mess
            // 
            this.tb_mess.Location = new System.Drawing.Point(31, 215);
            this.tb_mess.Multiline = true;
            this.tb_mess.Name = "tb_mess";
            this.tb_mess.Size = new System.Drawing.Size(163, 82);
            this.tb_mess.TabIndex = 4;
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(31, 333);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(163, 23);
            this.bt_start.TabIndex = 5;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Enabled = false;
            this.bt_stop.Location = new System.Drawing.Point(31, 362);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(163, 23);
            this.bt_stop.TabIndex = 6;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_hide
            // 
            this.bt_hide.Image = ((System.Drawing.Image)(resources.GetObject("bt_hide.Image")));
            this.bt_hide.Location = new System.Drawing.Point(191, 391);
            this.bt_hide.Name = "bt_hide";
            this.bt_hide.Size = new System.Drawing.Size(24, 23);
            this.bt_hide.TabIndex = 7;
            this.bt_hide.UseVisualStyleBackColor = true;
            this.bt_hide.Click += new System.EventHandler(this.bt_hide_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 900;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Reminder program is now minimize to system tray ";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Reminder";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lb_nexttime
            // 
            this.lb_nexttime.AutoSize = true;
            this.lb_nexttime.Location = new System.Drawing.Point(12, 300);
            this.lb_nexttime.Name = "lb_nexttime";
            this.lb_nexttime.Size = new System.Drawing.Size(10, 13);
            this.lb_nexttime.TabIndex = 9;
            this.lb_nexttime.Text = ".";
            // 
            // mtb_day
            // 
            this.mtb_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_day.Location = new System.Drawing.Point(28, 70);
            this.mtb_day.Mask = "00/00/0000";
            this.mtb_day.Name = "mtb_day";
            this.mtb_day.Size = new System.Drawing.Size(97, 26);
            this.mtb_day.TabIndex = 1;
            this.mtb_day.ValidatingType = typeof(System.DateTime);
            // 
            // tb_audio
            // 
            this.tb_audio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_audio.CausesValidation = false;
            this.tb_audio.Enabled = false;
            this.tb_audio.ForeColor = System.Drawing.Color.Black;
            this.tb_audio.Location = new System.Drawing.Point(28, 157);
            this.tb_audio.Name = "tb_audio";
            this.tb_audio.Size = new System.Drawing.Size(143, 20);
            this.tb_audio.TabIndex = 11;
            this.tb_audio.Text = "Default";
            // 
            // bt_select_audio
            // 
            this.bt_select_audio.Image = ((System.Drawing.Image)(resources.GetObject("bt_select_audio.Image")));
            this.bt_select_audio.Location = new System.Drawing.Point(177, 157);
            this.bt_select_audio.Name = "bt_select_audio";
            this.bt_select_audio.Size = new System.Drawing.Size(35, 23);
            this.bt_select_audio.TabIndex = 3;
            this.bt_select_audio.UseVisualStyleBackColor = true;
            this.bt_select_audio.Click += new System.EventHandler(this.bt_select_audio_Click);
            // 
            // lb_rington
            // 
            this.lb_rington.AutoSize = true;
            this.lb_rington.Location = new System.Drawing.Point(22, 141);
            this.lb_rington.Name = "lb_rington";
            this.lb_rington.Size = new System.Drawing.Size(50, 13);
            this.lb_rington.TabIndex = 12;
            this.lb_rington.Text = "Ringtone";
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 418);
            this.Controls.Add(this.lb_rington);
            this.Controls.Add(this.bt_select_audio);
            this.Controls.Add(this.bt_hide);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.tb_mess);
            this.Controls.Add(this.mtb_time);
            this.Controls.Add(this.mtb_day);
            this.Controls.Add(this.tb_audio);
            this.Controls.Add(this.lb_nexttime);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.lb_mess);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_nowtime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Reminder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder";
            this.Load += new System.EventHandler(this.Reminder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nowtime;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.MaskedTextBox mtb_time;
        private System.Windows.Forms.Label lb_mess;
        private System.Windows.Forms.TextBox tb_mess;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_hide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lb_nexttime;
        private System.Windows.Forms.MaskedTextBox mtb_day;
        private System.Windows.Forms.TextBox tb_audio;
        private System.Windows.Forms.Button bt_select_audio;
        private System.Windows.Forms.Label lb_rington;
    }
}

