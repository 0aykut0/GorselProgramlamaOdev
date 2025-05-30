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
            pnlHeader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(165, 12);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(326, 62);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTitle.ForeColor = Color.Pink;
            lblTitle.Location = new Point(41, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(247, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GÜN SONU RAPORU";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Pink;
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Çalışılan Süre :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Pink;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 2;
            label2.Text = "Tamamlanan Görev Sayısı: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(165, 90);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 87);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(518, 276);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "BİTİR";
            button1.UseVisualStyleBackColor = true;
            // 
            // GunSonu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(627, 338);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            ForeColor = SystemColors.ControlLightLight;
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
    }
}