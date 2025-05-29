using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class PomodoroForm : Form
    {
        // ─────────────── Yeni eklenen alanlar ───────────────
        private readonly int workDuration = 1 * 60;  // 20 dk çalışma
        private readonly int breakDuration = 5 * 60;  // 5  dk mola
        private bool isOnBreak;                        // Şu anda molada mıyız?
        // ────────────────────────────────────────────────────

        private int timeLeft = 20 * 60;    // Başlangıçta 20 dk
        private bool isRunning = false;    // Sayaç çalışıyor mu?

        public PomodoroForm()
        {
            InitializeComponent();

            // event bağlamaları
            this.Load += PomodoroForm_Load;
            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
            btnStop.Click += btnStop_Click;
            timer1.Tick += timer1_Tick;
        }

        private void PomodoroForm_Load(object? sender, EventArgs e)
        {
            // ─────────────── Yeni başlangıç atamaları ───────────────
            isOnBreak = false;
            timeLeft = workDuration;
            isRunning = false;
            // ─────────────────────────────────────────────────────────

            // pnlTimer’ı daireye çevirme ve ilk etiketi güncelleme
            var path = new GraphicsPath();
            path.AddEllipse(0, 0, pnlTimer.Width, pnlTimer.Height);
            pnlTimer.Region = new Region(path);
            UpdateLabel();
        }

        private void UpdateLabel()
        {
            var ts = TimeSpan.FromSeconds(timeLeft);
            lblTime.Text = ts.ToString(@"mm\:ss");
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            if (!isRunning)
            {
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

            // ─────────────── Reset her zaman çalışma moduna ───────────────
            isOnBreak = false;
            timeLeft = workDuration;
            // ────────────────────────────────────────────────────────────────

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
                // Süre doldu, mod değiştir
                isOnBreak = !isOnBreak;
                timeLeft = isOnBreak ? breakDuration : workDuration;

                // Kullanıcıya bilgi ver (isteğe bağlı)
                if (isOnBreak)
                    MessageBox.Show("Çalışma süresi doldu! Mola başlıyor.",
                                    "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Mola bitti! Çalışma zamanı.",
                                    "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Sayaç devam etsin
                UpdateLabel();
                timer1.Start();
                isRunning = true;
            }
        }
    }
}
