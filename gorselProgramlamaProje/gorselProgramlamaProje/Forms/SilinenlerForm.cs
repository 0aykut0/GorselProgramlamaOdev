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


using gorselProgramlamaProje.Models;

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
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Bu formu kapat
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
            dgvDeleted.DefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#add8e6");
            dgvDeleted.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvDeleted.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colId",
                HeaderText = "Id",
                Visible = false
            });

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

            // 🔄 Veritabanından veri çek
            int userId = SessionManager.CurrentUserId;
            var silinenler = SilinenGorevManager.SilinenGorevleriGetir(userId);

            foreach (var gorev in silinenler)
            {
                dgvDeleted.Rows.Add(gorev.Id, gorev.Baslik, gorev.OlusturmaTarihi);
            }
        }

        private async void dgvDeleted_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || tiklamaKilitli) return;

            tiklamaKilitli = true;

            string columnName = dgvDeleted.Columns[e.ColumnIndex].Name;
            int gorevId = Convert.ToInt32(dgvDeleted.Rows[e.RowIndex].Cells["colId"].Value);
            string task = dgvDeleted.Rows[e.RowIndex].Cells["colTask"].Value?.ToString() ?? "";

            if (columnName == "colRestore")
            {
                SilinenGorevManager.GoreviGeriAl(gorevId);
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
                    SilinenGorevManager.GoreviKaliciSil(gorevId);
                    dgvDeleted.Rows.RemoveAt(e.RowIndex);
                }
            }

            await Task.Delay(150);
            tiklamaKilitli = false;
        }
    }
}
