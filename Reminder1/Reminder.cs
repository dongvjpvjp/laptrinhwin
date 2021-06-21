using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Media;
namespace Reminder1
{
    public partial class Reminder : Form
    {
        public String currentime;
        //public String messagetime;
        public String currentday;
        //public String messageday;
        //public String[] wavdir;
        public SoundPlayer wav = new SoundPlayer();
        public Mess ring = new Mess();
        public Reminder()
        {
            InitializeComponent();

        }




        private void Reminder_Load(object sender, EventArgs e)
        {
            mtb_day.Select();
            mtb_day.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tb_audio.Text = "Default";
            wav.SoundLocation = Application.StartupPath + @"/Default.wav";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            currentime = DateTime.Now.ToString("HH:mm");
            currentday = DateTime.Now.ToString("dd/MM/yyyy");
            lb_nowtime.Text = currentime + " " + currentday;

        }
        private void set_messbox() // CHO MESS.CS
        {
            ring.daytime = mtb_time.Text + " - " + mtb_day.Text;
            ring.mess = tb_mess.Text;
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //messagetime = mtb_time.Text; 
            //messageday = mtb_day.Text;
            lb_nexttime.Text = "Reminder set for " + mtb_time.Text + " - " + mtb_day.Text;
            if (currentime == mtb_time.Text && currentday == mtb_day.Text )
            {
                bt_stop_Click(sender, e);
                wav.PlayLooping();
                this.Hide();
                ring.ShowDialog();

                if (ring.DialogResult == DialogResult.OK)
                //var res = MessageBox.Show(tb_mess.Text,"Thong bao",MessageBoxButtons.OK,MessageBoxIcon.Information);
                //if (res == DialogResult.OK)
                {
                    wav.Stop();
                    this.Show();
                    bt_start.Enabled = true;
                    bt_stop.Enabled = false;
                    lb_nexttime.Text = " ";
                }
                if (ring.DialogResult == DialogResult.Cancel)
                {
                    var dp =  MessageBox.Show("Báo thức sẽ được đặt lại trong 5 phút", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    if (dp == DialogResult.OK)
                    {
                        this.Show();
                        wav.Stop();
                        mtb_time.Text = DateTime.Now.AddMinutes(5).ToString("HH:mm");
                        //mtb_time.Text = DateTime.Now.AddSeconds(5).ToString("HH:mm");
                        bt_start_Click(sender, e);
                    }
                     
                }
               
            }
        }
        private void bt_start_Click(object sender, EventArgs e)
        {
            if (run() == true)
            {
                timer2.Start();
                bt_start.Enabled = false;
                bt_stop.Enabled = true;
                mtb_day.Enabled = false;
                mtb_time.Enabled = false;
                tb_mess.Enabled = false;
                bt_select_audio.Enabled = false;
                set_messbox();
            }
            else
            {
                MessageBox.Show("Thong tin nhap sai cu phap hoac khong chinh xac", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public bool run()
        {
            try
            {
                byte h, m;
                byte hn, mn;
                //string temph = mtb_time.Text.Substring(0, 2);
                //string tempm = mtb_time.Text.Substring(3, 2);
                //string temps = mtb_time.Text.Substring(6, 2);
                //string temphn = currentime.Substring(0, 2);
                //string tempmn = currentime.Substring(3, 2);
                //string tempsn = currentime.Substring(6, 2);
                //h = Convert.ToInt32(mtb_time.Text.Substring(0, 2));
                //m = Convert.ToInt32(mtb_time.Text.Substring(3, 2));
                h = byte.Parse(mtb_time.Text.Substring(0, 2));
                m = byte.Parse(mtb_time.Text.Substring(3, 2));
                //s = Convert.ToInt32(mtb_time.Text.Substring(6, 2));
                //hn = Convert.ToInt32(currentime.Substring(0, 2));
                //mn = Convert.ToInt32(currentime.Substring(3, 2));
                hn = byte.Parse(currentime.Substring(0, 2));
                mn = byte.Parse(currentime.Substring(3, 2));
                //sn = Convert.ToInt32(currentime.Substring(6, 2));
                byte d, mm;
                uint y;
                byte dn, mmn;
                uint yn;
                //string tempd = mtb_day.Text.Substring(0, 2);
                //string tempmm = mtb_day.Text.Substring(3, 2);
                //string tempy = mtb_day.Text.Substring(6, 4);
                //string tempdn = currentday.Substring(0, 2);
                //string tempmmn = currentday.Substring(3, 2);
                //string tempyn = currentday.Substring(6, 4);
                //d = Convert.ToInt32(mtb_day.Text.Substring(0, 2));
                //mm = Convert.ToInt32(mtb_day.Text.Substring(3, 2));
                //y = Convert.ToInt32(mtb_day.Text.Substring(6, 4));
                //dn = Convert.ToInt32(currentday.Substring(0, 2));
                //mmn = Convert.ToInt32(currentday.Substring(3, 2));
                //yn = Convert.ToInt32(currentday.Substring(6, 4));
                
                d = byte.Parse(mtb_day.Text.Substring(0, 2));
                mm = byte.Parse(mtb_day.Text.Substring(3, 2));
                y = UInt16.Parse(mtb_day.Text.Substring(6, 4));
                dn = byte.Parse(currentday.Substring(0, 2));
                mmn = byte.Parse(currentday.Substring(3, 2));
                yn = UInt16.Parse(currentday.Substring(6, 4));
                switch (mm) // setup date
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (d > 30)
                        {
                            return false;
                        }
                        break;
                    case 2:
                        if (y % 4 == 0 && y % 100 != 0 || y % 400 == 0) //code check nam nhuan 
                        {
                            if (d > 29)
                            {
                                return false;
                            }
                        }
                        else
                        {
                            if (d > 28)
                            {
                                return false;
                            }
                        }
                        break;
                }
                if (tb_mess.Text == String.Empty || mtb_time.Text.Contains(" ") == true || mtb_day.Text.Contains(" ") == true || tb_audio.Text == String.Empty)
                {
                    return false;
                }
                else if (d > 31 || mm > 12 || y > 3000)
                {
                    return false;
                }
                else if (h > 24 || m > 59 )//||  s > 59) // setup time
                {
                    return false;
                }
                else if (d > dn || m > mn || y > yn) // bat loi date + time
                {
                    if (h < hn || m < mn )//|| s < sn)
                        return true;
                }
                else
                {

                    if (y == yn && mm == mmn && d < dn)
                    {
                        return false;
                    }
                    if (y == yn && mm < mmn)
                    {
                        return false;
                    }
                    if (y < yn)
                    {
                        return false;
                    }
                    /*if (h == hn && m == mn && s < sn)
                    {
                        return false;
                    }*/
                    if (h == hn && m < mn)
                    {
                        return false;
                    }
                    if (h < hn)
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            bt_start.Enabled = true;
            bt_stop.Enabled = false;
            lb_nexttime.Text = " ";
            mtb_day.Enabled = true;
            mtb_time.Enabled = true;
            tb_mess.Enabled = true;
            bt_select_audio.Enabled = true;
        }

        private void bt_hide_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            this.Hide();
            notifyIcon1.ShowBalloonTip(2000);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
        }

        private void bt_select_audio_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WAV Files only(*.wav)|*.wav";
            ofd.DefaultExt = ".wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tb_audio.Text = ofd.FileName;
                wav.SoundLocation = tb_audio.Text;
            }
        }

        












        /* public UInt32 check_int(string a)
           {
               try
               {
                   uint x = Convert.ToUInt32(a);
                   return x;
               }
               catch (System.FormatException)
               {
                   return 0;
               } 
          }*/

    }
}
