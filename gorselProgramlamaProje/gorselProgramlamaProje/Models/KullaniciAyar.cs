using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselProgramlamaProje.Models
{
    public class KullaniciAyar
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public int SureSetiId { get; set; }

        // Navigation
        public Kullanici Kullanici { get; set; }
        public SureSeti SureSeti { get; set; }
    }

}
