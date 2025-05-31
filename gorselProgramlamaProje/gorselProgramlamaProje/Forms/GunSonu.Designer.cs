namespace gorselProgramlamaProje.Forms
{
    partial class GunSonu
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
            pnlHeader = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            lblSure = new Label();
            lblYapilanGorev = new Label();
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(189, 16);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(373, 83);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.Pink;
            lblTitle.Location = new Point(34, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(311, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GÜN SONU RAPORU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Pink;
            label1.Location = new Point(3, 32);
            label1.Name = "label1";
            label1.Size = new Size(202, 37);
            label1.TabIndex = 1;
            label1.Text = "Çalışılan Süre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Pink;
            label2.Location = new Point(3, 125);
            label2.Name = "label2";
            label2.Size = new Size(279, 37);
            label2.TabIndex = 2;
            label2.Text = "Tamamlanan Görev: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblYapilanGorev);
            panel1.Controls.Add(lblSure);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(79, 139);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 195);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(592, 368);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 4;
            button1.Text = "BİTİR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.BackColor = Color.DarkSlateBlue;
            lblSure.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSure.ForeColor = Color.White;
            lblSure.Location = new Point(279, 32);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(202, 37);
            lblSure.TabIndex = 3;
            lblSure.Text = "Çalışılan Süre :";
            // 
            // lblYapilanGorev
            // 
            lblYapilanGorev.AutoSize = true;
            lblYapilanGorev.BackColor = Color.DarkSlateBlue;
            lblYapilanGorev.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblYapilanGorev.ForeColor = SystemColors.HighlightText;
            lblYapilanGorev.Location = new Point(279, 125);
            lblYapilanGorev.Name = "lblYapilanGorev";
            lblYapilanGorev.Size = new Size(279, 37);
            lblYapilanGorev.TabIndex = 4;
            lblYapilanGorev.Text = "Tamamlanan Görev: ";
            // 
            // GunSonu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(717, 451);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GunSonu";
            Text = "Form1";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button button1;
        private Label lblYapilanGorev;
        private Label lblSure;
    }
}