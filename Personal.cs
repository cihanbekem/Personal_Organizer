using Personal_Organizer;
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

        string imagePath;
        UserInfo userInfo;

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

        public Personal(UserInfo mainUser)
        {
            InitializeComponent();
            userInfo = mainUser;
            this.KeyDown += new KeyEventHandler(Form1_KeyUndo);
            this.KeyDown += new KeyEventHandler(Form1_KeyRedo);
            label_authority.Text = userInfo.Authority.ToUpper();
            imagePath = Directory.GetCurrentDirectory() + @"\images" + userInfo.Id + ".csv";

            ChangeState(userInfo);
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

        private void SaveUser()
        {
            string filePath = Directory.GetCurrentDirectory() + @"\User_Infos.txt";
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                if (line[0] == userInfo.Id)
                {
                    line[1] = textBox_name.Text;
                    line[2] = textBox_surname.Text;
                    line[3] = maskedTextBox1.Text ;
                    line[4] = textBox_adress.Text;
                    line[5] = textBox_email.Text;
                    line[6] = textBox_password.Text;
                }
                lines[i] = string.Join(",", line);
            }
            File.WriteAllLines(filePath, lines);
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

        private void button_save_Click(object sender, EventArgs e)
        {
            InitialState(userInfo);
            SaveUser();

            if (pictureBox_profile.Image != null)
            {
                string base64String = ImageToBase64(pictureBox_profile.Image, System.Drawing.Imaging.ImageFormat.Png);

                using (StreamWriter sw = new StreamWriter(imagePath, true))
                {
                    sw.WriteLine(base64String);
                }
            }
            else
            {
                Console.WriteLine("No image to save.");
            }

            MessageBox.Show("Changes Saved.");
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
            userInfo.PhoneNumber = maskedTextBox1.Text;
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
            maskedTextBox1.Text = userInfo.PhoneNumber;
            maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
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


        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
                if (((System.Windows.Forms.MaskedTextBox)sender).Modified)
                {
                    if (!System.Text.RegularExpressions.Regex.IsMatch(maskedTextBox1.Text, "^[0-9]*$"))
                    {
                        maskedTextBox1.Text = maskedTextBox1.Text.Remove(maskedTextBox1.Text.Length - 1);
                        maskedTextBox1.SelectionStart = maskedTextBox1.Text.Length;
                    }
                }
                UserInfo userInfo = new UserInfo();
                InitialState(userInfo);
                UndoUserInfo.Push(userInfo);
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                this.Close();
                MainForm mnf = new MainForm(userInfo);
                mnf.Show();
            
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.DarkGray;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Khaki; // Default background color
        }
    }
   
}


