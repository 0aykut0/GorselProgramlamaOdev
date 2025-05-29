namespace gorselProgramlamaProje.Forms
{
    partial class PerformansForm
    {
        private System.ComponentModel.IContainer components = null;

        private FlowLayoutPanel flpTarihler;
        private MonthCalendar monthCalendar1;
        private Panel panelMenu;
        private Button btnMenu, btnAnaSayfa, btnPomodoro, btnsSilinenler, btnTakvim, btnPerformans, btnAyarlar, button1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            flpTarihler = new FlowLayoutPanel();
            monthCalendar1 = new MonthCalendar();
            panelMenu = new Panel();
            btnMenu = new Button();
            btnAnaSayfa = new Button();
            btnPomodoro = new Button();
            btnsSilinenler = new Button();
            btnTakvim = new Button();
            btnPerformans = new Button();
            btnAyarlar = new Button();
            button1 = new Button();

            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(btnAyarlar);
            panelMenu.Controls.Add(btnPerformans);
            panelMenu.Controls.Add(btnTakvim);
            panelMenu.Controls.Add(btnsSilinenler);
            panelMenu.Controls.Add(btnPomodoro);
            panelMenu.Controls.Add(btnAnaSayfa);
            panelMenu.Location = new Point(0, 50);
            panelMenu.Size = new Size(270, 440);
            panelMenu.Visible = false;

            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(255, 192, 192);
            btnMenu.Location = new Point(10, 10);
            btnMenu.Size = new Size(45, 30);
            btnMenu.Text = "=";
            btnMenu.Click += new EventHandler(btnMenu_Click);

            // 
            // Sidebar Buttons
            // 
            btnAnaSayfa.Text = "Ana Sayfa";
            btnPomodoro.Text = "Pomodoro";
            btnsSilinenler.Text = "Silinenler";
            btnTakvim.Text = "Takvim";
            btnPerformans.Text = "Performans";
            btnAyarlar.Text = "Ayarlar";
            button1.Text = "Hesaptan Çık";

            Button[] buttons = { btnAnaSayfa, btnPomodoro, btnsSilinenler, btnTakvim, btnPerformans, btnAyarlar, button1};
            int top = 20;
            foreach (var btn in buttons)
            {
                btn.Size = new Size(120, 30);
                btn.Location = new Point(70, top);
                btn.BackColor = Color.FromArgb(255, 192, 192);
                panelMenu.Controls.Add(btn);
                top += (btn == btnAyarlar ? 60 : 40);
            }

            // 
            // flpTarihler
            // 
            flpTarihler.BackColor = Color.FromArgb(64, 64, 64);
            flpTarihler.Location = new Point(280, 40);
            flpTarihler.Size = new Size(600, 80);
            flpTarihler.WrapContents = false;

            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = Color.FromArgb(255, 192, 192);
            monthCalendar1.Location = new Point(10, 540);

            // 
            // PerformansForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1100, 750);
            Controls.Add(panelMenu);
            Controls.Add(btnMenu);
            Controls.Add(flpTarihler);
            Controls.Add(monthCalendar1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PerformansForm";
            Text = "PerformansForm";
            Load += new EventHandler(PerformansForm_Load);
            ResumeLayout(false);
        }
    }
}
