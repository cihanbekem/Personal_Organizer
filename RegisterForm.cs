using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Phone_Book
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.KeyPreview = true; // KeyPreview özelliğini doğru şekilde ayarla

            // KeyPress olay işleyicisini atama
            this.KeyPress += new KeyPressEventHandler(Form_Kayıt_KeyPress);
        }

        private void Form_Kayıt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btn_kayit.PerformClick();
            }
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            // Telefon numarasını kontrol et
            if (!phone_control(mtxt_phone.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid phone number.");
                return; // Geçerli bir telefon numarası yoksa kaydı yapma
            }
     

            // Form2'den çıkış yap ve DialogResult.OK'yu ayarla
            DialogResult = DialogResult.OK;
            Close();
        }

        private bool phone_control(string phone)
        {
            if (phone == null) return false;

            // Maskelenmiş numaradan parantezleri ve boşlukları kaldır
            string cleanedPhone = new string(phone.Where(char.IsDigit).ToArray());

            // Eğer temizlenmiş numara 10 karakterden oluşmuyorsa geçersiz kabul edilir
            if (cleanedPhone.Length != 10)
            {
                return false;
            }

            // Eğer temizlenmiş numara sadece rakamlardan oluşmuyorsa geçersiz kabul edilir
            foreach (char c in cleanedPhone)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }

            // Eğer temizlenmiş numaranın ilk hanesi '5' değilse geçersiz kabul edilir
            if (cleanedPhone[0] != '5')
            {
                return false;
            }

            return true;
        }

        private void mtxt_phone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Please enter a valid phone number.");
            mtxt_phone.Clear(); // Geçersiz girişi temizle
            mtxt_phone.Focus(); // Telefon numarası alanına odaklan
        }


        public List<string> GetUserInfo()
        {
            List<string> userInfo = new List<string>(); // Verileri depolamak için dinamik bir liste oluştur

            // Form'deki bilgileri listeye ekle
            userInfo.Add(txt_name.Text.Trim());
            userInfo.Add(txt_surname.Text.Trim());
            userInfo.Add(mtxt_phone.Text.Trim());
            userInfo.Add(txt_address.Text);
            userInfo.Add(txt_dcrpt.Text);
            userInfo.Add(txt_mail.Text.Trim());

            return userInfo;
        }



        // Yapıcı metod
        public RegisterForm(string[] userInfo)
        {
            InitializeComponent();

            // Gelen bilgileri forma yerleştir
            if (userInfo.Length >= 1 && !string.IsNullOrEmpty(userInfo[0]))
                txt_name.Text = userInfo[0];

            if (userInfo.Length >= 2 && !string.IsNullOrEmpty(userInfo[1]))
                txt_surname.Text = userInfo[1];

            if (userInfo.Length >= 3 && !string.IsNullOrEmpty(userInfo[2]))
                mtxt_phone.Text = userInfo[2];

            if (userInfo.Length >= 4 && !string.IsNullOrEmpty(userInfo[3]))
                txt_address.Text = userInfo[3];

            if (userInfo.Length >= 5 && !string.IsNullOrEmpty(userInfo[4]))
                txt_dcrpt.Text = userInfo[4];

            if (userInfo.Length >= 6 && !string.IsNullOrEmpty(userInfo[5]))
                txt_mail.Text = userInfo[5];
        }



        private void txt_mail_Leave(object sender, EventArgs e)
        {
            string email = txt_mail.Text.Trim();

            // Eğer metin içinde "@" sembolü yoksa veya metin boşsa, e-posta alanını temizle
            if (!email.Contains("@") || string.IsNullOrWhiteSpace(email))
            {
                txt_mail.Clear();
                return;
            }

            // Eğer metin içinde "@" sembolü varsa ve metin temizlenmiyorsa, e-posta alanı geçerli kabul edilir
            string pattern = @"@(gmail|outlook|hotmail)\.com$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                txt_mail.Clear();
            }
        }

        private void Form_Kayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
    