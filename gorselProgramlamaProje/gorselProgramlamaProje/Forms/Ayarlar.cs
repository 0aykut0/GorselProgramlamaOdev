using System;
using System.Drawing;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class Ayarlar : Form
    {
        private Label lblWork;
        private Label lblBreak;
        private NumericUpDown nudWorkMinutes;
        private NumericUpDown nudBreakMinutes;
        private Button btnSave;
        private Button btnCancel;

        public int WorkMinutes { get; private set; }
        public int BreakMinutes { get; private set; }
        public Ayarlar() : this(20, 5) { }

        public Ayarlar(int currentWork, int currentBreak)
        {
            // Form ayarları
            this.Text = "Ayarlar";
            this.Size = new Size(320, 220);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // Label – Çalışma Süresi
            lblWork = new Label();
            lblWork.Text = "Çalışma Süresi (dk):";
            lblWork.Location = new Point(30, 30);
            lblWork.AutoSize = true;

            // NumericUpDown – Çalışma
            nudWorkMinutes = new NumericUpDown();
            nudWorkMinutes.Minimum = 1;
            nudWorkMinutes.Maximum = 60;
            nudWorkMinutes.Value = currentWork;
            nudWorkMinutes.Location = new Point(180, 28);
            nudWorkMinutes.Size = new Size(80, 27);

            // Label – Mola Süresi
            lblBreak = new Label();
            lblBreak.Text = "Mola Süresi (dk):";
            lblBreak.Location = new Point(30, 70);
            lblBreak.AutoSize = true;

            // NumericUpDown – Mola
            nudBreakMinutes = new NumericUpDown();
            nudBreakMinutes.Minimum = 1;
            nudBreakMinutes.Maximum = 30;
            nudBreakMinutes.Value = currentBreak;
            nudBreakMinutes.Location = new Point(180, 68);
            nudBreakMinutes.Size = new Size(80, 27);

            // Kaydet Butonu
            btnSave = new Button();
            btnSave.Text = "Kaydet";
            btnSave.Location = new Point(40, 120);
            btnSave.Size = new Size(100, 35);
            btnSave.Click += BtnSave_Click;

            // İptal Butonu
            btnCancel = new Button();
            btnCancel.Text = "İptal";
            btnCancel.Location = new Point(160, 120);
            btnCancel.Size = new Size(100, 35);
            btnCancel.Click += BtnCancel_Click;

            // Form'a kontrolleri ekle
            this.Controls.Add(lblWork);
            this.Controls.Add(nudWorkMinutes);
            this.Controls.Add(lblBreak);
            this.Controls.Add(nudBreakMinutes);
            this.Controls.Add(btnSave);
            this.Controls.Add(btnCancel);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            WorkMinutes = (int)nudWorkMinutes.Value;
            BreakMinutes = (int)nudBreakMinutes.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
