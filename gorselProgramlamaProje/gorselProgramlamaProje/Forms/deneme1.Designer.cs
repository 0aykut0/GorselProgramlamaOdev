namespace gorselProgramlamaProje.Forms
{
    partial class deneme1
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
            pomodoro = new Button();
            SuspendLayout();
            // 
            // pomodoro
            // 
            pomodoro.Location = new Point(178, 88);
            pomodoro.Name = "pomodoro";
            pomodoro.Size = new Size(75, 23);
            pomodoro.TabIndex = 0;
            pomodoro.Text = "pomodoro";
            pomodoro.UseVisualStyleBackColor = true;
            pomodoro.Click += pomodoro_Click;
            // 
            // deneme1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 237);
            Controls.Add(pomodoro);
            Name = "deneme1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button pomodoro;
    }
}