using Notes;
using Phone_Book;
using Reminder;
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

namespace Personal_Organizer
{
    public partial class MainForm : Form
    {
        private UserInfo currentUser;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Timer timerDateTime;
        private string imagePath;


        public MainForm(UserInfo user)
        {
            InitializeComponent();
            AddMouseEnterLeaveEvents();
            InitializeDateTime();
            currentUser = user;
            lblkullanıcı.Text = user.Name + " " + user.Surname;
            lbl_user_type.Text = currentUser.Authority;

            // Display the salary
            if (currentUser.Authority == "part-time user")
            {
                currentUser.Salary *= 2; // Avoid halving the salary every time the form opens
            }

            UpdateSalaryLabel(currentUser.Salary);

            if (currentUser.Authority != "admin")
            {
                btnUserManagement.Visible = false;
                lblUserManagement.Visible = false;
                panel6.Visible = false;

                btnUserManagement.Enabled = false;
                btnUserManagementtoolTip1.SetToolTip(btnUserManagement, "You are not authorized to access this process.");
            }

            // Construct the image path
            imagePath = Directory.GetCurrentDirectory() + @"\images" + user.Id + ".csv";
            try
            {
                string[] lines = File.ReadAllLines(imagePath);
                foreach (string line in lines)
                {
                    byte[] imageBytes = Convert.FromBase64String(line);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        Image image = Image.FromStream(ms);
                        pictureBox1.Image = image;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "sözler.txt"); // Assuming "sözler.txt" is in the same directory as the source code
            try
            {
                string[] allLines = File.ReadAllLines(filePath);
                if (allLines.Length > 0)
                {
                    if(this.BackColor == Color.MidnightBlue)
                    {
                        textBox1.BackColor = Color.MidnightBlue;
                        textBox1.ForeColor = Color.White;
                    }
                    else
                    {
                        textBox1.BackColor= Color.MediumTurquoise;
                        textBox1.ForeColor= Color.Black;
                    }
                    Random random = new Random();
                    int randomIndex = random.Next(allLines.Length);
                    textBox1.Text = allLines[randomIndex];
                }
                else
                {
                    // Handle the case where the file is empty or inaccessible
                    textBox1.Text = "No quotes found in 'sözler.txt'.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading 'sözler.txt': " + ex.Message);
                textBox1.Text = "Error reading quotes file.";
            }
        }

    
        private void InitializeDateTime()
        {
            // Initialize and start the timer
            timerDateTime = new System.Windows.Forms.Timer();
            timerDateTime.Interval = 1000; // 1 second
            timerDateTime.Tick += new EventHandler(timerDateTime_Tick);
            timerDateTime.Start();


            // Set the initial date and time
            UpdateDateTime();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            UpdateDateTime();
        }

        private void UpdateDateTime()
        {
            lbl_saat.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // Adjust the format as needed
        }

        private void btnUserManagement_Click_1(object sender, EventArgs e)
        {
            if (currentUser.Authority == "admin")
            {
                this.Hide();
                UserManagement form4 = new UserManagement(currentUser);
                form4.Show();
            }
            else
            {
                MessageBox.Show("You must have admin authority to perform this operation.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CsvHelper csvHelper = new CsvHelper();
                var users = csvHelper.GetAllUsers();
                var userToDelete = users.FirstOrDefault(u => u.Id == currentUser.Id);
                if (userToDelete != null)
                {
                    users.Remove(userToDelete);

                    if (userToDelete.Authority == "admin")
                    {
                        var nextAdmin = users.OrderBy(u => int.Parse(u.Id)).FirstOrDefault();
                        if (nextAdmin != null)
                        {
                            nextAdmin.Authority = "admin";
                        }
                    }

                    csvHelper.UpdateUsers(users);
                    MessageBox.Show("Your account has been deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Login loginForm = new Login();
                    loginForm.Show();
                }
            }
        }

        private void phone_book_Click(object sender, EventArgs e)
        {
            this.Hide();
            Phone_Book.Phone_Book rehber = new Phone_Book.Phone_Book(currentUser.Id.ToString(),currentUser);
            rehber.Show();
        }

        private void btn_notes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Notes.Notes notes = new Notes.Notes(currentUser.Id.ToString(),currentUser);
            notes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Salary_Calculator.Salary_Calculator salaryCalculator = new Salary_Calculator.Salary_Calculator(currentUser);
            salaryCalculator.SalaryCalculated += UpdateSalaryLabel;
            salaryCalculator.Show();
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Personal_Information.Personal personal = new Personal_Information.Personal(currentUser);
            personal.Show();
        }

        private void btn_Reminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reminder_Main reminder_Main = new Reminder_Main(currentUser);
            reminder_Main.Show();
        }

        private void AddMouseEnterLeaveEvents()
        {
            // Tüm butonlara MouseEnter ve MouseLeave olaylarını ekleyin
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.MouseEnter += new EventHandler(Button_MouseEnter);
                    control.MouseLeave += new EventHandler(Button_MouseLeave);
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // Buton üzerine gelindiğinde rengi değiştirin veya boyutunu artırın
                button.BackColor = Color.LightGray;
                button.Size = new Size(button.Width + 10, button.Height + 10);
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                // RadioButton nesnesini bulun ve kontrol edin
                RadioButton radioButton = this.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Name == "radioButtonLight");

                if (radioButton != null && radioButton.Checked)
                {
                    // Eğer RadioButton seçili ise arka plan rengini MidnightBlue yapın
                    button.BackColor = Color.MediumTurquoise;
                }
                else
                {
                    // Aksi halde, Butondan ayrıldığında rengi ve boyutunu eski haline getirin
                    button.BackColor = Color.MidnightBlue;
                    
                }

                // Boyutunu eski haline getirin
                button.Size = new Size(button.Width - 10, button.Height - 10);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {               
                this.Hide();
                Login lgn = new Login();
                lgn.Show();
            }
        }


        private void SaveUserInfo(UserInfo user)
        {
            CsvHelper csvHelper = new CsvHelper();
            csvHelper.UpdateUser(user);
        }
        private void UpdateSalaryLabel(double newSalary)
        {
            if (currentUser.Authority == "part-time user")
            {
                newSalary /= 2;
            }

            currentUser.Salary = newSalary;
            lbl_maas.Text = newSalary.ToString("C2");

            SaveUserInfo(currentUser);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit the program?", "Exit the Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Kapanma işlemini iptal et
                }
                else
                {
                    this.Hide();
                    ExitScreen cks = new ExitScreen();
                    cks.ShowDialog();
                }
            }
        }

        private void radioButtonDark_CheckedChanged(object sender, EventArgs e)
        { 
            // main formda basıldığında midnihgt blue yapsın dark tema olsun
            MainForm.ActiveForm.BackColor = Color.MidnightBlue;
            MainForm.ActiveForm.ForeColor = Color.White;


            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.MidnightBlue;
                    control.ForeColor = Color.White;
                    panel1.BackColor = Color.Salmon;
                    panel2.BackColor = Color.MediumOrchid;
                    panel3.BackColor = Color.Gold;
                    panel4.BackColor = Color.Chartreuse;
                    panel5.BackColor = Color.HotPink;
                    panel6.BackColor = Color.OldLace;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    lblUserManagement.ForeColor = Color.Black;
                    label4.ForeColor = Color.Black;
                    label5.ForeColor = Color.Black;
                    label6.ForeColor = Color.Black;
                    label7.ForeColor = Color.White;
                    label8.ForeColor = Color.White;
                    label9.ForeColor = Color.White;
                    label10.ForeColor = Color.White;
                    label11.ForeColor = Color.White;
                    lbl_maas.ForeColor = Color.White;
                    lbl_saat.ForeColor = Color.White;
                    lblkullanıcı.ForeColor = Color.White;
                    lbl_user_type.ForeColor = Color.White;
                    radioButtonLight.ForeColor = Color.White;
                    radioButtonDark.ForeColor = Color.White;
                    textBox1.BackColor = Color.MidnightBlue;
                    textBox1.ForeColor = Color.White;

                }
            }

        }

        private void radioButtonLight_CheckedChanged(object sender, EventArgs e)
        {
            // dark'tan light'a geçince tekrar ilk rengine dönsün
            MainForm.ActiveForm.BackColor = Color.MediumTurquoise;
            MainForm.ActiveForm.ForeColor = Color.Black;

            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = Color.MediumTurquoise;
                    control.ForeColor = Color.Black;
                    panel1.BackColor = Color.Salmon;
                    panel2.BackColor = Color.MediumOrchid;
                    panel3.BackColor = Color.Gold;
                    panel4.BackColor = Color.Chartreuse;
                    panel5.BackColor = Color.HotPink;
                    panel6.BackColor = Color.OldLace;
                    label7.ForeColor = Color.Black;
                    label8.ForeColor = Color.Black;
                    label9.ForeColor = Color.Black;
                    label10.ForeColor = Color.Black;
                    label11.ForeColor = Color.Black;
                    lbl_maas.ForeColor = Color.Black;
                    lbl_saat.ForeColor = Color.Black;
                    lblkullanıcı.ForeColor = Color.Black;
                    lbl_user_type.ForeColor = Color.Black;
                    textBox1.BackColor = Color.MediumTurquoise;
                    textBox1.ForeColor = Color.Black;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1(currentUser);
            frm.ShowDialog();
        }
    }
}
