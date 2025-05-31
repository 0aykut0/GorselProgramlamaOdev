using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

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

        public PerformansForm()
        {
            this.Text = "PerformansForm";
            this.ClientSize = new Size(1000, 600);
            this.BackColor = Color.Black;

            // Tarih paneli
            flpTarihler = new FlowLayoutPanel
            {
                Location = new Point(50, 20),
                Size = new Size(900, 70),
                BackColor = Color.FromArgb(30, 30, 30),
                WrapContents = false
            };
            Controls.Add(flpTarihler);

            // Bilgi paneli
            panelBilgi = new Panel
            {
                Location = new Point(50, 100),
                Size = new Size(900, 180),
                BackColor = Color.FromArgb(40, 40, 40)
            };
            Controls.Add(panelBilgi);

            // Not girişi
            txtNot = new TextBox
            {
                Size = new Size(400, 30),
                Location = new Point(50, 300)
            };
            Controls.Add(txtNot);

            btnNotEkle = new Button
            {
                Text = "Not Ekle",
                Size = new Size(100, 30),
                Location = new Point(460, 300),
                BackColor = Color.HotPink,
                ForeColor = Color.White
            };
            btnNotEkle.Click += BtnNotEkle_Click;
            Controls.Add(btnNotEkle);

            // Geri dön
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

            // Tarih butonları oluştur
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

            // Başlangıçta bugünü göster
            if (selectedDateButton != null)
                GunuGoster((DateTime)selectedDateButton.Tag);
        }

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

            // Eğer seçilen tarih için not listesi yoksa, boş oluştur
            if (!notlar.ContainsKey(secilenTarih))
            {
                notlar[secilenTarih] = new List<string>();
            }

            GunuGoster(secilenTarih);
        }

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

        private void GunuGoster(DateTime tarih)
        {
            panelBilgi.Controls.Clear();

            Label lblTarih = new Label
            {
                Text = $"📅 Seçili Tarih: {tarih:dd.MM.yyyy}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true
            };
            panelBilgi.Controls.Add(lblTarih);

            if (notlar.ContainsKey(tarih) && notlar[tarih].Count > 0)
            {
                int y = 60;
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
                    Location = new Point(30, 60),
                    AutoSize = true
                };
                panelBilgi.Controls.Add(lblBos);
            }
        }
    }
}
