using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reminder1
{
    public partial class Mess : Form
    {
        public string daytime;
        public string mess;
        
        
        
        public Mess()
        {
            InitializeComponent();
            
        }

        private void Mess_Load(object sender, EventArgs e)
        {
            
           
            lb_TB.Text = "Thông báo bây giờ là: " + daytime;
            tb_mess.Text = mess;
            
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_snooze_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }
    }
}                                                                            