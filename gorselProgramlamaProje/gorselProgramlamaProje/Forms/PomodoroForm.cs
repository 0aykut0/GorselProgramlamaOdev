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

using System;
using System.Drawing;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class PomodoroForm : Form
    {
        // Süreler
        private readonly int shortTime = 10 * 60;
        private readonly int mediumTime = 25 * 60;
        private readonly int longTime = 45 * 60;
        private readonly int breakDuration = 5 * 60;

        private int workDuration;    // Seçilen süre
        private int timeLeft;        // Geri sayım süresi
        private bool isRunning = false;
        private bool isOnBreak = false;

        public PomodoroForm()
        {
            InitializeComponent();

            this.Load += PomodoroForm_Load;

            btnStart.Click += btnStart_Click;
            btnPause.Click += btnPause_Click;
            btnStop.Click += btnStop_Click;

            rdoShort.CheckedChanged += RadioButton_CheckedChanged;
            rdoMedium.CheckedChanged += RadioButton_CheckedChanged;
            rdoLong.CheckedChanged += RadioButton_CheckedChanged;

            timer1.Tick += timer1_Tick;
        }

        private void PomodoroForm_Load(object? sender, EventArgs e)
        {
            // Başlangıç sürelerini ayarla
            isOnBreak = false;
            workDuration = GetSelectedWorkDuration();
            timeLeft = workDuration;
            isRunning = false;

            // Daire görünümlü panel
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
                return mediumTime; // Varsayılan
        }

        private void UpdateLabel()
        {
            var ts = TimeSpan.FromSeconds(timeLeft);
            lblTime.Text = ts.ToString(@"mm\:ss");
        }

        private void RadioButton_CheckedChanged(object? sender, EventArgs e)
        {
            if (isRunning) return; // Sayaç çalışıyorsa değiştirme

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
                isOnBreak = !isOnBreak;
                timeLeft = isOnBreak ? breakDuration : GetSelectedWorkDuration();

                MessageBox.Show(
                    isOnBreak ? "Çalışma süresi doldu! Mola başlıyor." : "Mola bitti! Çalışma zamanı.",
                    "Pomodoro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                UpdateLabel();
                timer1.Start();
                isRunning = true;
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var ana = new AnaSayfaForm();
            ana.Show();
        }
    }
    
}