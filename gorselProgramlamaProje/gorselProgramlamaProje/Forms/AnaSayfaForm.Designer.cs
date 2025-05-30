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
            btnAyarlar = new Button();
            btnPerformans = new Button();
            btnTakvim = new Button();
            btnsSilinenler = new Button();
            btnPomodoro = new Button();
            btnAnaSayfa = new Button();
            button1 = new Button();
            btnMenu = new Button();
            monthCalendar1 = new MonthCalendar();
            flpTarihler = new FlowLayoutPanel();
            flpGorevler = new FlowLayoutPanel();
            btnGunuBitir = new Button();

            SuspendLayout();

            // panelMenu
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(btnAyarlar);
            panelMenu.Controls.Add(btnPerformans);
            panelMenu.Controls.Add(btnTakvim);
            panelMenu.Controls.Add(btnsSilinenler);
            panelMenu.Controls.Add(btnPomodoro);
            panelMenu.Controls.Add(btnAnaSayfa);
            panelMenu.Controls.Add(button1);
            panelMenu.Location = new Point(0, 49);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(262, 428);
            panelMenu.Visible = true;

            // button1 = Hesaptan Çık
            button1.BackColor = Color.FromArgb(255, 192, 192);
            button1.Text = "Hesaptan Çık";
            button1.Size = new Size(160, 29);
            button1.Location = new Point(47, 379);

            // btnAyarlar
            btnAyarlar.BackColor = Color.FromArgb(255, 192, 192);
            btnAyarlar.Text = "AYARLAR";
            btnAyarlar.Size = new Size(106, 58);
            btnAyarlar.Location = new Point(68, 273);
            btnAyarlar.Click += btnAyarlar_Click;

            // btnPerformans
            btnPerformans.BackColor = Color.FromArgb(255, 192, 192);
            btnPerformans.Text = "Performans";
            btnPerformans.Size = new Size(106, 29);
            btnPerformans.Location = new Point(68, 229);
            btnPerformans.Click += btnPerformans_Click;

            // btnTakvim
            btnTakvim.BackColor = Color.FromArgb(255, 192, 192);
            btnTakvim.Text = "Takvim";
            btnTakvim.Size = new Size(106, 29);
            btnTakvim.Location = new Point(68, 194);

            // btnsSilinenler
            btnsSilinenler.BackColor = Color.FromArgb(255, 192, 192);
            btnsSilinenler.Text = "Silinenler";
            btnsSilinenler.Size = new Size(106, 29);
            btnsSilinenler.Location = new Point(68, 159);

            // btnPomodoro
            btnPomodoro.BackColor = Color.FromArgb(255, 192, 192);
            btnPomodoro.Text = "Pomodoro";
            btnPomodoro.Size = new Size(106, 29);
            btnPomodoro.Location = new Point(68, 123);

            // btnAnaSayfa
            btnAnaSayfa.BackColor = Color.Pink;
            btnAnaSayfa.Text = "Ana Sayfa";
            btnAnaSayfa.Size = new Size(106, 29);
            btnAnaSayfa.Location = new Point(68, 88);
            btnAnaSayfa.Click += btnAnaSayfa_Click;

            // btnMenu
            btnMenu.BackColor = Color.FromArgb(255, 192, 192);
            btnMenu.Text = "=";
            btnMenu.Size = new Size(45, 31);
            btnMenu.Location = new Point(12, 12);
            btnMenu.Click += btnMenu_Click;

            // monthCalendar1
            monthCalendar1.Location = new Point(0, 536);

            // flpTarihler
            flpTarihler.Location = new Point(291, 49);
            flpTarihler.Size = new Size(1000, 85);
            flpTarihler.WrapContents = false;

            // flpGorevler
            flpGorevler.AutoScroll = true;
            flpGorevler.Location = new Point(291, 150);
            flpGorevler.Size = new Size(900, 300);

            // btnGunuBitir
            btnGunuBitir.BackColor = Color.FromArgb(255, 192, 192);
            btnGunuBitir.Location = new Point(896, 692);
            btnGunuBitir.Size = new Size(161, 51);
            btnGunuBitir.Text = "Günü Bitir";

            // AnaSayfaForm
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1300, 800);
            Controls.Add(btnGunuBitir);
            Controls.Add(flpGorevler);
            Controls.Add(flpTarihler);
            Controls.Add(monthCalendar1);
            Controls.Add(btnMenu);
            Controls.Add(panelMenu);
            Name = "AnaSayfaForm";
            Text = "AnaSayfaForm";
            Load += AnaSayfaForm_Load;
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
        private Button btnTakvim;
        private Button button1;
        private MonthCalendar monthCalendar1;
        private FlowLayoutPanel flpTarihler;
        private FlowLayoutPanel flpGorevler;
        private Button btnGunuBitir;
    }
}
