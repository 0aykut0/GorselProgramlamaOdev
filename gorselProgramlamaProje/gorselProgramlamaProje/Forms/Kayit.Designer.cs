namespace gorselProgramlamaProje.Forms
{
    partial class Kayit
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
            KayitPanel = new Panel();
            buttonIptal = new Button();
            btnUyeol = new Button();
            txtParola2 = new TextBox();
            txtParola = new TextBox();
            txtKullaniciAd = new TextBox();
            lblParolaDogrula = new Label();
            lblParola = new Label();
            lblKullaniciAd = new Label();
            KayitPanel.SuspendLayout();
            SuspendLayout();
            // 
            // KayitPanel
            // 
            KayitPanel.Controls.Add(buttonIptal);
            KayitPanel.Controls.Add(btnUyeol);
            KayitPanel.Controls.Add(txtParola2);
            KayitPanel.Controls.Add(txtParola);
            KayitPanel.Controls.Add(txtKullaniciAd);
            KayitPanel.Controls.Add(lblParolaDogrula);
            KayitPanel.Controls.Add(lblParola);
            KayitPanel.Controls.Add(lblKullaniciAd);
            KayitPanel.Location = new Point(336, 182);
            KayitPanel.Name = "KayitPanel";
            KayitPanel.Size = new Size(385, 179);
            KayitPanel.TabIndex = 0;
            // 
            // buttonIptal
            // 
            buttonIptal.BackColor = Color.Pink;
            buttonIptal.Location = new Point(37, 137);
            buttonIptal.Name = "buttonIptal";
            buttonIptal.Size = new Size(75, 23);
            buttonIptal.TabIndex = 7;
            buttonIptal.Text = "İPTAL";
            buttonIptal.UseVisualStyleBackColor = false;
            buttonIptal.Click += btnIptal_Click;
            // 
            // btnUyeol
            // 
            btnUyeol.BackColor = Color.Pink;
            btnUyeol.Location = new Point(257, 137);
            btnUyeol.Name = "btnUyeol";
            btnUyeol.Size = new Size(75, 23);
            btnUyeol.TabIndex = 6;
            btnUyeol.Text = "Uye Ol";
            btnUyeol.UseVisualStyleBackColor = false;
            btnUyeol.Click += btnKayit_Click;
            // 
            // txtParola2
            // 
            txtParola2.Location = new Point(136, 92);
            txtParola2.Name = "txtParola2";
            txtParola2.Size = new Size(196, 23);
            txtParola2.TabIndex = 5;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(136, 58);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(196, 23);
            txtParola.TabIndex = 4;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(136, 22);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(196, 23);
            txtKullaniciAd.TabIndex = 3;
            txtKullaniciAd.TextChanged += txtKullaniciAd_TextChanged;
            // 
            // lblParolaDogrula
            // 
            lblParolaDogrula.AutoSize = true;
            lblParolaDogrula.BackColor = Color.Pink;
            lblParolaDogrula.BorderStyle = BorderStyle.FixedSingle;
            lblParolaDogrula.Location = new Point(37, 95);
            lblParolaDogrula.Name = "lblParolaDogrula";
            lblParolaDogrula.Size = new Size(48, 17);
            lblParolaDogrula.TabIndex = 2;
            lblParolaDogrula.Text = "Parola :";
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = Color.Pink;
            lblParola.BorderStyle = BorderStyle.FixedSingle;
            lblParola.Location = new Point(37, 61);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(51, 17);
            lblParola.TabIndex = 1;
            lblParola.Text = "Parola : ";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.BackColor = Color.Pink;
            lblKullaniciAd.BorderStyle = BorderStyle.FixedSingle;
            lblKullaniciAd.Location = new Point(37, 25);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(84, 17);
            lblKullaniciAd.TabIndex = 0;
            lblKullaniciAd.Text = "Kullanıcı Adı : ";
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(900, 562);
            Controls.Add(KayitPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Kayit";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            KayitPanel.ResumeLayout(false);
            KayitPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel KayitPanel;
        private Button btnUyeol;
        private TextBox txtParola2;
        private TextBox txtParola;
        private TextBox txtKullaniciAd;
        private Label lblParolaDogrula;
        private Label lblParola;
        private Label lblKullaniciAd;
        private Button buttonIptal;
    }
}