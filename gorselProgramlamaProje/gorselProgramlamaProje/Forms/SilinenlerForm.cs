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
        private bool tiklamaKilitli = false;

        public SilinenlerForm()
        {
            InitializeComponent();
            this.Load += SilinenlerForm_Load;
            dgvDeleted.CellContentClick += dgvDeleted_CellContentClick;
        }

        private void SilinenlerForm_Load(object? sender, EventArgs e)
        {
            dgvDeleted.Columns.Clear();
            dgvDeleted.AutoGenerateColumns = false;
            dgvDeleted.Dock = DockStyle.Fill;

            pnlContainer.BorderStyle = BorderStyle.None;
            BackColor = Color.Black;
            dgvDeleted.BackgroundColor = Color.Black;
            dgvDeleted.EnableHeadersVisualStyles = false;

            var pink = ColorTranslator.FromHtml("#fcbec8");

            dgvDeleted.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = pink,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            dgvDeleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDeleted.ColumnHeadersHeight = 40;

            dgvDeleted.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDeleted.GridColor = Color.Black;
            dgvDeleted.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#add8e6"); // Seçim rengi mavi

            dgvDeleted.DefaultCellStyle.SelectionForeColor = Color.Black;

            // 1) Görev
            dgvDeleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTask",
                HeaderText = "Görev",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 14),
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                }
            });

            // 2) Tarih
            dgvDeleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDate",
                HeaderText = "Tarih",
                Width = 200,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 14),
                    Format = "g",
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // 3) Geri Al
            dgvDeleted.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colRestore",
                HeaderText = "",
                Text = "↩️",
                UseColumnTextForButtonValue = true,
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // 4) Kalıcı Sil
            dgvDeleted.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "colDelete",
                HeaderText = "",
                Text = "🗑️",
                UseColumnTextForButtonValue = true,
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = pink,
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            // Test verileri (veritabanı entegrasyonuna kadar)
            dgvDeleted.Rows.Add("Test Görev 1", DateTime.Now.AddDays(-1));
            dgvDeleted.Rows.Add("Test Görev 2", DateTime.Now.AddHours(-3));
            dgvDeleted.Rows.Add("Test Görev 3", DateTime.Now.AddDays(-2));
        }

        private async void dgvDeleted_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || tiklamaKilitli) return;

            tiklamaKilitli = true;

            string columnName = dgvDeleted.Columns[e.ColumnIndex].Name;
            string task = dgvDeleted.Rows[e.RowIndex].Cells["colTask"].Value?.ToString() ?? "";

            if (columnName == "colRestore")
            {
                MessageBox.Show($"“{task}” geri yüklendi!", "Geri Yükle",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDeleted.Rows.RemoveAt(e.RowIndex);
            }
            else if (columnName == "colDelete")
            {
                var result = MessageBox.Show($"“{task}” kalıcı olarak silinsin mi?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    dgvDeleted.Rows.RemoveAt(e.RowIndex);
                }
            }

            await Task.Delay(150); // Çift tıklama engellemek için küçük gecikme
            tiklamaKilitli = false;
        }
    }
}