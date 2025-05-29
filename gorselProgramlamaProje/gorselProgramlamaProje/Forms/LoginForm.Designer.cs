namespace gorselProgramlamaProje.Forms
{
    partial class LoginForm
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
            LoginPanel = new Panel();
            txtParola = new TextBox();
            txtKullaniciAdi = new TextBox();
            lblParola = new Label();
            lblKullaniciAdi = new Label();
            btnUyeOl = new Button();
            btnGiris = new Button();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(txtParola);
            LoginPanel.Controls.Add(txtKullaniciAdi);
            LoginPanel.Controls.Add(lblParola);
            LoginPanel.Controls.Add(lblKullaniciAdi);
            LoginPanel.Controls.Add(btnUyeOl);
            LoginPanel.Controls.Add(btnGiris);
            LoginPanel.Location = new Point(344, 217);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(398, 189);
            LoginPanel.TabIndex = 0;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(150, 54);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(187, 23);
            txtParola.TabIndex = 6;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(150, 25);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(187, 23);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = Color.Pink;
            lblParola.BorderStyle = BorderStyle.FixedSingle;
            lblParola.Location = new Point(66, 57);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(42, 17);
            lblParola.TabIndex = 4;
            lblParola.Text = "Parola";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.Pink;
            lblKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            lblKullaniciAdi.Location = new Point(66, 28);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(78, 17);
            lblKullaniciAdi.TabIndex = 3;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            lblKullaniciAdi.Click += lblKullaniciAdi_Click;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = Color.Pink;
            btnUyeOl.Location = new Point(69, 113);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(75, 23);
            btnUyeOl.TabIndex = 2;
            btnUyeOl.Text = "Üye Ol";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Pink;
            btnGiris.Location = new Point(262, 113);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(75, 23);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giris Yap";
            btnGiris.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1071, 646);
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Button btnGiris;
        private TextBox txtParola;
        private TextBox txtKullaniciAdi;
        private Label lblParola;
        private Label lblKullaniciAdi;
        private Button btnUyeOl;
    }
}