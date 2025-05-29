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
            btnUyeol = new Button();
            txtParola2 = new TextBox();
            txtParola = new TextBox();
            txtKullaniciAd = new TextBox();
            lblParolaDogrula = new Label();
            lblParola = new Label();
            lblKullaniciAd = new Label();
            buttonIptal = new Button();
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
            KayitPanel.Location = new Point(384, 243);
            KayitPanel.Margin = new Padding(3, 4, 3, 4);
            KayitPanel.Name = "KayitPanel";
            KayitPanel.Size = new Size(440, 239);
            KayitPanel.TabIndex = 0;
            // 
            // btnUyeol
            // 
            btnUyeol.BackColor = Color.Pink;
            btnUyeol.Location = new Point(294, 183);
            btnUyeol.Margin = new Padding(3, 4, 3, 4);
            btnUyeol.Name = "btnUyeol";
            btnUyeol.Size = new Size(86, 31);
            btnUyeol.TabIndex = 6;
            btnUyeol.Text = "Uye Ol";
            btnUyeol.UseVisualStyleBackColor = false;
            btnUyeol.Click += btnKayit_Click;
            // 
            // txtParola2
            // 
            txtParola2.Location = new Point(155, 123);
            txtParola2.Margin = new Padding(3, 4, 3, 4);
            txtParola2.Name = "txtParola2";
            txtParola2.Size = new Size(223, 27);
            txtParola2.TabIndex = 5;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(155, 77);
            txtParola.Margin = new Padding(3, 4, 3, 4);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(223, 27);
            txtParola.TabIndex = 4;
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(155, 29);
            txtKullaniciAd.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(223, 27);
            txtKullaniciAd.TabIndex = 3;
            txtKullaniciAd.TextChanged += txtKullaniciAd_TextChanged;
            // 
            // lblParolaDogrula
            // 
            lblParolaDogrula.AutoSize = true;
            lblParolaDogrula.BackColor = Color.Pink;
            lblParolaDogrula.BorderStyle = BorderStyle.FixedSingle;
            lblParolaDogrula.Location = new Point(42, 127);
            lblParolaDogrula.Name = "lblParolaDogrula";
            lblParolaDogrula.Size = new Size(59, 22);
            lblParolaDogrula.TabIndex = 2;
            lblParolaDogrula.Text = "Parola :";
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = Color.Pink;
            lblParola.BorderStyle = BorderStyle.FixedSingle;
            lblParola.Location = new Point(42, 81);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(63, 22);
            lblParola.TabIndex = 1;
            lblParola.Text = "Parola : ";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.BackColor = Color.Pink;
            lblKullaniciAd.BorderStyle = BorderStyle.FixedSingle;
            lblKullaniciAd.Location = new Point(42, 33);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(105, 22);
            lblKullaniciAd.TabIndex = 0;
            lblKullaniciAd.Text = "Kullanıcı Adı : ";
            // 
            // buttonIptal
            // 
            buttonIptal.BackColor = Color.Pink;
            buttonIptal.Location = new Point(42, 183);
            buttonIptal.Margin = new Padding(3, 4, 3, 4);
            buttonIptal.Name = "buttonIptal";
            buttonIptal.Size = new Size(86, 31);
            buttonIptal.TabIndex = 7;
            buttonIptal.Text = "İPTAL";
            buttonIptal.UseVisualStyleBackColor = false;
            buttonIptal.Click += btnIptal_Click;
            // 
            // Kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1125, 881);
            Controls.Add(KayitPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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