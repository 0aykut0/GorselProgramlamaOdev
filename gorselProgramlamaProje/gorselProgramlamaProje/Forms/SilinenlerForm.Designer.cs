namespace gorselProgramlamaProje.Forms
{
    partial class SilinenlerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pnlContainer = new Panel();
            dgvDeleted = new DataGridView();
            colTask = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colDelete = new DataGridViewButtonColumn();
            colRestore = new DataGridViewButtonColumn();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleted).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.ActiveCaptionText;
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Controls.Add(dgvDeleted);
            pnlContainer.Location = new Point(61, 54);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(727, 396);
            pnlContainer.TabIndex = 0;
            // 
            // dgvDeleted
            // 
            dgvDeleted.AllowUserToAddRows = false;
            dgvDeleted.BackgroundColor = SystemColors.ActiveCaptionText;
            dgvDeleted.BorderStyle = BorderStyle.None;
            dgvDeleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeleted.Columns.AddRange(new DataGridViewColumn[] { colTask, colDate, colDelete, colRestore });
            dgvDeleted.Dock = DockStyle.Fill;
            dgvDeleted.Location = new Point(0, 0);
            dgvDeleted.Name = "dgvDeleted";
            dgvDeleted.ReadOnly = true;
            dgvDeleted.RowHeadersVisible = false;
            dgvDeleted.RowHeadersWidth = 51;
            dgvDeleted.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeleted.Size = new Size(725, 394);
            dgvDeleted.TabIndex = 0;
            dgvDeleted.CellContentClick += dgvDeleted_CellContentClick;
            // 
            // colTask
            // 
            dataGridViewCellStyle1.BackColor = Color.Pink;
            dataGridViewCellStyle1.SelectionBackColor = Color.Pink;
            colTask.DefaultCellStyle = dataGridViewCellStyle1;
            colTask.HeaderText = "Görev";
            colTask.MinimumWidth = 6;
            colTask.Name = "colTask";
            colTask.ReadOnly = true;
            colTask.Width = 125;
            // 
            // colDate
            // 
            dataGridViewCellStyle2.BackColor = Color.Pink;
            colDate.DefaultCellStyle = dataGridViewCellStyle2;
            colDate.HeaderText = "Tarih";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            colDate.Width = 125;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Resizable = DataGridViewTriState.True;
            colDelete.Text = "Sil";
            colDelete.Width = 80;
            // 
            // colRestore
            // 
            colRestore.HeaderText = "";
            colRestore.MinimumWidth = 6;
            colRestore.Name = "colRestore";
            colRestore.ReadOnly = true;
            colRestore.Resizable = DataGridViewTriState.True;
            colRestore.Text = "Geri Yükle ";
            colRestore.Width = 80;
            // 
            // SilinenlerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContainer);
            Name = "SilinenlerForm";
            Text = "SilinenlerForm";
            pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDeleted).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private DataGridView dgvDeleted;
        private DataGridViewTextBoxColumn colTask;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewButtonColumn colDelete;
        private DataGridViewButtonColumn colRestore;
    }
}