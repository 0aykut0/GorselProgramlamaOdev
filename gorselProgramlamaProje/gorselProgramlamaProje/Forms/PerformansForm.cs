using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class PerformansForm : Form
    {
        public PerformansForm()
        {
            InitializeComponent();
        }

        private void PerformansForm_Load(object sender, EventArgs e)
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

                // Sonradan işlem eklenecekse buraya:
                // btn.Click += TarihButonunaTikla;

                flpTarihler.Controls.Add(btn);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
        }
    }
}
