using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class AnaSayfaForm : Form
    {
        private Button selectedDateButton = null;
        private DateTime selectedDate = DateTime.Today;
        private Dictionary<DateTime, List<string>> gorevListesi = new Dictionary<DateTime, List<string>>();

        public AnaSayfaForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.BackColor = Color.Black;
            this.ForeColor = SystemColors.ActiveCaptionText;

            btnGorevEkle.Click += BtnGorevEkle_Click;
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;
            flpTarihler.Controls.Clear();
            flpTarihler.Height = 80;

            for (int i = -3; i <= 3; i++)
            {
                DateTime gun = bugun.AddDays(i);

                Button btn = new Button();
                btn.Size = new Size(90, 70);
                btn.Margin = new Padding(5);
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = (i == 0) ? Color.MediumPurple : Color.LightGray;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Text = gun.ToString("ddd\ndd", new CultureInfo("tr-TR"));
                btn.Tag = gun;
                btn.Click += TarihButton_Click;

                if (i == 0)
                {
                    selectedDate = gun;
                    selectedDateButton = btn;
                }

                flpTarihler.Controls.Add(btn);
            }

            gorevListesi[selectedDate] = new List<string> { "Java ödevini bitir", "Sunumu hazırla", "GitHub push kontrolü" };
            GorevleriYukle(selectedDate);
        }

        private void TarihButton_Click(object sender, EventArgs e)
        {
            if (selectedDateButton != null)
                selectedDateButton.BackColor = Color.LightGray;

            selectedDateButton = sender as Button;
            selectedDateButton.BackColor = Color.MediumPurple;

            selectedDate = (DateTime)selectedDateButton.Tag;
            GorevleriYukle(selectedDate);
        }

        private void GorevleriYukle(DateTime tarih)
        {
            flpGorevler.Controls.Clear();

            if (!gorevListesi.ContainsKey(tarih))
                gorevListesi[tarih] = new List<string>();

            foreach (var gorev in gorevListesi[tarih])
            {
                GorevPanelEkle(gorev);
            }
        }

        private void BtnGorevEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtYeniGorev.Text))
            {
                if (!gorevListesi.ContainsKey(selectedDate))
                    gorevListesi[selectedDate] = new List<string>();

                gorevListesi[selectedDate].Add(txtYeniGorev.Text.Trim());
                GorevPanelEkle(txtYeniGorev.Text.Trim());
                txtYeniGorev.Clear();
            }
        }

        private void GorevPanelEkle(string metin)
        {
            Panel gorevPanel = new Panel();
            gorevPanel.Size = new Size(580, 40);
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
                txt.Font = chkTamamlandi.Checked ? new Font(txt.Font, FontStyle.Strikeout) : new Font(txt.Font, FontStyle.Regular);
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
                flpGorevler.Controls.Remove(gorevPanel);
                gorevListesi[selectedDate].Remove(metin);
            };

            gorevPanel.Controls.Add(txt);
            gorevPanel.Controls.Add(chkTamamlandi);
            gorevPanel.Controls.Add(btnSil);

            flpGorevler.Controls.Add(gorevPanel);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) { }
        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e) { }
        private void btnAyarlar_Click(object sender, EventArgs e) { }
        private void btnPerformans_Click(object sender, EventArgs e) { }
        private void btnAnaSayfa_Click(object sender, EventArgs e) { }
        private void flpGorevler_Paint(object sender, PaintEventArgs e) { }
    }
}