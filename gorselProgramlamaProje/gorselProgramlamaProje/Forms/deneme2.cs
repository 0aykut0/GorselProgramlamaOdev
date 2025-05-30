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
    public partial class deneme2 : Form
    {
        private Form deneme1Form;

        // Constructor, deneme1'den gelen referansı alır
        public deneme2(Form geriDonulecekForm)
        {
            InitializeComponent();
            deneme1Form = geriDonulecekForm;
        }

        // Örnek: Geri dön butonuna basıldığında çalışacak olay
        

        private void geri_Click(object sender, EventArgs e)
        {
            deneme1Form.Show();  // deneme1 tekrar görünür
            this.Close();        // deneme2 kapanır
        }
    }
}
