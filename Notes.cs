using Personal_Organizer;
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

namespace Notes
{
    public partial class Notes : Form
    {
        private string notesFilePath;
        private string receivedValue;
        UserInfo _user;
        public Notes(string value,UserInfo user)
        {
            InitializeComponent();
            this.receivedValue = value;
            this.notesFilePath = value + "_notes.csv";
            _user = user;
            LoadNotes();
        }

        private void LoadNotes()
        {
            listBoxNotes.Items.Clear();

            if (File.Exists(notesFilePath))
            {
                using (StreamReader sr = new StreamReader(notesFilePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        listBoxNotes.Items.Add(line);
                    }
                }
            }
        }

        private void SaveListBoxToCsv(string filePath)
        {
            StringBuilder csvContent = new StringBuilder();

            foreach (var item in listBoxNotes.Items)
            {
                csvContent.AppendLine(item.ToString());
            }

            File.WriteAllText(filePath, csvContent.ToString(), Encoding.UTF8);
        }



        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNote.Text))
            {
                listBoxNotes.Items.Add(textBoxNote.Text);
                textBoxNote.Clear();
                SaveListBoxToCsv(notesFilePath);
            }
            else
            {
                MessageBox.Show("Blank notes cannot be added");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex != -1) // Ensure an item is selected
            {
                if (!string.IsNullOrEmpty(textBoxNote.Text)) // Ensure the input text is not empty
                {
                    int selectedIndex = listBoxNotes.SelectedIndex;
                    listBoxNotes.Items[selectedIndex] = textBoxNote.Text; // Update the selected item
                    textBoxNote.Clear();
                    SaveListBoxToCsv(notesFilePath);
                    LoadNotes(); // Reload the notes to reflect changes immediately
                    listBoxNotes.SelectedIndex = selectedIndex; // Reselect the updated item
                }
                else
                {
                    MessageBox.Show("Please enter a valid note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a note to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItems.Count > 0)
            {
                var selectedItems = listBoxNotes.SelectedItems.OfType<object>().ToList();
                foreach (var item in selectedItems)
                {
                    listBoxNotes.Items.Remove(item);
                }
                SaveListBoxToCsv(notesFilePath);

                MessageBox.Show("Selected note(s) deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select one or more notes to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void buttonList_Click(object sender, EventArgs e)
        {
            LoadNotes();

            // Listbox içeriğini alfabetik olarak sırala
            List<string> sortedNotes = listBoxNotes.Items.Cast<string>().OrderBy(note => note).ToList();
            listBoxNotes.Items.Clear();
            foreach (string note in sortedNotes)
            {
                listBoxNotes.Items.Add(note);
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
            pictureBox1.BackColor = Color.Pink; // Default background color
        }

        private void btn_changes_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedItems.Count > 1)
            {
                // Seçili öğelerin dizinlerini al
                List<int> selectedIndices = listBoxNotes.SelectedIndices.Cast<int>().ToList();

                // Seçili öğelerin pozisyonunu değiştir
                for (int i = 0; i < selectedIndices.Count - 1; i++)
                {
                    // İki öğenin yerini değiştir
                    object temp = listBoxNotes.Items[selectedIndices[i]];
                    listBoxNotes.Items[selectedIndices[i]] = listBoxNotes.Items[selectedIndices[i + 1]];
                    listBoxNotes.Items[selectedIndices[i + 1]] = temp;
                }

                // Yer değiştirme işlemi bittikten sonra seçili öğeleri yeniden seç
                listBoxNotes.ClearSelected();
                foreach (int index in selectedIndices)
                {
                    listBoxNotes.SetSelected(index, true);
                }

                // Değişiklikleri kaydet
                SaveListBoxToCsv(notesFilePath);
                listBoxNotes.ClearSelected();
            }
            else
            {
                MessageBox.Show("Please select at least two items to change.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
