using System;
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
    public partial class SilinenlerForm : Form
    {
        public SilinenlerForm()
        {
            InitializeComponent();
            this.Load += SilinenlerForm_Load;
           
        }

        private void SilinenlerForm_Load(object? sender, EventArgs e)
        {
            // Panel çerçevesini kaldır
            pnlContainer.BorderStyle = BorderStyle.None;

            // Form ve grid arkaplanı
            this.BackColor = Color.Black;
            dgvDeleted.BackgroundColor = Color.Black;
            dgvDeleted.EnableHeadersVisualStyles = false;

            // Mevcut sütunları temizle
            dgvDeleted.Columns.Clear();

            // Kullanacağımız pembe tonu
            Color pink = ColorTranslator.FromHtml("#fcbec8");

            // 1) “Görev” sütunu
            var colTask = new DataGridViewTextBoxColumn
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
            };
            dgvDeleted.Columns.Add(colTask);

            // 2) “Tarih” sütunu
            var colDate = new DataGridViewTextBoxColumn
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
            };
            dgvDeleted.Columns.Add(colDate);

            // 3) “Geri Yükle” buton sütunu
            var colRestore = new DataGridViewButtonColumn
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
            };
            dgvDeleted.Columns.Add(colRestore);

            // 4) “Kalıcı Sil” buton sütunu
            var colDelete = new DataGridViewButtonColumn
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
            };
            dgvDeleted.Columns.Add(colDelete);

            // 5) Başlık satırı stili
            dgvDeleted.ColumnHeadersDefaultCellStyle.BackColor = pink;
            dgvDeleted.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvDeleted.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            dgvDeleted.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDeleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleted.ColumnHeadersHeight = 40;

            // 6) Grid çizgileri ve seçim rengi
            dgvDeleted.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeleted.GridColor = Color.Black;
            dgvDeleted.DefaultCellStyle.SelectionBackColor = ControlPaint.Dark(pink);
            dgvDeleted.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 7) Grid paneli doldursun
            dgvDeleted.Dock = DockStyle.Fill;

            // 8) Test için örnek satırlar (veritabanı eklemesi sonra)
            dgvDeleted.Rows.Add("Ödev Yaz", DateTime.Now.AddDays(-1));
            dgvDeleted.Rows.Add("Sunum Hazırla", DateTime.Now.AddHours(-5));
            dgvDeleted.Rows.Add("Eski Notlar", DateTime.Now.AddDays(-2));
        }

        private void dgvDeleted_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string colName = dgvDeleted.Columns[e.ColumnIndex].Name;
            string task = dgvDeleted.Rows[e.RowIndex].Cells["colTask"].Value?.ToString() ?? "";

            if (colName == "colRestore")
            {
                MessageBox.Show($"“{task}” görevi geri yüklendi!",
                                "Geri Yükle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDeleted.Rows.RemoveAt(e.RowIndex);
            }
            else if (colName == "colDelete")
            {
                var result = MessageBox.Show($"“{task}” kalıcı olarak silinsin mi?",
                                              "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                    dgvDeleted.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}