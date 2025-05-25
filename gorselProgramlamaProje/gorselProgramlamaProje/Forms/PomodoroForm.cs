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
        // 1️⃣ Alanlar (Fields)
        private int timeLeft = 20 * 60;    // Başlangıçta 20 dakika (saniye cinsinden)
        private bool isRunning = false;    // Sayaç çalışıyor mu?

        // 2️⃣ Kurucu (Constructor)
        public PomodoroForm()
        {
            InitializeComponent();  // Designer tarafından oluşturulan kontrolleri ekler

            // Olayları (event) bağla
            this.Load += PomodoroForm_Load;
            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
            btnStop.Click += btnStop_Click;
            timer1.Tick += timer1_Tick;
        }

        // 3️⃣ Form Yüklendiğinde — Paneli daire yap ve label'ı güncelle
        private void PomodoroForm_Load(object? sender, EventArgs e)
        {
            // pnlTimer panelini runtime’da daire yap
            var path = new GraphicsPath();
            path.AddEllipse(0, 0, pnlTimer.Width, pnlTimer.Height);
            pnlTimer.Region = new Region(path);

            // Ekrandaki saati göster
            UpdateLabel();
        }

        // 4️⃣ Label Güncelleme Metodu — timeLeft’e göre “mm:ss” formatı
        private void UpdateLabel()
        {
            var ts = TimeSpan.FromSeconds(timeLeft);
            lblTime.Text = ts.ToString(@"mm\:ss");
        }

        // 5️⃣ Başlat Butonu
        private void btnStart_Click(object? sender, EventArgs e)
        {
            if (!isRunning)
            {
                timer1.Start();
                isRunning = true;
            }
        }

        // 6️⃣ Duraklat Butonu
        private void btnPause_Click(object? sender, EventArgs e)
        {
            if (isRunning)
            {
                timer1.Stop();
                isRunning = false;
            }
        }

        // 7️⃣ Sıfırla Butonu
        private void btnStop_Click(object? sender, EventArgs e)
        {
            timer1.Stop();
            isRunning = false;
            timeLeft = 20 * 60;    // Yeniden 20 dakikaya al
            UpdateLabel();
        }

        // 8️⃣ Timer’ın Her “Tick” Olayı (1 saniyede bir tetiklenir)
        private void timer1_Tick(object? sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateLabel();
            }
            else
            {
                // Süre dolunca durdur ve uyarı ver
                timer1.Stop();
                isRunning = false;
                MessageBox.Show("Süre doldu!", "Pomodoro",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lblTime_FontChanged(object sender, EventArgs e)
        {

        }
    }
}