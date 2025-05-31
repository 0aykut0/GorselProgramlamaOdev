using System;
using System.Globalization;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using gorselProgramlamaProje.Managers;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Forms
{
    public partial class AnaSayfaForm : Form
    {
        //id
        private int currentUserId = SessionManager.CurrentUserId;
        private string currentUsername = SessionManager.CurrentUsername;
        private DateTime selectedDate;
        private DateTime bugun = DateTime.Today;


        private Button selectedDateButton = null;
        //private Dictionary<DateTime, List<string>> gorevler = new Dictionary<DateTime, List<string>>();
        private TextBox txtYeniGorev;
        private Button btnGorevEkle;

        public AnaSayfaForm()
        {
            InitializeComponent();
            var mevcutOzet = GunlukOzetManager.GetOzetByDate(currentUserId, selectedDate);
            if (mevcutOzet == null)
            {
                // Yeni kayıt: 0 dakika, 0 başarılı, 0 başarısız
                GunlukOzet newOzet = new GunlukOzet
                {
                    KullaniciId = currentUserId,
                    Tarih = selectedDate,
                    ToplamPomodoroDakika = 0,
                    BasariliGorevSayisi = 0,
                    BasarisizGorevSayisi = 0
                };
                GunlukOzetManager.AddGunlukOzet(newOzet);
            }

            // Form ayarları
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.ClientSize = new Size(1300, 800);
            this.BackColor = Color.Black;
            
            // Başlık ayarları
            txtYeniGorev = new TextBox();
            txtYeniGorev.Size = new Size(500, 30);
            txtYeniGorev.Location = new Point(280, 700);
            txtYeniGorev.Font = new Font("Segoe UI", 10);
            Controls.Add(txtYeniGorev);

            // Butonlar
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
            // default olarak bugünün tarihini göster
            selectedDate = bugun;
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

            //gorevler[seciliTarih] = new List<string> { "Java ödevini bitir", "Sunumu hazırla", "GitHub push kontrolü" };
            var gorevlerOgun = GorevManager.TariheGoreGorevleriGetir(currentUserId, selectedDate);
            GorevleriYukle(gorevlerOgun);
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

            selectedDate = (DateTime)selectedDateButton.Tag;
            //if (!gorevler.ContainsKey(secilenTarih))
            //{
            //    gorevler[secilenTarih] = new List<string>();
            //}
            var gorevlerOgun = GorevManager.TariheGoreGorevleriGetir(currentUserId, selectedDate);
            GorevleriYukle(gorevlerOgun);
        }

        private void GorevleriYukle(List<Gorev> gorevListesi)
        {
            flpGorevler.Controls.Clear();

            foreach (var gorev in gorevListesi)
            {
                Panel gorevPanel = new Panel();
                gorevPanel.Size = new Size(560, 40);
                gorevPanel.BackColor = Color.FromArgb(40, 40, 40);
                gorevPanel.Margin = new Padding(5);

                // 1) Başlık TextBox
                TextBox txt = new TextBox();
                txt.Text = gorev.Baslik;
                txt.ReadOnly = true;
                txt.Size = new Size(270, 25);
                txt.Location = new Point(10, 7);
                txt.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                txt.ForeColor = Color.Black;
                txt.BackColor = Color.White;
                if (gorev.TamamlandiMi)
                    txt.Font = new Font(txt.Font, FontStyle.Strikeout);

                // 2) Tamamlandı CheckBox
                CheckBox chkTamamlandi = new CheckBox();
                chkTamamlandi.Text = "Tamamlandı";
                chkTamamlandi.ForeColor = Color.White;
                chkTamamlandi.Location = new Point(290, 10);
                chkTamamlandi.AutoSize = true;
                chkTamamlandi.Checked = gorev.TamamlandiMi;
                chkTamamlandi.Tag = gorev;
                chkTamamlandi.CheckedChanged += (s, e) =>
                {
                    var cb = s as CheckBox;
                    var g = (Gorev)cb.Tag;
                    g.TamamlandiMi = cb.Checked;
                    GorevManager.GoreviGuncelle(g);

                    if (cb.Checked)
                        txt.Font = new Font(txt.Font, FontStyle.Strikeout);
                    else
                        txt.Font = new Font(txt.Font, FontStyle.Regular);
                };

                // 3) Sil Butonu
                Button btnSil = new Button();
                btnSil.Text = "Sil";
                btnSil.BackColor = Color.HotPink;
                btnSil.ForeColor = Color.White;
                btnSil.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                btnSil.FlatStyle = FlatStyle.Flat;
                btnSil.FlatAppearance.BorderSize = 0;
                btnSil.Size = new Size(50, 25);
                btnSil.Location = new Point(470, 7);
                btnSil.Tag = gorev;
                btnSil.Click += (s, e) =>
                {
                    var b = s as Button;
                    var g = (Gorev)b.Tag;
                    GorevManager.GoreviSil(g.Id);

                    // Silme sonrası, aynı tarih için listeyi yeniden çek:
                    var updatedList = GorevManager.TariheGoreGorevleriGetir(currentUserId, selectedDate);
                    GorevleriYukle(updatedList);
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

            // Artık parametreden değil, form düzeyindeki değişkenden alıyoruz
            // DateTime seciliTarih = (DateTime)selectedDateButton.Tag;
            DateTime seciliTarih = selectedDate;

            string baslik = txtYeniGorev.Text.Trim();

            if (!string.IsNullOrEmpty(baslik))
            {
                var yeniGorev = new Gorev
                {
                    KullaniciId = currentUserId,
                    Baslik = baslik,
                    Aciklama = baslik,
                    OlusturmaTarihi = seciliTarih,
                    TamamlandiMi = false
                };
                GorevManager.GorevEkle(yeniGorev);

                txtYeniGorev.Clear();

                // Aynı günün görevlerini DB’den yeniden çek ve yükle
                var oGunGorevleri = GorevManager.TariheGoreGorevleriGetir(currentUserId, seciliTarih);
                GorevleriYukle(oGunGorevleri);
            }
        }


        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            this.Hide();
            PomodoroForm yeniForm = new(this);
            yeniForm.ShowDialog();
            this.Show();
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
            this.Hide();
            PerformansForm performansForm = new(this);
            performansForm.ShowDialog();
            this.Show();
        }

        private void btnsSilinenler_Click(object sender, EventArgs e)
        {
            this.Hide();
            SilinenlerForm silinenlerForm = new(this);
            silinenlerForm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();              // AnaSayfa gizlenir
            loginForm.ShowDialog();   // Login form modal olarak açılır
            this.Close();             // Login kapanınca AnaSayfa tamamen kapanır
        }

        private void btnGunuBitir_Click(object sender, EventArgs e)
        {
            this.Hide();

            // 3.a) O güne ait görevleri çek
            var gorevlerOgun = GorevManager.TariheGoreGorevleriGetir(currentUserId, selectedDate);

            // 3.b) Başarılı / Başarısız sayıları hesapla
            int basariliSayisi = gorevlerOgun.Count(g => g.TamamlandiMi);
            int basarisizSayisi = gorevlerOgun.Count(g => !g.TamamlandiMi);

            // 3.c) GunlukOzet kaydını getir (zaruri: ozet zaten "AnaSayfaForm_Load" aşamasında oluşturulmuş olmalı)
            var ozet = GunlukOzetManager.GetOzetByDate(currentUserId, selectedDate);
            if (ozet != null)
            {
                ozet.BasariliGorevSayisi = basariliSayisi;
                ozet.BasarisizGorevSayisi = basarisizSayisi;
                GunlukOzetManager.UpdateGunlukOzet(ozet);  // Bu metodu manager'a eklemeniz gerekir
            }

            // 3.d) GunSonu formunu aç
            GunSonu gunSonuForm = new GunSonu(selectedDate, currentUserId);
            gunSonuForm.ShowDialog();

            this.Close();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }
    }
}

