using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Personal_Organizer
{
    public partial class Register : Form
    {
        private CsvHelper csvHelper;

        public Register()
        {
            InitializeComponent();
            csvHelper = new CsvHelper();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name field is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Surname field is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Phone number field is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Address field is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email field is required.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password field is required.");
                return;
            }

            UserInfo user = new UserInfo
            {
                Id = Guid.NewGuid().ToString(),
                Name = txtName.Text,
                Surname = txtSurname.Text,
                PhoneNumber = txtPhone.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Password = txtPassword.Text,
            };

            bool isRegistered = csvHelper.RegisterUser(user);
            if (pictureBox.Image != null)
            {
                string base64String = ImageToBase64(pictureBox.Image, System.Drawing.Imaging.ImageFormat.Png);

                using (StreamWriter sw = new StreamWriter("images" + user.Id + ".csv", true))
                {
                    sw.WriteLine(base64String);
                }
            }
            else
            {
                Console.WriteLine("No image to save.");
            }

            if (isRegistered)
            {
                MessageBox.Show("Registration Successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration Cannot Be Done Because There Is Another Account With The Same Email.");
            }
        }

        private string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        private void btnpicture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}
