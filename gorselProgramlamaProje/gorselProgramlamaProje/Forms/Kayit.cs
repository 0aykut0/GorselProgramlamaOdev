using gorselProgramlamaProje.Managers;
using gorselProgramlamaProje.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
            // Form başlığı
            this.Text = "Kayıt";

            CenterKayitPanel();
            this.Resize += (s, e) => CenterKayitPanel();
        }

        private void CenterKayitPanel()
        {
            // Form içindeki "KayitPanel" adlı paneli tam ortalar
            int x = (this.ClientSize.Width - KayitPanel.Width) / 2;
            int y = (this.ClientSize.Height - KayitPanel.Height) / 2;
            KayitPanel.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAd.Text.Trim();
            string sifre = txtParola.Text.Trim();
            string sifreTekrar = txtParola2.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) ||
                string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (KullaniciManager.KullaniciAdiVarMi(kullaniciAdi))
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var yeniKullanici = new Kullanici
            {
                KullaniciAdi = kullaniciAdi,
                SifreHash = sifre // hashleme KullaniciManager içinde yapılacak
            };

            KullaniciManager.KullaniciEkle(yeniKullanici);

            MessageBox.Show("Kayıt başarılı! Giriş ekranına yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            // İptal edildiğinde formu kapatır ve login ekranına döner
            this.Close();
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {
            // İhtiyaç durumunda buraya kod ekleyin
        }
    }
}
