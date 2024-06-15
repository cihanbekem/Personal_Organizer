using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Personal_Organizer
{
    public partial class Login : Form
    {
        private string user_email;
        private string user_password;
        public Login()
        {
            InitializeComponent();
            csvHelper = new CsvHelper();

            // Attach the KeyPress event handler to txtEmail
            this.txtEmail.KeyPress += new KeyPressEventHandler(txtEmail_KeyPress);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register form2 = new Register();
            form2.Show();
        }

        private CsvHelper csvHelper;

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email field is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password field is required.");
                return;
            }

            UserInfo user = csvHelper.ValidateUser(email, password);
            if (user != null)
            {
                MessageBox.Show("Login Successful!");
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email or password is incorrect.");
            }
        }

        private void btn_sifre_Click(object sender, EventArgs e)
        {
            ForgetPassword sfr = new ForgetPassword();
            sfr.ShowDialog();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancel the closing operation
                }
                else
                {
                    this.Hide();
                    ExitScreen cks = new ExitScreen();
                    cks.ShowDialog();

                    // Allow the form to close when the process is complete
                }
            }
        }

        bool flag = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                txtPassword.UseSystemPasswordChar = false;
                btn_show.Text = "Hide";
                flag = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btn_show.Text = "Show";
                flag = false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '@')
            {
                string emailText = txtEmail.Text;
                int cursorPosition = txtEmail.SelectionStart;

                if (!emailText.Contains("@") || (emailText.IndexOf("@") > cursorPosition - 1))
                {
                    // Append @gmail.com if it's not already there
                    txtEmail.Text = emailText.Insert(cursorPosition, "@gmail.com");
                    txtEmail.SelectionStart = cursorPosition + 10; // Move the cursor after @gmail.com
                    e.Handled = true; // Suppress the default behavior of '@' character
                }
            }
        }
    }
}