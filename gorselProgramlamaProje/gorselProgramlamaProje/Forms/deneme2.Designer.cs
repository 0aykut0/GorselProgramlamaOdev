namespace gorselProgramlamaProje.Forms
{
    partial class deneme2
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
            geri = new Button();
            SuspendLayout();
            // 
            // geri
            // 
            geri.Location = new Point(177, 94);
            geri.Name = "geri";
            geri.Size = new Size(75, 23);
            geri.TabIndex = 0;
            geri.Text = "geri";
            geri.UseVisualStyleBackColor = true;
            geri.Click += geri_Click;
            // 
            // deneme2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 246);
            Controls.Add(geri);
            Name = "deneme2";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button geri;
    }
}