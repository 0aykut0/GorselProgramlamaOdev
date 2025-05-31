namespace gorselProgramlamaProje.Forms
{
    partial class PerformansForm
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
            SuspendLayout();
            // 
            // PerformansForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "PerformansForm";
            Text = "PerformansForm";
            Load += PerformansForm_Load;
            ResumeLayout(false);
        }
        private void PerformansForm_Load(object sender, EventArgs e)
        {
            // Designer çağırıyor ama biz elle oluşturduk, içerik gerekmez
        }

        #endregion
    }

}