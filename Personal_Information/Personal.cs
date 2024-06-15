using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Personal_Information
{
    public partial class Personal : Form
    {

        
        string imagePath = Directory.GetCurrentDirectory() + @"\images.csv";
        string filePath =  Directory.GetCurrentDirectory() + @"\User_Info.txt";

        private void Form1_KeyUndo(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && e.Control)
            {
                Undo();
            }
        }
        private void Form1_KeyRedo(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Y && e.Control)
            {
                Redo();
                e.SuppressKeyPress = true;
            }
        }

        public Personal()
        {
            InitializeComponent();
            Console.WriteLine(Directory.GetCurrentDirectory());
            this.KeyDown += new KeyEventHandler(Form1_KeyUndo);
            this.KeyDown += new KeyEventHandler(Form1_KeyRedo);

            UserInfo userInfo = ReadFromFile(filePath);

            textBox_name.Text = userInfo.Name;
            textBox_surname.Text = userInfo.Surname;
            textBox_phone_number.Text = userInfo.PhoneNumber;
            textBox_adress.Text = userInfo.Address;
            textBox_email.Text = userInfo.Email;
            textBox_password.Text = userInfo.Password;
            UndoUserInfo.Push(userInfo);

            try
            {
                string[] lines = File.ReadAllLines(imagePath);
                foreach (string line in lines)
                {
                    byte[] imageBytes = Convert.FromBase64String(line);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox_profile.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public class UserInfo
        {
            private string name;
            private string surname;
            private string phoneNumber;
            private string address;
            private string email;
            private string password;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }

            public string PhoneNumber
            {
                get { return phoneNumber; }
                set { phoneNumber = value; }
            }

            public string Address
            {
                get { return address; }
                set { address = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
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

        static void WriteToFile(string filePath, UserInfo userInfo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(userInfo.Name + "," + userInfo.Surname + "," + userInfo.PhoneNumber + "," + userInfo.Address + "," + userInfo.Email + "," + userInfo.Password);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static UserInfo ReadFromFile(string filePath)
        {
            UserInfo userInfo = new UserInfo();
            string content = "";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    content = reader.ReadLine();
                    string[] content_parts = content.Split(',');
                    userInfo.Name = content_parts[0];
                    userInfo.Surname = content_parts[1];
                    userInfo.PhoneNumber = content_parts[2];
                    userInfo.Address = content_parts[3];
                    userInfo.Email = content_parts[4];
                    userInfo.Password = content_parts[5];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return userInfo;
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            UserInfo userInfo = new UserInfo();
            userInfo.Name = textBox_name.Text;
            userInfo.Surname = textBox_surname.Text;
            userInfo.PhoneNumber = textBox_phone_number.Text;
            userInfo.Address = textBox_adress.Text;
            userInfo.Email = textBox_email.Text;
            userInfo.Password = textBox_password.Text;

            WriteToFile(filePath, userInfo);

            if (pictureBox_profile.Image != null)
            {
                string base64String = ImageToBase64(pictureBox_profile.Image, System.Drawing.Imaging.ImageFormat.Png);

                using (StreamWriter sw = new StreamWriter("images.csv", true))
                {
                    sw.WriteLine(base64String);
                }
            }
            else
            {
                Console.WriteLine("No image to save.");
            }

            MessageBox.Show("Save is succesfuly ended.");
        }

        private void button_change_picture_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox_profile.Image = Image.FromFile(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void InitialState(UserInfo userInfo)
        {
            userInfo.Name = textBox_name.Text;
            userInfo.Surname = textBox_surname.Text;
            userInfo.PhoneNumber = textBox_phone_number.Text;
            userInfo.Address = textBox_adress.Text;
            userInfo.Email = textBox_email.Text;
            userInfo.Password = textBox_password.Text;
        }

        private void ChangeState(UserInfo userInfo)
        {
            textBox_name.Text = userInfo.Name;
            textBox_name.SelectionStart = textBox_name.Text.Length;
            textBox_surname.Text = userInfo.Surname;
            textBox_surname.SelectionStart = textBox_surname.Text.Length;
            textBox_phone_number.Text = userInfo.PhoneNumber;
            textBox_phone_number.SelectionStart = textBox_phone_number.Text.Length;
            textBox_adress.Text = userInfo.Address;
            textBox_adress.SelectionStart = textBox_adress.Text.Length;
            textBox_email.Text = userInfo.Email;
            textBox_email.SelectionStart = textBox_email.Text.Length;
            textBox_password.Text = userInfo.Password;
            textBox_password.SelectionStart = textBox_password.Text.Length;
        }
        private void Undo()
        {
            try
            {
                if (UndoUserInfo.Count == 1)
                    return;

                RedoUserInfo.Push(UndoUserInfo.Pop());
                UserInfo userInfo = UndoUserInfo.First();
                ChangeState(userInfo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        private void Redo()
        {
            try
            {
                if (RedoUserInfo.Count == 0)
                    return;

                UndoUserInfo.Push(RedoUserInfo.First());
                UserInfo userInfo = RedoUserInfo.Pop();
                ChangeState(userInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        Stack<UserInfo> UndoUserInfo = new Stack<UserInfo>();
        Stack<UserInfo> RedoUserInfo = new Stack<UserInfo>();
        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TextBox)sender).Modified)
            {
                UserInfo userInfo = new UserInfo();
                InitialState(userInfo);
                UndoUserInfo.Push(userInfo);
            }

        }

        private void textBox_surname_TextChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TextBox)sender).Modified)
            {
                UserInfo userInfo = new UserInfo();
                InitialState(userInfo);
                UndoUserInfo.Push(userInfo);
            }
        }

        private void textBox_phone_number_TextChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TextBox)sender).Modified)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBox_phone_number.Text, "^[0-9]*$"))
                {
                    textBox_phone_number.Text = textBox_phone_number.Text.Remove(textBox_phone_number.Text.Length - 1);
                    textBox_phone_number.SelectionStart = textBox_phone_number.Text.Length;
                }
                UserInfo userInfo = new UserInfo();
                InitialState(userInfo);
                UndoUserInfo.Push(userInfo);
            }
        }

        private void textBox_adress_TextChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TextBox)sender).Modified)
            {
                UserInfo userInfo = new UserInfo();
                InitialState(userInfo);
                UndoUserInfo.Push(userInfo);
            }
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TextBox)sender).Modified)
            {
                UserInfo userInfo = new UserInfo();
                InitialState(userInfo);
                UndoUserInfo.Push(userInfo);
            }
        }
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TextBox)sender).Modified)
            {
                UserInfo userInfo = new UserInfo();
                InitialState(userInfo);
                UndoUserInfo.Push(userInfo);
            }
        }

        private void button_password_Click(object sender, EventArgs e)
        {
            if (button_password.Text == "See")
            {
                textBox_password.UseSystemPasswordChar = false;
                button_password.Text = "Hide";
            }
            else
            {
                textBox_password.UseSystemPasswordChar = true;
                button_password.Text = "See";
            }
        }
    }
}

