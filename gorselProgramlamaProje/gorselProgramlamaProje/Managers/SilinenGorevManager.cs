using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Managers;

public static class SilinenGorevManager
{
    public static List<SilinenGorev> SilinenGorevleriGetir(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.SilinenGorevler
            .Where(s => s.KullaniciId == kullaniciId)
            .OrderByDescending(s => s.OlusturmaTarihi)
            .ToList();
    }

    public static void GoreviGeriAl(int silinenGorevId)
    {
        using var context = new UygulamaDbContext();
        var silinen = context.SilinenGorevler.FirstOrDefault(s => s.Id == silinenGorevId);
        if (silinen is null) return;

        var geriAlinan = new Gorev
        {
            KullaniciId = silinen.KullaniciId,
            Baslik = silinen.Baslik,
            Aciklama = silinen.Aciklama,
            OlusturmaTarihi = silinen.OlusturmaTarihi,
            TamamlandiMi = silinen.TamamlandiMi
        };

        context.Gorevler.Add(geriAlinan);
        context.SilinenGorevler.Remove(silinen);
        context.SaveChanges();
    }

    public static void GoreviKaliciSil(int silinenGorevId)
    {
        using var context = new UygulamaDbContext();
        var silinen = context.SilinenGorevler.FirstOrDefault(s => s.Id == silinenGorevId);
        if (silinen is null) return;

        context.SilinenGorevler.Remove(silinen);
        context.SaveChanges();
    }

    public static SilinenGorev? SilinenGoreviGetir(int silinenGorevId)
    {
        using var context = new UygulamaDbContext();
        return context.SilinenGorevler.FirstOrDefault(s => s.Id == silinenGorevId);
    }
}
