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
            button1 = new Button();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDeleted).BeginInit();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = SystemColors.ActiveCaptionText;
            pnlContainer.BorderStyle = BorderStyle.FixedSingle;
            pnlContainer.Controls.Add(dgvDeleted);
            pnlContainer.Location = new Point(53, 40);
            pnlContainer.Margin = new Padding(3, 2, 3, 2);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(636, 298);
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
            dgvDeleted.Margin = new Padding(3, 2, 3, 2);
            dgvDeleted.Name = "dgvDeleted";
            dgvDeleted.ReadOnly = true;
            dgvDeleted.RowHeadersVisible = false;
            dgvDeleted.RowHeadersWidth = 51;
            dgvDeleted.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDeleted.Size = new Size(634, 296);
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SilinenlerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(pnlContainer);
            Margin = new Padding(3, 2, 3, 2);
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
        private Button button1;
    }
}