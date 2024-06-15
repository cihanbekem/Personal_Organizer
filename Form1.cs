using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Organizer
{
    public partial class Form1 : Form
    {
        UserInfo _user;
        public Form1(UserInfo user)
        {
            InitializeComponent();
            _user = user;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mnf = new MainForm(_user);
            mnf.Show();
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.PeachPuff; // Default background color
        }
    }
}
