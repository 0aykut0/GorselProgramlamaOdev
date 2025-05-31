using System;
using System.Globalization;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using gorselProgramlamaProje.Managers;

namespace gorselProgramlamaProje.Forms
{
    public partial class AnaSayfaForm : Form
    {
        //id
        private int currentUserId = SessionManager.CurrentUserId;
        private string currentUsername = SessionManager.CurrentUsername;

        private Button selectedDateButton = null;
        private Dictionary<DateTime, List<string>> gorevler = new Dictionary<DateTime, List<string>>();
        private TextBox txtYeniGorev;
        private Button btnGorevEkle;

        public AnaSayfaForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.ClientSize = new Size(1300, 800);
            this.BackColor = Color.Black;

            txtYeniGorev = new TextBox();
            txtYeniGorev.Size = new Size(500, 30);
            txtYeniGorev.Location = new Point(280, 700);
            txtYeniGorev.Font = new Font("Segoe UI", 10);
            Controls.Add(txtYeniGorev);

            btnGorevEkle = new Button();
            btnGorevEkle.Text = "Görev Ekle";
            btnGorevEkle.Size = new Size(100, 30);
            btnGorevEkle.Location = new Point(800, 700);
            btnGorevEkle.BackColor = Color.HotPink;
            btnGorevEkle.ForeColor = Color.White;
            btnGorevEkle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnGorevEkle.Click += BtnGorevEkle_Click;
            Controls.Add(btnGorevEkle);

            btnGunuBitir.Text = "Günü Bitir";
            btnGunuBitir.Size = new Size(120, 40);
            btnGunuBitir.Location = new Point(this.ClientSize.Width - 140, this.ClientSize.Height - 60);
            btnGunuBitir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGunuBitir.BackColor = Color.FromArgb(255, 192, 192);
            btnGunuBitir.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            flpTarihler.Controls.Clear();
            flpTarihler.Height = 80;
            flpTarihler.Width = 1200;

            for (int i = -3; i <= 3; i++)
            {
                DateTime gun = bugun.AddDays(i);

                Button btn = new Button();
                btn.Size = new Size(120, 70);
                btn.Margin = new Padding(5);
                btn.FlatStyle = FlatStyle.Flat;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Text = $"{gun.ToString("ddd", new CultureInfo("tr-TR"))}\n{gun:dd.MM.yyyy}";
                btn.Tag = gun;

                if (i == 0)
                {
                    btn.BackColor = Color.FromArgb(255, 192, 192);
                    selectedDateButton = btn;
                }
                else
                {
                    btn.BackColor = Color.LightGray;
                }

                btn.Click += TarihButton_Click;
                flpTarihler.Controls.Add(btn);
            }

            DateTime seciliTarih = DateTime.Today;
            gorevler[seciliTarih] = new List<string> { "Java ödevini bitir", "Sunumu hazırla", "GitHub push kontrolü" };

            GorevleriYukle(seciliTarih);
        }

        private void TarihButton_Click(object sender, EventArgs e)
        {
            if (selectedDateButton != null)
            {
                selectedDateButton.BackColor = Color.LightGray;
                selectedDateButton.ForeColor = Color.White;
            }

            selectedDateButton = sender as Button;
            selectedDateButton.BackColor = Color.FromArgb(255, 192, 192);
            selectedDateButton.ForeColor = Color.Black;

            DateTime secilenTarih = (DateTime)selectedDateButton.Tag;
            if (!gorevler.ContainsKey(secilenTarih))
            {
                gorevler[secilenTarih] = new List<string>();
            }

            GorevleriYukle(secilenTarih);
        }

        private void GorevleriYukle(DateTime tarih)
        {
            flpGorevler.Controls.Clear();

            if (!gorevler.ContainsKey(tarih)) return;

            foreach (var metin in gorevler[tarih])
            {
                Panel gorevPanel = new Panel();
                gorevPanel.Size = new Size(560, 40);
                gorevPanel.BackColor = Color.FromArgb(40, 40, 40);
                gorevPanel.Margin = new Padding(5);

                TextBox txt = new TextBox();
                txt.Text = metin;
                txt.ReadOnly = true;
                txt.Size = new Size(270, 25);
                txt.Location = new Point(10, 7);
                txt.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                txt.ForeColor = Color.Black;
                txt.BackColor = Color.White;

                CheckBox chkTamamlandi = new CheckBox();
                chkTamamlandi.Text = "Tamamlandı";
                chkTamamlandi.ForeColor = Color.White;
                chkTamamlandi.Location = new Point(290, 10);
                chkTamamlandi.AutoSize = true;

                chkTamamlandi.CheckedChanged += (s, e) =>
                {
                    txt.Font = chkTamamlandi.Checked
                        ? new Font(txt.Font, FontStyle.Strikeout)
                        : new Font(txt.Font, FontStyle.Regular);
                };

                Button btnSil = new Button();
                btnSil.Text = "Sil";
                btnSil.BackColor = Color.HotPink;
                btnSil.ForeColor = Color.White;
                btnSil.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btnSil.FlatStyle = FlatStyle.Flat;
                btnSil.FlatAppearance.BorderSize = 0;
                btnSil.Size = new Size(50, 25);
                btnSil.Location = new Point(470, 7);
                btnSil.Click += (s, e) =>
                {
                    gorevler[tarih].Remove(metin);
                    GorevleriYukle(tarih);
                };

                gorevPanel.Controls.Add(txt);
                gorevPanel.Controls.Add(chkTamamlandi);
                gorevPanel.Controls.Add(btnSil);

                flpGorevler.Controls.Add(gorevPanel);
            }
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Şu anda kullanılmıyor, ama tasarımda referans var
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            // Şu anda kullanılmıyor, ama tasarımda referans var
        }
        private void BtnGorevEkle_Click(object sender, EventArgs e)
        {
            if (selectedDateButton == null) return;

            DateTime seciliTarih = (DateTime)selectedDateButton.Tag;
            string metin = txtYeniGorev.Text.Trim();

            if (!string.IsNullOrEmpty(metin))
            {
                if (!gorevler.ContainsKey(seciliTarih))
                    gorevler[seciliTarih] = new List<string>();

                gorevler[seciliTarih].Add(metin);
                txtYeniGorev.Clear();
                GorevleriYukle(seciliTarih);
            }
        }
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            // Ayarlar formu varsa burada açılabilir, şu anlık boş.
            MessageBox.Show("Ayarlar butonuna tıklandı.");
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        { // performans formunu aç
            this.Visible = false;
            var performansForm = new PerformansForm();
            performansForm.ShowDialog();
        }
        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {// pomodoro formunu aç
            this.Visible = false; // Ana sayfa formunu gizle
            var pomodoroForm = new PomodoroForm();
            pomodoroForm.ShowDialog();
        }
        private void btnsSilinenler_Click(object sender, EventArgs e)
        {
            // silinenler formunu aç
            this.Visible = false; // Ana sayfa formunu gizle
            var silinenlerForm = new SilinenlerForm();
            silinenlerForm.ShowDialog();
        }

    }
}
