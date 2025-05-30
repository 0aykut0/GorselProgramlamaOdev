namespace gorselProgramlamaProje.Forms
{
    partial class AnaSayfaForm
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
            panelMenu = new Panel();
            button1 = new Button();
            btnPerformans = new Button();
            btnsSilinenler = new Button();
            btnPomodoro = new Button();
            btnMenu = new Button();
            monthCalendar1 = new MonthCalendar();
            flpTarihler = new FlowLayoutPanel();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            flpGorevler = new FlowLayoutPanel();
            btnGunuBitir = new Button();
            panelMenu.SuspendLayout();
            flpTarihler.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnPerformans);
            panelMenu.Controls.Add(btnsSilinenler);
            panelMenu.Controls.Add(btnPomodoro);
            panelMenu.Location = new Point(0, 49);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(262, 428);
            panelMenu.TabIndex = 0;
            panelMenu.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(68, 380);
            button1.Name = "button1";
            button1.Size = new Size(160, 29);
            button1.TabIndex = 6;
            button1.Text = "Hesaptan Çık";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnPerformans
            // 
            btnPerformans.BackColor = Color.FromArgb(255, 192, 192);
            btnPerformans.Location = new Point(68, 194);
            btnPerformans.Name = "btnPerformans";
            btnPerformans.Size = new Size(139, 29);
            btnPerformans.TabIndex = 4;
            btnPerformans.Text = "Performans Takibi";
            btnPerformans.UseVisualStyleBackColor = false;
            btnPerformans.Click += btnPerformans_Click;
            // 
            // btnsSilinenler
            // 
            btnsSilinenler.BackColor = Color.FromArgb(255, 192, 192);
            btnsSilinenler.Location = new Point(68, 159);
            btnsSilinenler.Name = "btnsSilinenler";
            btnsSilinenler.Size = new Size(139, 29);
            btnsSilinenler.TabIndex = 2;
            btnsSilinenler.Text = "Silinenler";
            btnsSilinenler.UseVisualStyleBackColor = false;
            btnsSilinenler.Click += btnsSilinenler_Click;
            // 
            // btnPomodoro
            // 
            btnPomodoro.BackColor = Color.FromArgb(255, 192, 192);
            btnPomodoro.Location = new Point(68, 123);
            btnPomodoro.Name = "btnPomodoro";
            btnPomodoro.Size = new Size(139, 29);
            btnPomodoro.TabIndex = 1;
            btnPomodoro.Text = "Pomodoro";
            btnPomodoro.UseVisualStyleBackColor = false;
            btnPomodoro.Click += btnPomodoro_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(255, 192, 192);
            btnMenu.Location = new Point(12, 12);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(45, 31);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "=";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.FromArgb(255, 192, 192);
            monthCalendar1.ForeColor = Color.FromArgb(255, 192, 192);
            monthCalendar1.Location = new Point(0, 536);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 2;
            monthCalendar1.TitleBackColor = Color.FromArgb(255, 192, 192);
            monthCalendar1.TitleForeColor = Color.FromArgb(255, 192, 192);
            monthCalendar1.TrailingForeColor = Color.FromArgb(255, 192, 192);
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // flpTarihler
            // 
            flpTarihler.BackColor = Color.FromArgb(64, 64, 64);
            flpTarihler.Controls.Add(button2);
            flpTarihler.Controls.Add(button3);
            flpTarihler.Controls.Add(button4);
            flpTarihler.Controls.Add(button5);
            flpTarihler.Controls.Add(button6);
            flpTarihler.Controls.Add(button7);
            flpTarihler.Controls.Add(button8);
            flpTarihler.Location = new Point(291, 49);
            flpTarihler.Name = "flpTarihler";
            flpTarihler.Size = new Size(584, 74);
            flpTarihler.TabIndex = 3;
            flpTarihler.WrapContents = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(113, 55);
            button2.TabIndex = 0;
            button2.Text = "BUGÜN";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Location = new Point(122, 3);
            button3.Name = "button3";
            button3.Size = new Size(64, 55);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(192, 3);
            button4.Name = "button4";
            button4.Size = new Size(76, 55);
            button4.TabIndex = 2;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(274, 3);
            button5.Name = "button5";
            button5.Size = new Size(75, 54);
            button5.TabIndex = 3;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(355, 3);
            button6.Name = "button6";
            button6.Size = new Size(71, 55);
            button6.TabIndex = 4;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(432, 3);
            button7.Name = "button7";
            button7.Size = new Size(69, 55);
            button7.TabIndex = 5;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(507, 3);
            button8.Name = "button8";
            button8.Size = new Size(66, 55);
            button8.TabIndex = 6;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // flpGorevler
            // 
            flpGorevler.AutoScroll = true;
            flpGorevler.BackColor = Color.FromArgb(64, 64, 64);
            flpGorevler.Location = new Point(291, 163);
            flpGorevler.Name = "flpGorevler";
            flpGorevler.Size = new Size(584, 314);
            flpGorevler.TabIndex = 4;
            flpGorevler.Paint += flpGorevler_Paint;
            // 
            // btnGunuBitir
            // 
            btnGunuBitir.BackColor = Color.FromArgb(255, 192, 192);
            btnGunuBitir.Font = new Font("Segoe UI Variable Small", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGunuBitir.Location = new Point(896, 692);
            btnGunuBitir.Name = "btnGunuBitir";
            btnGunuBitir.Size = new Size(161, 51);
            btnGunuBitir.TabIndex = 5;
            btnGunuBitir.Text = "Günü Bitir";
            btnGunuBitir.UseVisualStyleBackColor = false;
            btnGunuBitir.Click += btnGunuBitir_Click;
            // 
            // AnaSayfaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1028, 749);
            Controls.Add(btnGunuBitir);
            Controls.Add(flpGorevler);
            Controls.Add(flpTarihler);
            Controls.Add(monthCalendar1);
            Controls.Add(btnMenu);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI Variable Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlLightLight;
            Name = "AnaSayfaForm";
            Text = "AnaSayfaForm";
            Load += AnaSayfaForm_Load;
            panelMenu.ResumeLayout(false);
            flpTarihler.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnMenu;
        private Button btnsSilinenler;
        private Button btnPomodoro;
        private Button btnAnaSayfa;
        private Button btnAyarlar;
        private Button btnPerformans;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private FlowLayoutPanel flpTarihler;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private FlowLayoutPanel flpGorevler;
        private Button btnGunuBitir;
    }
}