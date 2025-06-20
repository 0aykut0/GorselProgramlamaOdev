﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Media;
using System.Windows.Forms;
using gorselProgramlamaProje.Managers;
using gorselProgramlamaProje.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace gorselProgramlamaProje.Forms
{
    public partial class PomodoroForm : Form
    {
        private readonly int shortTime = 1 * 10;
        private readonly int mediumTime = 25 * 60;
        private readonly int longTime = 45 * 60;
        private readonly int breakDuration = 5 * 60;

        private int workDuration;
        private int timeLeft;
        private bool isRunning = false;
        private bool isOnBreak = false;

        private DateTime currentDate;
        private int currentUserId;
        private Form anaSayfaForm;

        private SoundPlayer? player;
        private bool isMuted = true;

        public PomodoroForm(Form geriDonulecekForm)
        {
            InitializeComponent();
            anaSayfaForm = geriDonulecekForm;

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
            btnMusic.Click += btnMusic_Click;
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

            btnMusic.Text = "🔇"; // Sessiz ikon
            UpdateLabel();
        }

        private int GetSelectedWorkDuration()
        {
            if (rdoShort.Checked) return shortTime;
            else if (rdoMedium.Checked) return mediumTime;
            else if (rdoLong.Checked) return longTime;
            else return mediumTime;
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
                if (!isOnBreak) timeLeft = workDuration;
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
                bool wasOnBreak = isOnBreak;
                isOnBreak = !isOnBreak;

                if (!wasOnBreak && isOnBreak)
                {
                    int eklenecekDakika = workDuration / 60;
                    GunlukOzetManager.AddPomodoroDakikaByDate(currentUserId, currentDate, eklenecekDakika);
                }

                timeLeft = isOnBreak ? breakDuration : GetSelectedWorkDuration();

                MessageBox.Show(
                    isOnBreak ? "Çalışma süreci bitti! Mola başlıyor." : "Mola bitti! Çalışma başlıyor.",
                    "Pomodoro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                UpdateLabel();
                timer1.Start();
                isRunning = true;
            }
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\mayku\Desktop\pomodoro\GorselProgramlamaOdev\gorselProgramlamaProje\gorselProgramlamaProje\assets\focus.wav";

            if (player == null)
                player = new SoundPlayer(path);

            if (isMuted)
            {
                try
                {
                    player.PlayLooping();
                    isMuted = false;
                    btnMusic.Text = "🎵";
                }
                catch
                {
                    MessageBox.Show("focus.wav dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                player.Stop();
                isMuted = true;
                btnMusic.Text = "🔇";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            anaSayfaForm.Show();
            this.Close();
        }
    }
}
