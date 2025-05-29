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
            // loginPanel adındaki paneli form ortasına yerleştirir
            int x = (this.ClientSize.Width - LoginPanel.Width) / 2;
            int y = (this.ClientSize.Height - LoginPanel.Height) / 2;
            LoginPanel.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // TODO: Giriş doğrulama mantığını buraya ekleyin
        }

        private void lblKullaniciAdi_Click(object sender, EventArgs e)
        {
            // Label tıklama olayı gerekli değilse silebilirsiniz
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            // LoginForm'u gizle
            this.Hide();

            // Kayit formunu modal aç
            using (var kayitForm = new Kayit())
            {
                kayitForm.ShowDialog(this);
            }

            // LoginForm'u kapat
            this.Close();
        }
    }
}