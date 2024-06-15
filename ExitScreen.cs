using System.Drawing;
using System.Windows.Forms;
using System;
using System.Diagnostics;

namespace Personal_Organizer
{
    public partial class ExitScreen : Form
    {
        private Timer timer1;
        int count = 0;

        public ExitScreen()
        {
            InitializeComponent();
            timer1 = new Timer(); // Timer nesnesini oluştur
            timer1.Interval = 1000; // Timer'ın çalışma aralığını ayarla (örneğin, her saniye)
            timer1.Tick += timer1_Tick; // Timer'ın Tick olayına olay işleyiciyi ata
            timer1.Start(); // Timer'ı başlat

            this.FormClosing += new FormClosingEventHandler(ExitScreen_FormClosing);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            // Tüm labelları y ekseninde 10 birim yukarı taşı
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    control.Location = new Point(control.Location.X, control.Location.Y - 30);
                }
            }
            if (count == 13)
            {
                Application.Exit(); // Uygulamayı kapat
            }
        }

        private void ExitScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop(); // Timer'ı durdur
            Application.Exit(); // Uygulamayı kapat
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Belirtilen URL'yi tarayıcıda aç
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/baturhan-%C3%A7a%C4%9Fatay-168189230/",
                UseShellExecute = true
            });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/cihanbekem/",
                UseShellExecute = true
            });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/emregunerr/",
                UseShellExecute = true
            });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/g%C3%BCrkan-karaman-5155a8229/",
                UseShellExecute = true
            });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/yaren-ama%C3%A7/",
                UseShellExecute = true
            });
        }
    }
}
