namespace gorselProgramlamaProje.Models;

public class SureSeti
{
    public int Id { get; set; }
    public string Ad { get; set; } = string.Empty;
    public int CalismaSuresi { get; set; }
    public int MolaSuresi { get; set; }

    // Kullanıcıya özelse bu alan atanır, değilse null olabilir
    public int? KullaniciId { get; set; }
    public Kullanici? Kullanici { get; set; }
}
