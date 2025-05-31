using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Media;
using gorselProgramlamaProje.Managers;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Forms
{
    public partial class PomodoroForm : Form
    {
        private readonly int shortTime = 1 * 60;
        private readonly int mediumTime = 25 * 60;
        private readonly int longTime = 45 * 60;
        private readonly int breakDuration = 5 * 60;

        private int workDuration;
        private int timeLeft;
        private bool isRunning = false;
        private bool isOnBreak = false;

        private DateTime currentDate;    // O günün tarihi
        private int currentUserId;       // O anki kullanıcı

        private Form anaSayfaForm; // REFERANS

        // Müzik için
        private SoundPlayer? player;
        private bool isMuted = false;
        public PomodoroForm(Form geriDonulecekForm)
        {
            InitializeComponent();
            anaSayfaForm = geriDonulecekForm;

            // “O anki kullanıcı” ve “tarih” bilgilerini alalım
            currentUserId = SessionManager.CurrentUserId;
            currentDate = DateTime.Today;

            this.Load += PomodoroForm_Load;

            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
            btnStop.Click += btnStop_Click;

            rdoShort.CheckedChanged += RadioButton_CheckedChanged;
            rdoMedium.CheckedChanged += RadioButton_CheckedChanged;
            rdoLong.CheckedChanged += RadioButton_CheckedChanged;

            timer1.Tick += timer1_Tick;
            // Müzik başlat
            try
            {
                player = new SoundPlayer(@"C:\\Users\\esmah\\OneDrive\\Desktop\\GorselProgramlamaOdev\\gorselProgramlamaProje\\gorselProgramlamaProje\\assets\\music.wav");
                player = new SoundPlayer(@"C:\Users\mayku\Desktop\pomodoro\GorselProgramlamaOdev\gorselProgramlamaProje\gorselProgramlamaProje\assets\music.wav");
                player.PlayLooping();
            }
            catch
            {
                MessageBox.Show("focus.wav dosyası bulunamadı veya açılamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PomodoroForm_Load(object? sender, EventArgs e)
        {
            isOnBreak = false;
            workDuration = GetSelectedWorkDuration();
            timeLeft = workDuration;
            isRunning = false;

            var path = new GraphicsPath();
            path.AddEllipse(0, 0, pnlTimer.Width, pnlTimer.Height);
            pnlTimer.Region = new Region(path);

            UpdateLabel();
        }

        private int GetSelectedWorkDuration()
        {
            if (rdoShort.Checked)
                return shortTime;
            else if (rdoMedium.Checked)
                return mediumTime;
            else if (rdoLong.Checked)
                return longTime;
            else
                return mediumTime;
        }

        private void UpdateLabel()
        {
            var ts = TimeSpan.FromSeconds(timeLeft);
            lblTime.Text = ts.ToString(@"mm\:ss");
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (isRunning) return;

            workDuration = GetSelectedWorkDuration();
            timeLeft = workDuration;
            UpdateLabel();
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            if (!isRunning)
            {
                workDuration = GetSelectedWorkDuration();
                if (!isOnBreak)
                    timeLeft = workDuration;

                timer1.Start();
                isRunning = true;
            }
        }

        private void btnPause_Click(object? sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                isRunning = false;
            }
        }

        private void btnStop_Click(object? sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
            isOnBreak = false;

            workDuration = GetSelectedWorkDuration();
            timeLeft = workDuration;

            UpdateLabel();
        }

        private void timer1_Tick(object? sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateLabel();
            }
            else
            {
                // (A) Önceki durum kaydediliyor
                bool wasOnBreak = isOnBreak;

                // (B) Şimdi isOnBreak toggle ediliyor
                isOnBreak = !isOnBreak;

                // (C) Eğer önceki durumda “mola” değilse (yani work session bitti), ekleme yap
                if (!wasOnBreak && isOnBreak)
                {
                    // workDuration saniye cinsindeyse, dakikaya çevirelim:
                    int eklenecekDakika = workDuration / 60;

                    // Şimdi ilgili tarihe ve kullanıcıya göre DB’ye ekleme yap:
                    GunlukOzetManager.AddPomodoroDakikaByDate(
                        kullaniciId: currentUserId,
                        tarih: currentDate,
                        eklenecekDakika: eklenecekDakika
                    );
                }

                // (D) Zamanlayıcıyı mola / yeniden work session olarak ayarlama
                timeLeft = isOnBreak ? breakDuration : GetSelectedWorkDuration();

                MessageBox.Show(
                    isOnBreak ? "Çalışma süresi doldu! Mola başlıyor."
                              : "Mola bitti! Çalışma zamanı.",
                    "Pomodoro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                UpdateLabel();
                timer1.Start();
                isRunning = true;
            }
        }

        // “Geri” butonuna tıklanınca
        private void button1_Click_1(object sender, EventArgs e)
        {
            anaSayfaForm.Show(); // AnaSayfaForm tekrar gösterilir
            this.Close();        // PomodoroForm kapanır
        }
    }
}
