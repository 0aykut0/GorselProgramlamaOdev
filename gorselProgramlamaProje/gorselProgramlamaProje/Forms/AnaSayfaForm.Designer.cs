// AnaSayfaForm.Designer.cs — SOL PANEL (panelMenu) GÖRÜNÜR HALE GETİRİLDİ

namespace gorselProgramlamaProje.Forms
{
    partial class AnaSayfaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnPerformans = new Button();
            btnsSilinenler = new Button();
            btnPomodoro = new Button();
            button1 = new Button();
            btnMenu = new Button();
            monthCalendar1 = new MonthCalendar();
            flpTarihler = new FlowLayoutPanel();
            flpGorevler = new FlowLayoutPanel();
            btnGunuBitir = new Button();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(btnPerformans);
            panelMenu.Controls.Add(btnsSilinenler);
            panelMenu.Controls.Add(btnPomodoro);
            panelMenu.Controls.Add(button1);
            panelMenu.Location = new Point(0, 37);
            panelMenu.Margin = new Padding(2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(204, 321);
            panelMenu.TabIndex = 5;
            // 
            // btnPerformans
            // 
            btnPerformans.BackColor = Color.FromArgb(255, 192, 192);
            btnPerformans.Location = new Point(53, 145);
            btnPerformans.Margin = new Padding(2);
            btnPerformans.Name = "btnPerformans";
            btnPerformans.Size = new Size(82, 22);
            btnPerformans.TabIndex = 1;
            btnPerformans.Text = "Performans";
            btnPerformans.UseVisualStyleBackColor = false;
            btnPerformans.Click += btnPerformans_Click;
            // 
            // btnsSilinenler
            // 
            btnsSilinenler.BackColor = Color.FromArgb(255, 192, 192);
            btnsSilinenler.Location = new Point(53, 119);
            btnsSilinenler.Margin = new Padding(2);
            btnsSilinenler.Name = "btnsSilinenler";
            btnsSilinenler.Size = new Size(82, 22);
            btnsSilinenler.TabIndex = 3;
            btnsSilinenler.Text = "Silinenler";
            btnsSilinenler.UseVisualStyleBackColor = false;
            btnsSilinenler.Click += btnsSilinenler_Click;
            // 
            // btnPomodoro
            // 
            btnPomodoro.BackColor = Color.FromArgb(255, 192, 192);
            btnPomodoro.Location = new Point(53, 92);
            btnPomodoro.Margin = new Padding(2);
            btnPomodoro.Name = "btnPomodoro";
            btnPomodoro.Size = new Size(82, 22);
            btnPomodoro.TabIndex = 4;
            btnPomodoro.Text = "Pomodoro";
            btnPomodoro.UseVisualStyleBackColor = false;
            btnPomodoro.Click += btnPomodoro_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(37, 284);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(124, 22);
            button1.TabIndex = 6;
            button1.Text = "Hesaptan Çık";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(255, 192, 192);
            btnMenu.Location = new Point(9, 9);
            btnMenu.Margin = new Padding(2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(35, 23);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "=";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(0, 402);
            monthCalendar1.Margin = new Padding(7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // flpTarihler
            // 
            flpTarihler.Location = new Point(226, 37);
            flpTarihler.Margin = new Padding(2);
            flpTarihler.Name = "flpTarihler";
            flpTarihler.Size = new Size(778, 64);
            flpTarihler.TabIndex = 2;
            flpTarihler.WrapContents = false;
            // 
            // flpGorevler
            // 
            flpGorevler.AutoScroll = true;
            flpGorevler.Location = new Point(226, 112);
            flpGorevler.Margin = new Padding(2);
            flpGorevler.Name = "flpGorevler";
            flpGorevler.Size = new Size(700, 225);
            flpGorevler.TabIndex = 1;
            // 
            // btnGunuBitir
            // 
            btnGunuBitir.BackColor = Color.FromArgb(255, 192, 192);
            btnGunuBitir.Location = new Point(697, 519);
            btnGunuBitir.Margin = new Padding(2);
            btnGunuBitir.Name = "btnGunuBitir";
            btnGunuBitir.Size = new Size(125, 38);
            btnGunuBitir.TabIndex = 0;
            btnGunuBitir.Text = "Günü Bitir";
            btnGunuBitir.UseVisualStyleBackColor = false;
            btnGunuBitir.Click += btnGunuBitir_Click;
            // 
            // AnaSayfaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1011, 600);
            Controls.Add(btnGunuBitir);
            Controls.Add(flpGorevler);
            Controls.Add(flpTarihler);
            Controls.Add(monthCalendar1);
            Controls.Add(btnMenu);
            Controls.Add(panelMenu);
            Margin = new Padding(2);
            Name = "AnaSayfaForm";
            Text = "AnaSayfaForm";
            Load += AnaSayfaForm_Load;
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnMenu;
        private Button btnsSilinenler;
        private Button btnPomodoro;
        private Button btnPerformans;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private FlowLayoutPanel flpTarihler;
        private FlowLayoutPanel flpGorevler;
        private Button btnGunuBitir;
    }
}
