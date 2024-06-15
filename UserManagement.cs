using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Personal_Organizer
{
    public partial class UserManagement : Form
    {
        private CsvHelper csvHelper;
        private List<UserInfo> users;
        private ContextMenuStrip contextMenuStrip;

        UserInfo _user;
        public UserManagement(UserInfo user)
        {
            InitializeComponent();
            csvHelper = new CsvHelper();
            LoadUsers();
            InitializeListViewContextMenu();
            this.Load += new System.EventHandler(this.Form4_Load);
            this._user = user;
        }

        private void LoadUsers()
        {
            users = csvHelper.GetAllUsers();
            listViewUsers.Items.Clear();

            foreach (var user in users)
            {
                var listItem = new ListViewItem(user.Id);
                listItem.SubItems.Add(user.Name);
                listItem.SubItems.Add(user.Surname);
                listItem.SubItems.Add(user.Authority);
                listItem.SubItems.Add(user.Salary.ToString());

                listItem.Tag = user;
                listViewUsers.Items.Add(listItem);
            }
        }

        private void InitializeListViewContextMenu()
        {
            // ContextMenuStrip oluşturun
            contextMenuStrip = new ContextMenuStrip();


            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Delete");

            // Menü öğelerine olay yöneticileri ekleyin
            deleteItem.Click += new EventHandler(DeleteItem_Click);

            // Menü öğelerini ContextMenuStrip'e ekleyin
            contextMenuStrip.Items.Add(deleteItem);

            // ListView'e ContextMenuStrip'i ekleyin
            listViewUsers.ContextMenuStrip = contextMenuStrip;
        }


        private void Form4_Load(object sender, EventArgs e)
        {
            listViewUsers.Columns.Clear();
            listViewUsers.Columns.Add("User ID", 100);
            listViewUsers.Columns.Add("Name", 150);
            listViewUsers.Columns.Add("Surname", 150);
            listViewUsers.Columns.Add("User Type", 100);
            listViewUsers.Columns.Add("Salary", 150);

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                var selectedUser = (UserInfo)listViewUsers.SelectedItems[0].Tag;

                // Eğer seçili kullanıcı admin ise ve listede sadece bir admin varsa
                if (selectedUser.Authority == "admin" || CountAdmins() == 1)
                {
                    MessageBox.Show("This user's permission cannot be changed. There must be at least 1 admin!");
                }
                else
                {
                    selectedUser.Authority = comboAuthority.SelectedItem.ToString();
                    csvHelper.UpdateUser(selectedUser);
                    LoadUsers();
                    MessageBox.Show("User information updated.");
                }
            }
        }
        // Admin sayısını sayan yardımcı bir fonksiyon
        private int CountAdmins()
        {
            int adminCount = 0;
            foreach (ListViewItem item in listViewUsers.Items)
            {
                UserInfo user = (UserInfo)item.Tag;
                if (user.Authority == "admin")
                {
                    adminCount++;
                }
            }
            return adminCount;
        }


        private void DeleteItem_Click(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {

                var selectedUser = (UserInfo)listViewUsers.SelectedItems[0].Tag;
                if (selectedUser.Authority != "admin")
                {
                    listViewUsers.Items.Remove(listViewUsers.SelectedItems[0]);
                    csvHelper.DeleteUser(selectedUser.Id); // Kullanıcıyı CSV dosyasından silin
                    MessageBox.Show("Deleted item: " + selectedUser.Name);
                }
                else
                {
                    MessageBox.Show("Admin cannot be deleted!");
                }
            }
        }

        private void comboAuthority_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewUsers.SelectedItems.Count > 0)
            {
                var selectedUser = (UserInfo)listViewUsers.SelectedItems[0].Tag;
                if (selectedUser.Authority != "admin" || CountAdmins() > 1) 
                {

                    // If the selected authority is "part-time user" and the user is not already a part-time user
                    if (comboAuthority.SelectedItem.ToString() == "part-time user" && selectedUser.Authority != "part-time user")
                    {
                        selectedUser.Salary = selectedUser.Salary / 2;
                        csvHelper.UpdateUser(selectedUser);
                    }

                    // Update the authority of the selected user
                    selectedUser.Authority = comboAuthority.SelectedItem.ToString();

                    // Save the changes to the CSV
                    csvHelper.UpdateUser(selectedUser);

                    // Reload the user list to reflect changes
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("Admin cannot Be Changed!");
                }
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
            pictureBox1.BackColor = Color.OldLace; // Default background color
        }
    }
}
