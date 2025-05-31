using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using gorselProgramlamaProje.Managers;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Forms
{
    public partial class PerformansForm : Form
    {
        private FlowLayoutPanel flpTarihler;
        private Panel panelBilgi;
        private TextBox txtNot;
        private Button btnNotEkle;
        private Button btnGeriDon;

        private Dictionary<DateTime, List<string>> notlar = new Dictionary<DateTime, List<string>>();
        private Button selectedDateButton = null;

        public PerformansForm(Form geriDonulecekForm)
        {
            // Form ayarları
            this.Text = "PerformansForm";
            this.ClientSize = new Size(1000, 600);
            this.BackColor = Color.Black;

            // Tarih paneli (FlowLayoutPanel)
            flpTarihler = new FlowLayoutPanel
            {
                Location = new Point(50, 20),
                Size = new Size(900, 70),
                BackColor = Color.FromArgb(30, 30, 30),
                WrapContents = false
            };
            Controls.Add(flpTarihler);

            // Bilgi paneli (buraya özet + notlar eklenecek)
            panelBilgi = new Panel
            {
                Location = new Point(50, 100),
                Size = new Size(900, 350),
                BackColor = Color.FromArgb(40, 40, 40)
            };
            Controls.Add(panelBilgi);

            // Not girişi TextBox
            txtNot = new TextBox
            {
                Size = new Size(400, 30),
                Location = new Point(50, 470)
            };
            Controls.Add(txtNot);

            // Not Ekle butonu
            btnNotEkle = new Button
            {
                Text = "Not Ekle",
                Size = new Size(100, 30),
                Location = new Point(460, 470),
                BackColor = Color.HotPink,
                ForeColor = Color.White
            };
            btnNotEkle.Click += BtnNotEkle_Click;
            Controls.Add(btnNotEkle);

            // Geri dön butonu
            btnGeriDon = new Button
            {
                Text = "← Geri Dön",
                Size = new Size(120, 40),
                Location = new Point(this.ClientSize.Width - 140, this.ClientSize.Height - 60),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                BackColor = Color.FromArgb(255, 192, 192),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            btnGeriDon.Click += (s, ev) => this.Close();
            Controls.Add(btnGeriDon);

            // Tarih butonlarını oluştur
            DateTime bugun = DateTime.Today;
            for (int i = -3; i <= 3; i++)
            {
                DateTime gun = bugun.AddDays(i);

                Button btnGun = new Button
                {
                    Size = new Size(120, 60),
                    Text = $"{gun.ToString("ddd", new CultureInfo("tr-TR"))}\n{gun:dd.MM.yyyy}",
                    Tag = gun,
                    BackColor = i == 0 ? Color.LightPink : Color.LightGray,
                    ForeColor = i == 0 ? Color.Black : Color.White,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat
                };

                btnGun.Click += BtnTarih_Click;
                flpTarihler.Controls.Add(btnGun);

                if (i == 0)
                    selectedDateButton = btnGun;
            }

            // Başlangıçta “bugün”ü seçili kabul edip, o günün detayını göster
            if (selectedDateButton != null)
            {
                GunuGoster((DateTime)selectedDateButton.Tag);
            }
        }

        // Bir tarih butonuna tıklanınca
        private void BtnTarih_Click(object sender, EventArgs e)
        {
            if (selectedDateButton != null)
            {
                selectedDateButton.BackColor = Color.LightGray;
                selectedDateButton.ForeColor = Color.White;
            }

            Button tiklanan = sender as Button;
            selectedDateButton = tiklanan;
            selectedDateButton.BackColor = Color.LightPink;
            selectedDateButton.ForeColor = Color.Black;

            DateTime secilenTarih = (DateTime)tiklanan.Tag;

            // Eğer seçilen tarih için not listesi yoksa, boş bir liste oluştur
            if (!notlar.ContainsKey(secilenTarih))
            {
                notlar[secilenTarih] = new List<string>();
            }

            GunuGoster(secilenTarih);
        }

        // Not Ekle butonuna tıklanınca
        private void BtnNotEkle_Click(object sender, EventArgs e)
        {
            if (selectedDateButton == null) return;

            DateTime seciliTarih = (DateTime)selectedDateButton.Tag;
            string metin = txtNot.Text.Trim();

            if (!string.IsNullOrEmpty(metin))
            {
                if (!notlar.ContainsKey(seciliTarih))
                    notlar[seciliTarih] = new List<string>();

                notlar[seciliTarih].Add(metin);
                txtNot.Clear();
                GunuGoster(seciliTarih);
            }
        }

        // Seçili günü ekrana hem notlarla birlikte özet verilerini de basar
        private void GunuGoster(DateTime tarih)
        {
            panelBilgi.Controls.Clear();

            // 1) Seçili Tarih başlığı
            Label lblTarih = new Label
            {
                Text = $"📅 Seçili Tarih: {tarih:dd.MM.yyyy}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };
            panelBilgi.Controls.Add(lblTarih);

            // 2) Veritabanından “Günlük Özet” verisini çek
            int currentUserId = SessionManager.CurrentUserId;
            var ozet = GunlukOzetManager.GetOzetByDate(currentUserId, tarih);

            int toplamPomodoro = 0;
            int basariliGorevSayisi = 0;
            int basarisizGorevSayisi = 0;

            if (ozet != null)
            {
                toplamPomodoro = ozet.ToplamPomodoroDakika;
                basariliGorevSayisi = ozet.BasariliGorevSayisi;
                basarisizGorevSayisi = ozet.BasarisizGorevSayisi;
            }

            // 3) “Çalışılan Süre” etiketi
            Label lblSure = new Label
            {
                Text = $"⏱️ Çalışılan Süre: {toplamPomodoro} dk",
                ForeColor = Color.LightGreen,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                Location = new Point(20, 60),
                AutoSize = true
            };
            panelBilgi.Controls.Add(lblSure);

            // 4) “Başarılı Görev” etiketi
            Label lblBasarili = new Label
            {
                Text = $"✅ Başarılı Görev: {basariliGorevSayisi}",
                ForeColor = Color.LightBlue,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(20, 90),
                AutoSize = true
            };
            panelBilgi.Controls.Add(lblBasarili);

            // 5) “Başarısız Görev” etiketi
            Label lblBasarisiz = new Label
            {
                Text = $"❌ Başarısız Görev: {basarisizGorevSayisi}",
                ForeColor = Color.LightCoral,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Location = new Point(20, 115),
                AutoSize = true
            };
            panelBilgi.Controls.Add(lblBasarisiz);

            // 6) Notları göster (eğer varsa; yoksa “not yok” mesajı)
            if (notlar.ContainsKey(tarih) && notlar[tarih].Count > 0)
            {
                int y = 145;
                foreach (var not in notlar[tarih])
                {
                    Label lblNot = new Label
                    {
                        Text = $"📝 {not}",
                        ForeColor = Color.LightGray,
                        Font = new Font("Segoe UI", 10, FontStyle.Italic),
                        Location = new Point(30, y),
                        AutoSize = true
                    };
                    panelBilgi.Controls.Add(lblNot);
                    y += 25;
                }
            }
            else
            {
                Label lblBos = new Label
                {
                    Text = "🔇 Bu güne ait not bulunamadı.",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 10, FontStyle.Italic),
                    Location = new Point(30, 145),
                    AutoSize = true
                };
                panelBilgi.Controls.Add(lblBos);
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
