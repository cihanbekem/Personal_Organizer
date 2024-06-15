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
    public partial class Form1 : Form
    {
        private string notesFilePath = "notes.csv";

        public Form1()
        {
            InitializeComponent();
        }

     
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxNote.Text))
            {
                using (StreamWriter sw = File.AppendText(notesFilePath))
                {
                    sw.WriteLine(textBoxNote.Text);
                }
                textBoxNote.Clear();
                LoadNotes();
            }
            else
            {
                MessageBox.Show("Please enter a note.");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex != -1)
            {
                string[] notes = File.ReadAllLines(notesFilePath);
                notes[listBoxNotes.SelectedIndex] = textBoxNote.Text;
                File.WriteAllLines(notesFilePath, notes);
                textBoxNote.Clear();
                LoadNotes();
            }
            else
            {
                MessageBox.Show("Please select a note to update.");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxNotes.SelectedIndex != -1)
            {
                List<string> notes = new List<string>(File.ReadAllLines(notesFilePath));
                notes.RemoveAt(listBoxNotes.SelectedIndex);
                File.WriteAllLines(notesFilePath, notes.ToArray());
                textBoxNote.Clear();
                LoadNotes();
                MessageBox.Show("Note deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void LoadNotes()
        {
            listBoxNotes.Items.Clear();
            if (File.Exists(notesFilePath))
            {
                string[] notes = File.ReadAllLines(notesFilePath);
                foreach (string note in notes)
                {
                    listBoxNotes.Items.Add(note);
                }
            }
        }


    }
}
