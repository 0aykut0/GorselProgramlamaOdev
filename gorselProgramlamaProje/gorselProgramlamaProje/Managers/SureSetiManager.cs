using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Managers;

public static class SureSetiManager
{
    public static void SureSetiEkle(SureSeti set)
    {
        using var context = new UygulamaDbContext();
        context.SureSetleri.Add(set);
        context.SaveChanges();
    }

    public static void SureSetiGuncelle(SureSeti set)
    {
        using var context = new UygulamaDbContext();
        context.SureSetleri.Update(set);
        context.SaveChanges();
    }

    public static void SureSetiSil(int sureSetiId)
    {
        using var context = new UygulamaDbContext();
        var set = context.SureSetleri.Find(sureSetiId);
        if (set != null)
        {
            context.SureSetleri.Remove(set);
            context.SaveChanges();
        }
    }

    public static SureSeti? SureSetiGetir(int id)
    {
        using var context = new UygulamaDbContext();
        return context.SureSetleri.FirstOrDefault(s => s.Id == id);
    }

    public static List<SureSeti> TumSureSetleriniGetir()
    {
        using var context = new UygulamaDbContext();
        return context.SureSetleri.OrderBy(s => s.CalismaSuresi).ToList();
    }

    public static List<SureSeti> KullaniciyaAitSureSetleri(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.SureSetleri
            .Where(s => s.KullaniciId == kullaniciId || s.KullaniciId == null) // herkese açık olanlar + kişisel
            .OrderBy(s => s.CalismaSuresi)
            .ToList();
    }

    public static bool SetAdiVarMi(string ad, int? kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.SureSetleri.Any(s => s.Ad == ad && s.KullaniciId == kullaniciId);
    }
}
