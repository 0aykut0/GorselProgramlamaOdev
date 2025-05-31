using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class PerformansForm : Form
    {
        private FlowLayoutPanel flpTarihler;
        private FlowLayoutPanel flpVeriPanel;
        private Button geriDonButton;
        private TextBox txtNot;
        private Button btnNotEkle;
        private Button seciliButon;

        private Dictionary<DateTime, (int saat, int puan, string not)> gunlukVeriler = new()
        {
            { new DateTime(2025, 5, 29), (4, 8, "Verimli çalıştım") },
            { new DateTime(2025, 5, 28), (3, 6, "Daha iyi olabilirdi") },
            { new DateTime(2025, 5, 27), (5, 9, "Mükemmel geçti") }
        };

        private DateTime seciliTarih = DateTime.Today;

        // AnaSayfa referansı alacak constructor
        public PerformansForm(Form geriDonulecekForm)
        {
            InitializeComponent();
            anaSayfaForm = geriDonulecekForm;
            this.Load += PerformansForm_Load;
        }

        private void PerformansForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ClientSize = new Size(1000, 700);

            flpTarihler = new FlowLayoutPanel
            {
                Location = new Point(60, 20),
                Size = new Size(880, 70),
                BackColor = Color.FromArgb(30, 30, 30),
                WrapContents = false
            };
            this.Controls.Add(flpTarihler);

            DateTime bugun = new DateTime(2025, 5, 29);
            for (int i = -6; i <= 0; i++)
            {
                DateTime tarih = bugun.AddDays(i);
                Button btn = new Button
                {
                    Size = new Size(110, 60),
                    Text = $"{tarih:ddd}\n{tarih:dd.MM.yyyy}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(60, 60, 60),
                    Tag = tarih,
                    FlatStyle = FlatStyle.Flat
                };
                btn.FlatAppearance.BorderColor = Color.Gray;
                btn.FlatAppearance.BorderSize = 1;
                btn.Click += BtnTarih_Click;
                flpTarihler.Controls.Add(btn);

                if (tarih == bugun)
                {
                    seciliButon = btn;
                    btn.BackColor = Color.FromArgb(255, 192, 192);
                    btn.ForeColor = Color.Black;
                    seciliTarih = tarih;
                }
            }

            flpVeriPanel = new FlowLayoutPanel
            {
                Location = new Point(60, 110),
                Size = new Size(880, 150),
                BackColor = Color.FromArgb(40, 40, 40),
                AutoScroll = true,
                FlowDirection = FlowDirection.TopDown
            };
            this.Controls.Add(flpVeriPanel);

            txtNot = new TextBox
            {
                Size = new Size(400, 30),
                Location = new Point(60, 280)
            };
            this.Controls.Add(txtNot);

            btnNotEkle = new Button
            {
                Text = "Not Ekle",
                Size = new Size(80, 30),
                Location = new Point(470, 280),
                BackColor = Color.HotPink,
                ForeColor = Color.White
            };
            btnNotEkle.Click += BtnNotEkle_Click;
            this.Controls.Add(btnNotEkle);

            geriDonButton = new Button
            {
                Text = "← Geri Dön",
                Size = new Size(120, 40),
                Location = new Point(this.ClientSize.Width - 140, this.ClientSize.Height - 60),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                BackColor = Color.FromArgb(255, 192, 192)
            };
            geriDonButton.Click += (s, ev) => this.Close();
            this.Controls.Add(geriDonButton);

            PaneliGuncelle(seciliTarih);
        }

        private void BtnTarih_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (seciliButon != null)
                {
                    seciliButon.BackColor = Color.FromArgb(60, 60, 60);
                    seciliButon.ForeColor = Color.White;
                }

                btn.BackColor = Color.FromArgb(255, 192, 192);
                btn.ForeColor = Color.Black;
                seciliButon = btn;
                seciliTarih = (DateTime)btn.Tag;
                PaneliGuncelle(seciliTarih);
            }
        }

        private void PaneliGuncelle(DateTime tarih)
        {
            flpVeriPanel.Controls.Clear();

            Label lblTarih = new Label
            {
                Text = $"📅 Seçili Tarih: {tarih:dd.MM.yyyy}",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                AutoSize = true
            };
            flpVeriPanel.Controls.Add(lblTarih);

            if (gunlukVeriler.TryGetValue(tarih, out var veri))
            {
                Label lblSaat = new Label
                {
                    Text = $"🕒 Çalışma Süresi: {veri.saat} saat",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true
                };
                flpVeriPanel.Controls.Add(lblSaat);

                Label lblPuan = new Label
                {
                    Text = $"⭐ Günlük Puan: {veri.puan} / 10",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    AutoSize = true
                };
                flpVeriPanel.Controls.Add(lblPuan);

                if (!string.IsNullOrEmpty(veri.not))
                {
                    Label lblNot = new Label
                    {
                        Text = $"📝 Not: {veri.not}",
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 9),
                        AutoSize = true
                    };
                    flpVeriPanel.Controls.Add(lblNot);
                }
            }
            else
            {
                flpVeriPanel.Controls.Add(new Label
                {
                    Text = "Veri bulunamadı.",
                    ForeColor = Color.White,
                    AutoSize = true
                });
            }
        }

        private void BtnNotEkle_Click(object sender, EventArgs e)
        {
            string girilenNot = txtNot.Text.Trim();
            if (!string.IsNullOrEmpty(girilenNot))
            {
                if (gunlukVeriler.ContainsKey(seciliTarih))
                {
                    var eski = gunlukVeriler[seciliTarih];
                    gunlukVeriler[seciliTarih] = (eski.saat, eski.puan, girilenNot);
                }
                else
                {
                    gunlukVeriler[seciliTarih] = (0, 0, girilenNot);
                }

                PaneliGuncelle(seciliTarih);
                txtNot.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anaSayfaForm.Show(); // Mevcut AnaSayfa’yı tekrar göster
            this.Close();        // PerformansForm’u kapat
        }
    }
}