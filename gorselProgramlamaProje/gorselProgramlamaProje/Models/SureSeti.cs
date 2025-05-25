using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselProgramlamaProje.Models
{
    public class SureSeti
    {
        public int Id { get; set; }
        public int CalismaSure { get; set; }
        public int MolaSure { get; set; }
        public int? OlusturanKullaniciId { get; set; }

        // Navigation
        public Kullanici? OlusturanKullanici { get; set; }
        public List<PomodoroOturumu> Oturumlar { get; set; } = new();
        public List<KullaniciAyar> SeciliAyarlar { get; set; } = new();
    }

}
