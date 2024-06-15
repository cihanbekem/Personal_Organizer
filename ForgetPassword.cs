using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;


namespace Personal_Organizer
{
    public partial class ForgetPassword : Form
    {
        private System.Windows.Forms.Timer timer;
        private int timeLeft;
        private CsvHelper csvHelper;

        public ForgetPassword()
        {
            InitializeComponent();
            csvHelper = new CsvHelper(); // Initialize the CSV helper
        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            progressBar1.Visible = true;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter an email address.");
                return;
            }
          
            SendEmail(email);
            
            return;

        }

        private void SendEmail(string toEmail)
        {
            // Check if the email exists in the CSV file
            CsvHelper csvHelper = new CsvHelper();
            var user = csvHelper.GetAllUsers().FirstOrDefault(u => u.Email == toEmail);

            if (user == null)
            {
                MessageBox.Show("The entered e-mail address was not found in the system.");
                return;
            }

            // Generate a random new password
            Random rnd = new Random();
            int newPassword = rnd.Next(10000, 99999); // Generate a random number between 10000 and 99999
            string newPasswordStr = newPassword.ToString();
            ResetPassword yenile = new ResetPassword(toEmail, newPasswordStr, csvHelper);

            // SMTP settings
            string fromEmail = "BCEGY@outlook.com";
            string fromPassword = "OOP_lab_2024"; // Consider using an app-specific password if 2FA is enabled
            string smtpHost = "smtp-mail.outlook.com";
            int smtpPort = 587; // Use port 587 for TLS

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(fromEmail);
            mail.To.Add(toEmail);
            mail.Subject = "Reset Password";
            mail.Body = $"This is a test email to reset your password.{Environment.NewLine}This is your code: {newPasswordStr}";

            SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
            smtpClient.Credentials = new NetworkCredential(fromEmail, fromPassword);
            smtpClient.EnableSsl = true; // Enable SSL for secure connection

            for(int i = 0; i <= 100; i+=10)
            {
                progressBar1.Value = i;
                Thread.Sleep(100);
            }

            MessageBox.Show("Succesfuly");

            smtpClient.Send(mail);

            // Update the user's password in the CSV file
            yenile.Show();
            this.Hide();
        }

    }
}
