using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Drawing;
using System.Windows.Forms;
using gorselProgramlamaProje.Managers;

namespace gorselProgramlamaProje.Forms
{
    public partial class SilinenlerForm : Form
    {
        public SilinenlerForm()
        {
            InitializeComponent();

            // Olayları bağla
            this.Load += SilinenlerForm_Load;
            dgvDeleted.CellContentClick += dgvDeleted_CellContentClick;
        }

        private void SilinenlerForm_Load(object? sender, EventArgs e)
        {
            // Panel kenarını kaldır
            pnlContainer.BorderStyle = BorderStyle.None;

            // Form + grid arkaplanını siyah yap
            this.BackColor = Color.Black;
            dgvDeleted.BackgroundColor = Color.Black;
            dgvDeleted.EnableHeadersVisualStyles = false;
            dgvDeleted.AutoGenerateColumns = false;
            dgvDeleted.Dock = DockStyle.Fill;

            // Kullanacağımız pembe tonu
            Color pink = ColorTranslator.FromHtml("#fcbec8");

            // 1) “Görev” sütunu
            dgvDeleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTask",
                HeaderText = "Görev",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                }
            });

            // 2) “Tarih” sütunu
            dgvDeleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                HeaderText = "Tarih",
                Width = 200,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    Format = "g",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // 3) “Geri Al” butonu
            dgvDeleted.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colRestore",
                HeaderText = "",
                Text = "↺",
                UseColumnTextForButtonValue = true,
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // 4) “Kalıcı Sil” butonu
            dgvDeleted.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colDelete",
                HeaderText = "",
                Text = "🗑️",
                UseColumnTextForButtonValue = true,
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // 5) Başlık satırı stili
            dgvDeleted.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = pink,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            dgvDeleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleted.ColumnHeadersHeight = 40;

            // 6) Hücre çizgileri ve seçim rengi
            dgvDeleted.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeleted.GridColor = Color.Black;
            dgvDeleted.DefaultCellStyle.SelectionBackColor = ControlPaint.Dark(pink);
            dgvDeleted.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 7) Test verisi ekle
            dgvDeleted.Rows.Add("Test Görev 1", DateTime.Now.AddDays(-1));
            dgvDeleted.Rows.Add("Test Görev 2", DateTime.Now.AddHours(-3));
            dgvDeleted.Rows.Add("Test Görev 3", DateTime.Now.AddDays(-2));
        }

        private void dgvDeleted_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var colName = dgvDeleted.Columns[e.ColumnIndex].Name;
            var task = dgvDeleted.Rows[e.RowIndex].Cells["colTask"].Value?.ToString() ?? "";

            if (colName == "colRestore")
            {
                // Geri Al
                MessageBox.Show($"“{task}” geri yüklendi!",
                                "Geri Yükle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDeleted.Rows.RemoveAt(e.RowIndex);
            }
            else if (colName == "colDelete")
            {
                // Kalıcı Sil
                var result = MessageBox.Show($"“{task}” kalıcı olarak silinsin mi?",
                                             "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    dgvDeleted.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
