using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselProgramlamaProje.Models
{
    public class GunlukOzet
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public DateTime Tarih { get; set; }

        public int ToplamPomodoroDakika { get; set; }
        public int BasariliGorevSayisi { get; set; }
        public int BasarisizGorevSayisi { get; set; }

        // Navigation
        public Kullanici Kullanici { get; set; }
    }
}
