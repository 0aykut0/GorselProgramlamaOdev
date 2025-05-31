using System;
using System.Linq;
using System.Windows.Forms;
using gorselProgramlamaProje.Managers;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Forms
{
    public partial class GunSonu : Form
    {
        private DateTime selectedDate;
        private int currentUserId;

        public GunSonu()
        {
            InitializeComponent();
        }

        public GunSonu(DateTime tarih, int kullaniciId)
        {
            InitializeComponent();
            selectedDate = tarih;
            currentUserId = kullaniciId;

            this.Load += GunSonu_Load;
        }

        private void GunSonu_Load(object sender, EventArgs e)
        {
            //  Ona gönderdiğimiz “selectedDate” ve “currentUserId” ile ozet kaydını al
            var ozet = GunlukOzetManager.GetOzetByDate(currentUserId, selectedDate);

            if (ozet != null)
            {
                lblSure.Text = $"{ozet.ToplamPomodoroDakika} dak";
                lblYapilanGorev.Text = $"Başarılı: {ozet.BasariliGorevSayisi}   Başarısız: {ozet.BasarisizGorevSayisi}";
            }
            else
            {
                lblSure.Text = "0 dak";
                lblYapilanGorev.Text = "Başarılı: 0   Başarısız: 0";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
