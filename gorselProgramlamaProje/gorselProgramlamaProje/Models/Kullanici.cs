using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorselProgramlamaProje.Models;
public class Kullanici
{
    public int Id { get; set; }
    public string KullaniciAdi { get; set; }
    public string SifreHash { get; set; }

    // Navigation
    public List<Gorev> Gorevler { get; set; } = new();
    public List<SureSeti> OlusturduguSureSetleri { get; set; } = new();
    public KullaniciAyar? Ayar { get; set; }
    public List<SilinenGorev> SilinenGorevler { get; set; } = new();
    public List<PomodoroOturumu> Oturumlar { get; set; } = new();
    public List<GunlukOzet> Ozetler { get; set; } = new();
}

