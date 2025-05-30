namespace gorselProgramlamaProje.Forms
{
    partial class PomodoroForm
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
            components = new System.ComponentModel.Container();
            pnlTimer = new Panel();
            lblTime = new Label();
            btnStart = new Button();
            btnPause = new Button();
            btnStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            rdoShort = new RadioButton();
            rdoMedium = new RadioButton();
            rdoLong = new RadioButton();
            btnMute = new Button();
            pnlTimer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTimer
            // 
            pnlTimer.BackColor = Color.Pink;
            pnlTimer.Controls.Add(lblTime);
            pnlTimer.Location = new Point(300, 30);
            pnlTimer.Name = "pnlTimer";
            pnlTimer.Size = new Size(200, 200);
            pnlTimer.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Fill;
            lblTime.Font = new Font("Segoe UI Semibold", 39F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTime.Location = new Point(0, 0);
            lblTime.Name = "lblTime";
            lblTime.Padding = new Padding(0, 10, 0, 0);
            lblTime.Size = new Size(200, 200);
            lblTime.TabIndex = 0;
            lblTime.Text = "00:20";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Pink;
            btnStart.FlatAppearance.BorderColor = Color.Pink;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatAppearance.CheckedBackColor = Color.Pink;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Pink;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Pink;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(231, 297);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "başlat";
            btnStart.UseVisualStyleBackColor = false;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.Pink;
            btnPause.FlatAppearance.BorderColor = Color.Pink;
            btnPause.FlatAppearance.BorderSize = 0;
            btnPause.FlatAppearance.CheckedBackColor = Color.Pink;
            btnPause.FlatAppearance.MouseDownBackColor = Color.Pink;
            btnPause.FlatAppearance.MouseOverBackColor = Color.Pink;
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Location = new Point(351, 297);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(100, 40);
            btnPause.TabIndex = 2;
            btnPause.Text = "duraklat";
            btnPause.UseVisualStyleBackColor = false;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.Pink;
            btnStop.FlatAppearance.BorderColor = Color.Pink;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.CheckedBackColor = Color.Pink;
            btnStop.FlatAppearance.MouseDownBackColor = Color.Pink;
            btnStop.FlatAppearance.MouseOverBackColor = Color.Pink;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Location = new Point(471, 297);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(100, 40);
            btnStop.TabIndex = 3;
            btnStop.Text = "sıfırla";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // rdoShort
            // 
            rdoShort.AutoSize = true;
            rdoShort.BackColor = SystemColors.ButtonHighlight;
            rdoShort.Location = new Point(581, 59);
            rdoShort.Name = "rdoShort";
            rdoShort.Size = new Size(111, 24);
            rdoShort.TabIndex = 4;
            rdoShort.TabStop = true;
            rdoShort.Text = "KISA (10 dk)";
            rdoShort.UseVisualStyleBackColor = false;
            // 
            // rdoMedium
            // 
            rdoMedium.AutoSize = true;
            rdoMedium.BackColor = SystemColors.HighlightText;
            rdoMedium.Location = new Point(581, 126);
            rdoMedium.Name = "rdoMedium";
            rdoMedium.Size = new Size(120, 24);
            rdoMedium.TabIndex = 5;
            rdoMedium.TabStop = true;
            rdoMedium.Text = "İDEAL (25 dk)";
            rdoMedium.UseVisualStyleBackColor = false;
            // 
            // rdoLong
            // 
            rdoLong.AutoSize = true;
            rdoLong.BackColor = SystemColors.HighlightText;
            rdoLong.Location = new Point(581, 194);
            rdoLong.Name = "rdoLong";
            rdoLong.Size = new Size(129, 24);
            rdoLong.TabIndex = 6;
            rdoLong.TabStop = true;
            rdoLong.Text = "YOĞUN (45 dk)";
            rdoLong.UseVisualStyleBackColor = false;
            // 
            // btnMute
            // 
            btnMute.Location = new Point(736, 12);
            btnMute.Name = "btnMute";
            btnMute.Size = new Size(33, 32);
            btnMute.TabIndex = 7;
            btnMute.Text = "🔇";
            btnMute.UseVisualStyleBackColor = true;
            // 
            // PomodoroForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(793, 455);
            Controls.Add(btnMute);
            Controls.Add(rdoLong);
            Controls.Add(rdoMedium);
            Controls.Add(rdoShort);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Controls.Add(pnlTimer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PomodoroForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "PomodoroForm";
            Load += PomodoroForm_Load;
            pnlTimer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTimer;
        private Label lblTime;
        private Button btnStart;
        private Button btnPause;
        private Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private RadioButton rdoShort;
        private RadioButton rdoMedium;
        private RadioButton rdoLong;
        private Button btnMute;
    }
}