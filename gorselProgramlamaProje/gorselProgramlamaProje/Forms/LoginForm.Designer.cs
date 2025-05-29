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
            LoginPanel.Location = new Point(393, 289);
            LoginPanel.Margin = new Padding(3, 4, 3, 4);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(455, 252);
            LoginPanel.TabIndex = 0;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(171, 72);
            txtParola.Margin = new Padding(3, 4, 3, 4);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(213, 27);
            txtParola.TabIndex = 6;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(171, 33);
            txtKullaniciAdi.Margin = new Padding(3, 4, 3, 4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(213, 27);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // lblParola
            // 
            lblParola.AutoSize = true;
            lblParola.BackColor = Color.Pink;
            lblParola.BorderStyle = BorderStyle.FixedSingle;
            lblParola.Location = new Point(75, 76);
            lblParola.Name = "lblParola";
            lblParola.Size = new Size(52, 22);
            lblParola.TabIndex = 4;
            lblParola.Text = "Parola";
            // 
            // lblKullaniciAdi
            // 
            lblKullaniciAdi.AutoSize = true;
            lblKullaniciAdi.BackColor = Color.Pink;
            lblKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            lblKullaniciAdi.Location = new Point(75, 37);
            lblKullaniciAdi.Name = "lblKullaniciAdi";
            lblKullaniciAdi.Size = new Size(97, 22);
            lblKullaniciAdi.TabIndex = 3;
            lblKullaniciAdi.Text = "Kullanıcı Adı:";
            lblKullaniciAdi.Click += lblKullaniciAdi_Click;
            // 
            // btnUyeOl
            // 
            btnUyeOl.BackColor = Color.Pink;
            btnUyeOl.Location = new Point(79, 151);
            btnUyeOl.Margin = new Padding(3, 4, 3, 4);
            btnUyeOl.Name = "btnUyeOl";
            btnUyeOl.Size = new Size(86, 31);
            btnUyeOl.TabIndex = 2;
            btnUyeOl.Text = "Üye Ol";
            btnUyeOl.UseVisualStyleBackColor = false;
            btnUyeOl.Click += btnUyeOl_Click;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Pink;
            btnGiris.Location = new Point(299, 151);
            btnGiris.Margin = new Padding(3, 4, 3, 4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(86, 31);
            btnGiris.TabIndex = 1;
            btnGiris.Text = "Giris Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1224, 861);
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
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