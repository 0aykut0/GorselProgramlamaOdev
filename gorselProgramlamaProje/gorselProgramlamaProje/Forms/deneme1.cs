using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselProgramlamaProje.Forms
{
    public partial class deneme1 : Form
    {
        public deneme1()
        {
            InitializeComponent();
        }

        private void pomodoro_Click(object sender, EventArgs e)
        {
            this.Hide(); // deneme1 formunu gizler

            // deneme2 formunu oluştururken bu formu referans olarak ver
            deneme2 yeniForm = new deneme2(this);
            yeniForm.Show();
        }
    }
}
