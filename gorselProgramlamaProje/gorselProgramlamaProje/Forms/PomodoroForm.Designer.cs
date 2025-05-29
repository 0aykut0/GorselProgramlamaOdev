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
            button1 = new Button();
            pnlTimer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTimer
            // 
            pnlTimer.BackColor = Color.Pink;
            pnlTimer.Controls.Add(lblTime);
            pnlTimer.Location = new Point(262, 22);
            pnlTimer.Margin = new Padding(3, 2, 3, 2);
            pnlTimer.Name = "pnlTimer";
            pnlTimer.Size = new Size(175, 150);
            pnlTimer.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Fill;
            lblTime.Font = new Font("Segoe UI Semibold", 39F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblTime.Location = new Point(0, 0);
            lblTime.Name = "lblTime";
            lblTime.Padding = new Padding(0, 8, 0, 0);
            lblTime.Size = new Size(175, 150);
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
            btnStart.Location = new Point(201, 195);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(88, 30);
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
            btnPause.Location = new Point(306, 195);
            btnPause.Margin = new Padding(3, 2, 3, 2);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(88, 30);
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
            btnStop.Location = new Point(411, 195);
            btnStop.Margin = new Padding(3, 2, 3, 2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(88, 30);
            btnStop.TabIndex = 3;
            btnStop.Text = "sıfırla";
            btnStop.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(24, 22);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Geri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PomodoroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuText;
            ClientSize = new Size(694, 341);
            Controls.Add(button1);
            Controls.Add(btnStop);
            Controls.Add(btnPause);
            Controls.Add(btnStart);
            Controls.Add(pnlTimer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PomodoroForm";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "PomodoroForm";
            Load += PomodoroForm_Load;
            pnlTimer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTimer;
        private Label lblTime;
        private Button btnStart;
        private Button btnPause;
        private Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}