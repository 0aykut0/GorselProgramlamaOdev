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
            panelMenu.Location = new Point(0, 49);
            panelMenu.Margin = new Padding(2, 3, 2, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(233, 428);
            panelMenu.TabIndex = 5;
            // 
            // btnPerformans
            // 
            btnPerformans.BackColor = Color.FromArgb(255, 192, 192);
            btnPerformans.Location = new Point(61, 193);
            btnPerformans.Margin = new Padding(2, 3, 2, 3);
            btnPerformans.Name = "btnPerformans";
            btnPerformans.Size = new Size(94, 29);
            btnPerformans.TabIndex = 1;
            btnPerformans.Text = "Performans";
            btnPerformans.UseVisualStyleBackColor = false;
            btnPerformans.Click += btnPerformans_Click;
            // 
            // btnsSilinenler
            // 
            btnsSilinenler.BackColor = Color.FromArgb(255, 192, 192);
            btnsSilinenler.Location = new Point(61, 159);
            btnsSilinenler.Margin = new Padding(2, 3, 2, 3);
            btnsSilinenler.Name = "btnsSilinenler";
            btnsSilinenler.Size = new Size(94, 29);
            btnsSilinenler.TabIndex = 3;
            btnsSilinenler.Text = "Silinenler";
            btnsSilinenler.UseVisualStyleBackColor = false;
            btnsSilinenler.Click += btnsSilinenler_Click;
            // 
            // btnPomodoro
            // 
            btnPomodoro.BackColor = Color.FromArgb(255, 192, 192);
            btnPomodoro.Location = new Point(61, 123);
            btnPomodoro.Margin = new Padding(2, 3, 2, 3);
            btnPomodoro.Name = "btnPomodoro";
            btnPomodoro.Size = new Size(94, 29);
            btnPomodoro.TabIndex = 4;
            btnPomodoro.Text = "Pomodoro";
            btnPomodoro.UseVisualStyleBackColor = false;
            btnPomodoro.Click += btnPomodoro_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Location = new Point(42, 379);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 6;
            button1.Text = "Hesaptan Çık";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(255, 192, 192);
            btnMenu.Location = new Point(10, 12);
            btnMenu.Margin = new Padding(2, 3, 2, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(40, 31);
            btnMenu.TabIndex = 4;
            btnMenu.Text = "=";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(0, 536);
            monthCalendar1.Margin = new Padding(8, 9, 8, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            // 
            // flpTarihler
            // 
            flpTarihler.Location = new Point(258, 49);
            flpTarihler.Margin = new Padding(2, 3, 2, 3);
            flpTarihler.Name = "flpTarihler";
            flpTarihler.Size = new Size(889, 85);
            flpTarihler.TabIndex = 2;
            flpTarihler.WrapContents = false;
            // 
            // flpGorevler
            // 
            flpGorevler.AutoScroll = true;
            flpGorevler.Location = new Point(258, 149);
            flpGorevler.Margin = new Padding(2, 3, 2, 3);
            flpGorevler.Name = "flpGorevler";
            flpGorevler.Size = new Size(800, 300);
            flpGorevler.TabIndex = 1;
            // 
            // btnGunuBitir
            // 
            btnGunuBitir.BackColor = Color.FromArgb(255, 192, 192);
            btnGunuBitir.Location = new Point(797, 692);
            btnGunuBitir.Margin = new Padding(2, 3, 2, 3);
            btnGunuBitir.Name = "btnGunuBitir";
            btnGunuBitir.Size = new Size(143, 51);
            btnGunuBitir.TabIndex = 0;
            btnGunuBitir.Text = "Günü Bitir";
            btnGunuBitir.UseVisualStyleBackColor = false;
            btnGunuBitir.Click += btnGunuBitir_Click;
            // 
            // AnaSayfaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1155, 800);
            Controls.Add(btnGunuBitir);
            Controls.Add(flpGorevler);
            Controls.Add(flpTarihler);
            Controls.Add(monthCalendar1);
            Controls.Add(btnMenu);
            Controls.Add(panelMenu);
            Margin = new Padding(2, 3, 2, 3);
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
