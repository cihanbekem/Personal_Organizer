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
        public Phone_Book()
        {
            InitializeComponent();
            this.KeyPreview = true; // KeyPreview özelliğini doğru şekilde ayarla


            // CSV dosyasından verileri yükle
            LoadFromCSV();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni bir Form_Kayıt nesnesi oluştur
            Form_Kayıt kayit = new Form_Kayıt();

            // Form gösterildiğinde ve kullanıcı OK düğmesine bastığında devam et
            if (kayit.ShowDialog() == DialogResult.OK)
            {
                // Form'dan kullanıcı bilgilerini al
                List<string> userInfo = kayit.GetUserInfo();

                // Kullanıcı adı, soyadı ve telefon numarası boş olmamalıdır
                if (string.IsNullOrEmpty(userInfo[0]) || string.IsNullOrEmpty(userInfo[1]) || string.IsNullOrEmpty(userInfo[2]))
                {
                    MessageBox.Show("Lütfen ad, soyad ve telefon numarası alanlarını doldurun.");
                    return;
                }

                // Alınan telefon numarasının daha önce kaydedilip kaydedilmediğini kontrol et
                string phoneNumber = userInfo[2];
                foreach (ListViewItem existingItem in rehber.Items)
                {
                    string existingPhoneNumber = existingItem.SubItems[2].Text;
                    if (existingPhoneNumber == phoneNumber)
                    {
                        MessageBox.Show("Bu telefon numarası zaten mevcut.");
                        return;
                    }
                }

                // Alınan bilgileri ListView'e ekleyin
                ListViewItem item = new ListViewItem(userInfo.ToArray());
                rehber.Items.Add(item);

                // Rehberi CSV'ye kaydet
                SaveToCSV();
            }
        }




        private void btn_update_Click(object sender, EventArgs e)
        {
            if (rehber.Items.Count > 0)
            {
                // Seçilen öğeyi kontrol et
                if (rehber.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Lütfen düzenlemek istediğiniz kişiyi seçin.");
                    return;
                }

                // Seçilen öğenin indeksini al
                int selectedIndex = rehber.SelectedIndices[0];

                // Alt öğe sayısını kontrol et
                int subItemCount = rehber.Items[selectedIndex].SubItems.Count;

                // Düzenleme formunu oluşturun ve seçilen öğenin bilgilerini gönderin
                List<string> userInfo = rehber.Items[selectedIndex].SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subItem => subItem.Text).ToList();
                Form_Kayıt kayit = new Form_Kayıt(userInfo.ToArray());

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
                    SaveToCSV();
                }
            }
            else
            {
                MessageBox.Show("Rehberimiz Boş");
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
                    MessageBox.Show("Lütfen silmek istediğiniz kişiyi seçin.");
                    return;
                }
                int selectedIndex = rehber.SelectedIndices[0];
                rehber.Items.RemoveAt(selectedIndex);

                // Rehberi CSV'ye kaydet
                SaveToCSV();
            }
        }

        private void SaveToCSV()
        {
            StringBuilder sb = new StringBuilder();

            // Başlık satırını oluştur
            sb.AppendLine("İsim,Soyisim,Telefon,Adres,Açıklama,E-posta");

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
            File.WriteAllText("phonebook.csv", sb.ToString(), Encoding.UTF8); // Encoding.UTF8 kullanarak Türkçe karakterleri alın
        }


        private void LoadFromCSV()
        {
            if (File.Exists("phonebook.csv"))
            {
                string[] lines = File.ReadAllLines("phonebook.csv");

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

    }
}