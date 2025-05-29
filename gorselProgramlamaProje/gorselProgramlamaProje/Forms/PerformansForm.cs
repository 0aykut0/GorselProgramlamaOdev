using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class PerformansForm : Form
    {
        private FlowLayoutPanel flpTarihler;
        private Panel panelBilgi;
        private Button geriDonButton;

        private Dictionary<DateTime, (int saat, int puan)> gunlukVeriler = new Dictionary<DateTime, (int, int)>
        {
            { new DateTime(2025, 5, 29), (4, 8) },
            { new DateTime(2025, 5, 28), (3, 7) },
            { new DateTime(2025, 5, 27), (5, 9) },
            { new DateTime(2025, 5, 26), (2, 5) },
            { new DateTime(2025, 5, 25), (0, 0) },
            { new DateTime(2025, 5, 30), (6, 9) },
            { new DateTime(2025, 5, 31), (4, 6) },
        };

        private Button seciliButon;

        public PerformansForm()
        {
            InitializeComponent();
            this.Load += PerformansForm_Load;
        }

        private void PerformansForm_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.ClientSize = new Size(900, 600);

            flpTarihler = new FlowLayoutPanel();
            flpTarihler.Location = new Point(90, 30);
            flpTarihler.Size = new Size(720, 60);
            flpTarihler.BackColor = Color.FromArgb(40, 40, 40);
            flpTarihler.WrapContents = false;
            Controls.Add(flpTarihler);

            panelBilgi = new Panel();
            panelBilgi.Size = new Size(600, 150);
            panelBilgi.Location = new Point(90, 110);
            panelBilgi.BackColor = Color.FromArgb(40, 40, 40);
            Controls.Add(panelBilgi);

            geriDonButton = new Button();
            geriDonButton.Text = "← Geri Dön";
            geriDonButton.Location = new Point(740, 550);
            geriDonButton.BackColor = Color.FromArgb(255, 192, 192);
            geriDonButton.Click += (s, ev) => this.Close();
            Controls.Add(geriDonButton);

            DateTime bugun = new DateTime(2025, 5, 29);
            for (int i = -6; i <= 0; i++)
            {
                DateTime tarih = bugun.AddDays(i);
                Button btnTarih = new Button();
                btnTarih.Size = new Size(80, 50);
                btnTarih.Text = tarih.ToString("ddd\n dd");
                btnTarih.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btnTarih.Tag = tarih;
                btnTarih.BackColor = Color.FromArgb(200, 200, 200);
                btnTarih.Click += BtnTarih_Click;

                if (tarih.Date == bugun.Date)
                {
                    seciliButon = btnTarih;
                    btnTarih.BackColor = Color.FromArgb(255, 192, 192);
                    panelBilgi.Controls.Clear();
                    TarihBilgisiGoster(tarih);
                }

                flpTarihler.Controls.Add(btnTarih);
            }
        }

        private void BtnTarih_Click(object sender, EventArgs e)
        {
            if (sender is Button tiklananButon)
            {
                if (seciliButon != null)
                    seciliButon.BackColor = Color.FromArgb(200, 200, 200);

                tiklananButon.BackColor = Color.FromArgb(255, 192, 192);
                seciliButon = tiklananButon;

                DateTime seciliTarih = (DateTime)tiklananButon.Tag;
                panelBilgi.Controls.Clear();
                TarihBilgisiGoster(seciliTarih);
            }
        }

        private void TarihBilgisiGoster(DateTime tarih)
        {
            Label lblTarih = new Label();
            lblTarih.Text = $"Seçili Tarih: {tarih:dd.MM.yyyy}";
            lblTarih.ForeColor = Color.White;
            lblTarih.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTarih.Location = new Point(20, 20);
            lblTarih.AutoSize = true;
            panelBilgi.Controls.Add(lblTarih);

            if (gunlukVeriler.TryGetValue(tarih, out var veri))
            {
                Label lblSaat = new Label();
                lblSaat.Text = $"Çalışma Süesi: {veri.saat} saat";
                lblSaat.ForeColor = Color.White;
                lblSaat.Location = new Point(20, 50);
                lblSaat.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblSaat.AutoSize = true;
                panelBilgi.Controls.Add(lblSaat);

                Label lblPuan = new Label();
                lblPuan.Text = $"Günlük Puan: {veri.puan} / 10";
                lblPuan.ForeColor = Color.White;
                lblPuan.Location = new Point(20, 80);
                lblPuan.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblPuan.AutoSize = true;
                panelBilgi.Controls.Add(lblPuan);
            }
            else
            {
                Label lblBos = new Label();
                lblBos.Text = "Veri bulunamadı.";
                lblBos.ForeColor = Color.White;
                lblBos.Location = new Point(20, 50);
                lblBos.AutoSize = true;
                panelBilgi.Controls.Add(lblBos);
            }
        }
    }
}
