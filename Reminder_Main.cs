using Personal_Organizer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Reminder
{
    public partial class Reminder_Main : Form
    {
        private List<Reminder> reminders = new List<Reminder>();
        private IReminderFactory factory;
        UserInfo _user;
        private Timer shakeTimer;
        private int shakeCount;
        private Point originalLocation;
        private Timer wantedTimer;
        private string filePath;



        public Reminder_Main(UserInfo user)
        {
            InitializeComponent();
            filePath = Directory.GetCurrentDirectory() + @"\Reminder" + user.Id + ".txt";
            comboBoxReminderType.Items.Add("Meeting");
            comboBoxReminderType.Items.Add("Task");
            comboBoxReminderType.SelectedIndex = 0;
            this._user = user;

            shakeTimer = new Timer();
            shakeTimer.Interval = 100;
            shakeTimer.Tick += ShakeTimer_Tick;

            wantedTimer = new Timer();
            wantedTimer.Interval = 1000;
            wantedTimer.Tick += WantedTimer_Tick;

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] linePart = line.Split(',');
                    if (linePart[0] == "Meeting")
                    {
                        Meeting meeting = new Meeting
                        {
                            Id = int.Parse(linePart[1]),
                            Title = linePart[2],
                            Date = DateTime.Parse(linePart[3]),
                            Hour = DateTime.Parse(linePart[4]),
                            Summary = linePart[5],
                            Location = linePart[6]
                        };
                        reminders.Add(meeting);
                    }
                    else
                    {
                        Task task = new Task
                        {
                            Id = int.Parse(linePart[1]),
                            Title = linePart[2],
                            Date = DateTime.Parse(linePart[3]),
                            Hour = DateTime.Parse(linePart[4]),
                            Summary = linePart[5],
                            Description = linePart[6]
                        };
                        reminders.Add(task);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            UpdateReminderList();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CreateFactory();
            var reminder = factory.CreateReminder();
            reminder.Title = textBoxTitle.Text;
            reminder.Date = dateTimePickerDate.Value;
            reminder.Hour = dateTimePickerHour.Value;
            reminder.Summary = textBoxSummary.Text;
            reminder.Id = reminders.Count; // Setting ID to be the next index

            if (reminder is Meeting meeting)
            {
                meeting.Location = textBoxLocation.Text;
                textBoxLocation.Text = null;
            }
            else if (reminder is Task task)
            {
                task.Description = textBoxDescription.Text;
                textBoxDescription.Text = null;
            }

            reminders.Add(reminder);
            UpdateReminderList();

            textBoxTitle.Text = null;
            textBoxSummary.Text = null;

            // Start the wanted timer
            wantedTimer.Start();
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int index = listBoxReminders.SelectedIndex;

            if (index >= 0 && index < reminders.Count)
            {
                if (string.IsNullOrWhiteSpace(textBoxTitle.Text))
                {
                    MessageBox.Show("Title is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var reminder = reminders[index];
                reminder.Title = textBoxTitle.Text;
                reminder.Date = dateTimePickerDate.Value;
                reminder.Hour = dateTimePickerHour.Value;
                reminder.Summary = textBoxSummary.Text;

                if (reminder is Meeting meeting)
                {
                    meeting.Location = textBoxLocation.Text.Trim();
                }
                else if (reminder is Task task)
                {
                    task.Description = textBoxDescription.Text;
                }

                reminders[index] = reminder;
                UpdateReminderList();

                textBoxTitle.Text = null;
                textBoxSummary.Text = null;
            }
            else
            {
                MessageBox.Show("Please select a valid reminder.");
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxReminders.SelectedIndex;

            if (index >= 0 && index < reminders.Count)
            {
                reminders.RemoveAt(index);
                // Update IDs of remaining reminders
                for (int i = 0; i < reminders.Count; i++)
                {
                    reminders[i].Id = i;
                }
                UpdateReminderList();
            }
            else
            {
                MessageBox.Show("Please select a valid reminder to delete.");
            }
        }


        private void listBoxReminders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxReminders.SelectedItem is Reminder selectedReminder)
            {
                textBoxTitle.Text = selectedReminder.Title;
                dateTimePickerDate.Value = selectedReminder.Date;

                if (selectedReminder is Meeting meeting)
                {
                    textBoxLocation.Text = meeting.Location;
                    textBoxDescription.Text = string.Empty;
                }
                else if (selectedReminder is Task task)
                {
                    textBoxDescription.Text = task.Description;
                    textBoxLocation.Text = string.Empty;
                }
            }
        }

        private void CreateFactory()
        {
            if (comboBoxReminderType.SelectedItem.ToString() == "Meeting")
            {
                factory = new MeetingFactory();
            }
            else if (comboBoxReminderType.SelectedItem.ToString() == "Task")
            {
                factory = new TaskFactory();
            }
        }

        private void UpdateReminderList()
        {
            listBoxReminders.Items.Clear();
            using (var sw = new StreamWriter(filePath))
            {
                foreach (var reminder in reminders)
                {
                    listBoxReminders.Items.Add(reminder.GetDetails());

                    string line;
                    if (reminder is Meeting meeting)
                    {
                        line = $"Meeting,{meeting.Id},{meeting.Title},{meeting.Date},{meeting.Hour},{meeting.Summary},{meeting.Location}";
                    }
                    else if (reminder is Task task)
                    {
                        line = $"Task,{task.Id},{task.Title},{task.Date},{task.Hour},{task.Summary},{task.Description}";
                    }
                    else
                    {
                        continue;
                    }
                    sw.WriteLine(line);
                }
            }
        }


        private void comboBoxReminderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReminderType.SelectedItem.ToString() == "Meeting")
            {
                textBoxDescription.Visible = false;
                textBoxLocation.Visible = true;
            }
            else if (comboBoxReminderType.SelectedItem.ToString() == "Task")
            {
                textBoxLocation.Visible = false;
                textBoxDescription.Visible = true;
            }
        }

        private void ShakeForm()
        {
            originalLocation = this.Location;
            shakeCount = 0;
            shakeTimer.Start();
        }

        private void ShakeTimer_Tick(object sender, EventArgs e)
        {
            const int shakeAmplitude = 10;

            if (shakeCount < 10)
            {
                if (shakeCount % 2 == 0)
                {
                    this.Location = new Point(originalLocation.X + shakeAmplitude, originalLocation.Y);
                }
                else
                {
                    this.Location = new Point(originalLocation.X - shakeAmplitude, originalLocation.Y);
                }
                shakeCount++;
            }
            else
            {
                shakeTimer.Stop();
                this.Location = originalLocation;
            }
        }

        private void WantedTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            foreach (var reminder in reminders)
            {
                DateTime reminderTime = reminder.Date.Date.Add(reminder.Hour.TimeOfDay);
                if (now >= reminderTime && now < reminderTime.AddSeconds(1))
                {
                    ShakeForm();
                    MessageBox.Show($"Reminder: {reminder.Title}");
                    reminders.Remove(reminder); // Remove the reminder to prevent repeated shaking
                    UpdateReminderList();
                    break;
                }
            }
        }

        private void listBoxReminders_Click(object sender, EventArgs e)
        {
            // Seçili öğenin geçerli olup olmadığını kontrol edin
            if (listBoxReminders.SelectedIndex >= 0 && listBoxReminders.SelectedIndex < reminders.Count)
            {
                MessageBox.Show(reminders[listBoxReminders.SelectedIndex].Title);
            }
            else
            {
                MessageBox.Show("Invalid selection.");
            }
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
            pictureBox1.BackColor = Color.Gainsboro; // Default background color
        }

    }
}