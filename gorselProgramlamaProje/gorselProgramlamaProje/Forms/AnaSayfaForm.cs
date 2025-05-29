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
        public AnaSayfaForm()
        {
            InitializeComponent();

            // Form sabitleme ve tema ayarları
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.BackColor = Color.Black; // Arka plan tamamen siyah
            this.ForeColor = SystemColors.ActiveCaptionText;
        }

        private void AnaSayfaForm_Load(object sender, EventArgs e)
        {
            DateTime bugun = DateTime.Today;

            flpTarihler.Controls.Clear();

            for (int i = -3; i <= 3; i++)
            {
                DateTime gun = bugun.AddDays(i);

                Button btn = new Button();
                btn.Size = new Size(80, 60);
                btn.Margin = new Padding(5);
                btn.FlatStyle = FlatStyle.Flat;
                btn.BackColor = (i == 0) ? Color.MediumPurple : Color.LightGray;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;

                btn.Text = gun.ToString("ddd\ndd", new CultureInfo("tr-TR"));
                btn.Tag = gun;

                flpTarihler.Controls.Add(btn);
            }

            SahteGorevEkle("Java ödevini bitir");
            SahteGorevEkle("Sunumu hazırla");
            SahteGorevEkle("GitHub push kontrolü");
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }

        private void SahteGorevEkle(string metin)
        {
            Panel gorevPanel = new Panel();
            gorevPanel.Size = new Size(500, 40);
            gorevPanel.BackColor = Color.FromArgb(40, 40, 40); // Daha koyu arka plan
            gorevPanel.Margin = new Padding(5);

            TextBox txt = new TextBox();
            txt.Text = metin;
            txt.ReadOnly = true;
            txt.Size = new Size(370, 25);
            txt.Location = new Point(10, 7);
            txt.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            txt.ForeColor = Color.Black;
            txt.BackColor = Color.White;

            Button btnSil = new Button();
            btnSil.Text = "Sil";
            btnSil.BackColor = Color.HotPink;
            btnSil.ForeColor = Color.White;
            btnSil.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.Size = new Size(50, 25);
            btnSil.Location = new Point(390, 7);

            btnSil.Click += (s, e) => flpGorevler.Controls.Remove(gorevPanel);

            gorevPanel.Controls.Add(txt);
            gorevPanel.Controls.Add(btnSil);

            flpGorevler.Controls.Add(gorevPanel);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Boş
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            // Boş
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            // Boş
        }

        private void btnPerformans_Click(object sender, EventArgs e)
        {
            // Boş
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            // Boş
        }

        private void flpGorevler_Paint(object sender, PaintEventArgs e)
        {
            // Boş
        }

    }
}
