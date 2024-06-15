using Personal_Organizer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phone_Book
{

    public partial class Phone_Book : Form
    {
        private string receivedValue;
        UserInfo _user;
        private string _color;
        public Phone_Book(string value, UserInfo user)
        {
            InitializeComponent();
            this.KeyPreview = true; // KeyPreview özelliğini doğru şekilde ayarla
            this.receivedValue = value;
            this._user = user;

            // CSV dosyasından verileri yükle
            LoadFromCSV(receivedValue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni bir Form_Kayıt nesnesi oluştur
            RegisterForm kayit = new RegisterForm();

            // Form gösterildiğinde ve kullanıcı OK düğmesine bastığında devam et
            if (kayit.ShowDialog() == DialogResult.OK)
            {
                // Form'dan kullanıcı bilgilerini al
                List<string> userInfo = kayit.GetUserInfo();

                // Kullanıcı adı, soyadı ve telefon numarası boş olmamalıdır
                if (string.IsNullOrEmpty(userInfo[0]) || string.IsNullOrEmpty(userInfo[1]) || string.IsNullOrEmpty(userInfo[2]))
                {
                    MessageBox.Show("Please fill in the first name, surname and phone number fields.");
                    return;
                }

                // Alınan telefon numarasının daha önce kaydedilip kaydedilmediğini kontrol et
                string phoneNumber = userInfo[2];
                foreach (ListViewItem existingItem in rehber.Items)
                {
                    string existingPhoneNumber = existingItem.SubItems[2].Text;
                    if (existingPhoneNumber == phoneNumber)
                    {
                        MessageBox.Show("This phone number already exists.");
                        return;
                    }
                }

                // Alınan bilgileri ListView'e ekleyin
                ListViewItem item = new ListViewItem(userInfo.ToArray());
                rehber.Items.Add(item);

                // Rehberi CSV'ye kaydet
                SaveToCSV(receivedValue);
            }
        }




        private void btn_update_Click(object sender, EventArgs e)
        {
            if (rehber.Items.Count > 0)
            {
                // Seçilen öğeyi kontrol et
                if (rehber.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select the person you want to edit.");
                    return;
                }

                // Seçilen öğenin indeksini al
                int selectedIndex = rehber.SelectedIndices[0];

                // Alt öğe sayısını kontrol et
                int subItemCount = rehber.Items[selectedIndex].SubItems.Count;

                // Düzenleme formunu oluşturun ve seçilen öğenin bilgilerini gönderin
                List<string> userInfo = rehber.Items[selectedIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text).ToList();
                RegisterForm kayit = new RegisterForm(userInfo.ToArray());

                if (kayit.ShowDialog() == DialogResult.OK)
                {
                    // Form2'den gelen bilgileri al
                    List<string> updatedUserInfo = kayit.GetUserInfo();

                    // Alınan bilgileri seçilen öğeye ekle
                    for (int i = 0; i < updatedUserInfo.Count && i < subItemCount; i++)
                    {
                        rehber.Items[selectedIndex].SubItems[i].Text = updatedUserInfo[i];
                    }

                    // Rehberi CSV'ye kaydet
                    SaveToCSV(receivedValue);
                }
            }
            else
            {
                MessageBox.Show("Your Phone Book is empty.");
                return;
            }
        }


        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (rehber.Items.Count > 0)
            {
                // Seçilen öğeyi kontrol et
                if (rehber.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select the contact you want to delete.");
                    return;
                }
                int selectedIndex = rehber.SelectedIndices[0];
                rehber.Items.RemoveAt(selectedIndex);

                // Rehberi CSV'ye kaydet
                SaveToCSV(receivedValue);
            }
        }

        private void SaveToCSV(string value)
        {
            StringBuilder sb = new StringBuilder();

            // Başlık satırını oluştur
            sb.AppendLine("Name, Surname, Phone, Address, Description, E-mail");

            // Her bir kişi için verileri ekleyin
            foreach (ListViewItem item in rehber.Items)
            {
                // Her bir öğenin alt öğelerini dolaşarak ekleyin
                StringBuilder line = new StringBuilder();
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    // Alt öğeyi ekleyin ve virgülle ayırın
                    line.Append(subItem.Text.Replace(",", "") + ","); // Türkçe karakterleri de almak için Replace fonksiyonunu kullanın
                }
                // Son virgülden sonra gelen boşluğu kaldırın ve satır sonuna bir satır ekleyin
                line.Length--; // Son virgülü kaldırın
                sb.AppendLine(line.ToString());
            }

            // CSV dosyasına yaz
            File.WriteAllText(value+"_phonebook.csv", sb.ToString(), Encoding.UTF8); // Encoding.UTF8 kullanarak Türkçe karakterleri alın
        }


        private void LoadFromCSV(string value)
        {
            if (File.Exists(value+"_phonebook.csv"))
            {
                string[] lines = File.ReadAllLines(value + "_phonebook.csv");

                // Başlık satırını atla ve her bir satırı işle
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = new string[6]; // Altı elemanı depolamak için yeterli alanı sağlar

                    // Satırı virgülle ayırarak parçalara böler
                    parts = lines[i].Split(',');

                    // Eksik parçaları kontrol eder ve gerekirse boş dize olarak atar
                    for (int j = 0; j < parts.Length; j++)
                    {
                        if (parts[j] == "")
                        {
                            parts[j] = "";
                        }
                    }

                    // ListView'e eklemek için bir öğe oluşturur ve ekler
                    ListViewItem item = new ListViewItem(parts);
                    rehber.Items.Add(item);
                }
            }
        }

        private void rehber_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            rehber.ListViewItemSorter = new ListViewItemComparer(e.Column, rehber.Sorting);

            // Sıralama yönünü belirle (varsayılan olarak artan sıralama)
            if (rehber.Sorting == SortOrder.Ascending)
            {
                rehber.Sorting = SortOrder.Descending;
            }
            else
            {
                rehber.Sorting = SortOrder.Ascending;
            }

            // ListView'i yeniden sırala
            rehber.Sort();
        }

        public class ListViewItemComparer : IComparer
        {
            private int col;
            private SortOrder order;

            public ListViewItemComparer(int column, SortOrder order)
            {
                col = column;
                this.order = order;
            }

            public int Compare(object x, object y)
            {
                int result;
                if (col == 0 || col == 1) // İsim veya soyisim sütunu için sıralama
                {
                    result = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                }
                else // Diğer sütunlar için varsayılan sıralama yapılacak
                {
                    result = String.Compare(((ListViewItem)x).Text, ((ListViewItem)y).Text);
                }

                if (order == SortOrder.Descending) // Sıralama yönüne göre sonucu ters çevir
                {
                    result = -result;
                }

                return result;
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
            pictureBox1.BackColor = Color.LightGreen; // Default background color
        }
    }
}