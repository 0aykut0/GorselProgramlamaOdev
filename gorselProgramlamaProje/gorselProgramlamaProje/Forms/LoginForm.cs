using gorselProgramlamaProje.Managers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CenterLoginPanel();
            this.Resize += (s, e) => CenterLoginPanel();
        }

        private void CenterLoginPanel()
        {
            int x = (this.ClientSize.Width - LoginPanel.Width) / 2;
            int y = (this.ClientSize.Height - LoginPanel.Height) / 2;
            LoginPanel.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtParola.Text.Trim();

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!KullaniciManager.HicKullaniciVarMi())
            {
                MessageBox.Show("Sistemde kayıtlı kullanıcı bulunmamaktadır. Lütfen önce kayıt olun.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var kullanici = KullaniciManager.KullaniciGirisYap(kullaniciAdi, sifre);
            if (kullanici != null)
            {
                SessionManager.CurrentUserId = kullanici.Id;
                SessionManager.CurrentUsername = kullanici.KullaniciAdi;

                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                var anaForm = new AnaSayfaForm();
                anaForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            this.Hide();

            using (var kayitForm = new Kayit())
            {
                kayitForm.ShowDialog(this);
            }

            this.Close();
        }
    }
}
