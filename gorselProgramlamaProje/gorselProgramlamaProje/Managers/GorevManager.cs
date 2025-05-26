using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Managers;

public static class GorevManager
{
    public static void GorevEkle(Gorev gorev)
    {
        using var context = new UygulamaDbContext();
        context.Gorevler.Add(gorev);
        context.SaveChanges();
    }

    public static Gorev? GoreviGetir(int gorevId)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler.FirstOrDefault(g => g.Id == gorevId);
    }

    public static void GoreviGuncelle(Gorev gorev)
    {
        using var context = new UygulamaDbContext();
        context.Gorevler.Update(gorev);
        context.SaveChanges();
    }

    public static void GoreviSil(int gorevId)
    {
        using var context = new UygulamaDbContext();
        var gorev = context.Gorevler.Find(gorevId);
        if (gorev != null)
        {
            var silinen = new SilinenGorev
            {
                OrijinalId = gorev.Id,
                KullaniciId = gorev.KullaniciId,
                Baslik = gorev.Baslik,
                Aciklama = gorev.Aciklama,
                OlusturmaTarihi = gorev.OlusturmaTarihi,
                TamamlandiMi = gorev.TamamlandiMi
            };
            context.SilinenGorevler.Add(silinen);
            context.Gorevler.Remove(gorev);
            context.SaveChanges();
        }
    }

    public static List<Gorev> TumGorevleriGetir(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler
            .Where(g => g.KullaniciId == kullaniciId)
            .OrderByDescending(g => g.OlusturmaTarihi)
            .ToList();
    }

    public static List<Gorev> TamamlananGorevleriGetir(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler
            .Where(g => g.KullaniciId == kullaniciId && g.TamamlandiMi)
            .ToList();
    }

    public static List<Gorev> TamamlanmayanGorevleriGetir(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler
            .Where(g => g.KullaniciId == kullaniciId && !g.TamamlandiMi)
            .ToList();
    }

    public static List<Gorev> TariheGoreGorevleriGetir(int kullaniciId, DateTime tarih)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler
            .Where(g => g.KullaniciId == kullaniciId && g.OlusturmaTarihi.Date == tarih.Date)
            .ToList();
    }

    public static List<Gorev> TarihAraligindakiGorevleriGetir(int kullaniciId, DateTime baslangic, DateTime bitis)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler
            .Where(g => g.KullaniciId == kullaniciId &&
                        g.OlusturmaTarihi.Date >= baslangic.Date &&
                        g.OlusturmaTarihi.Date <= bitis.Date)
            .ToList();
    }

    public static int GorevSayisi(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler.Count(g => g.KullaniciId == kullaniciId);
    }

    public static int TamamlananSayisi(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler.Count(g => g.KullaniciId == kullaniciId && g.TamamlandiMi);
    }

    public static int TamamlanmayanSayisi(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.Gorevler.Count(g => g.KullaniciId == kullaniciId && !g.TamamlandiMi);
    }
}
