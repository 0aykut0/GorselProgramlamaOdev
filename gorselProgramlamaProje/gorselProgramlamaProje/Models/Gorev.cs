using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselProgramlamaProje.Models;
public class Gorev
{
    public int Id { get; set; }
    public int KullaniciId { get; set; }

    public string Baslik { get; set; }
    public string Aciklama { get; set; }
    public DateTime OlusturmaTarihi { get; set; }
    public bool TamamlandiMi { get; set; }

    // Navigation
    public Kullanici Kullanici { get; set; }
}



