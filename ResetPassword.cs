using System;
using System.Text;
using System.Windows.Forms;

namespace Personal_Organizer
{
    public partial class ResetPassword : Form
    {
        private CsvHelper _csvHelper; // CsvHelper nesnesi burada tanımlanmalı
        private string _email;
        private string _password;

        public ResetPassword(string email, string password, CsvHelper csvHelper) // CsvHelper parametresi eklendi
        {
            InitializeComponent();
            _email = email;
            _password = password;
            _csvHelper = csvHelper; // CsvHelper nesnesi atanmalı
            lbl_secret.Text = GenerateRandomString(10);
        }

        private string GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                builder.Append(chars[random.Next(chars.Length)]);
            }
            return builder.ToString();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }
            if (textBox1.Text == _password)
            {
                if (textBox2.Text == textBox3.Text)
                {
                    if (textBox4.Text == lbl_secret.Text)
                    {
                        _csvHelper.UpdateUserPassword(_email, textBox2.Text); // Yeni şifre textBox1.Text'ten alınıyor
                        MessageBox.Show("Password updated successfully.");
                        this.Close();
                    }
                    else 
                    {
                        MessageBox.Show("Security code is incorrect.");
                    }
                }
                else
                {
                    MessageBox.Show("New passwords do not match.");
                }
            }
            else
            {
                MessageBox.Show("Your code is wrong.");
            }
        }


    }
}
