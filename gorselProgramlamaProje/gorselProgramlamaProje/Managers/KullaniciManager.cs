using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;
using System.Security.Cryptography;
using System.Text;

namespace gorselProgramlamaProje.Managers;

public static class KullaniciManager
{
    // Kullanıcı ekle
    public static void KullaniciEkle(Kullanici kullanici)
    {
        using var context = new UygulamaDbContext();
        kullanici.SifreHash = SifreyiHashle(kullanici.SifreHash);
        context.Kullanicilar.Add(kullanici);
        context.SaveChanges();
    }

    // Giriş işlemi: kullanıcı adı ve şifre kontrolü
    public static Kullanici? KullaniciGirisYap(string kullaniciAdi, string sifre)
    {
        using var context = new UygulamaDbContext();
        string hash = SifreyiHashle(sifre);
        return context.Kullanicilar
            .FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi && k.SifreHash == hash);
    }

    // Kullanıcı ID ile getir
    public static Kullanici? KullaniciGetir(int kullaniciId)
    {
        using var context = new UygulamaDbContext();
        return context.Kullanicilar.Find(kullaniciId);
    }

    // Kullanıcı adı var mı kontrolü (kayıt ekranı için)
    public static bool KullaniciAdiVarMi(string kullaniciAdi)
    {
        using var context = new UygulamaDbContext();
        return context.Kullanicilar.Any(k => k.KullaniciAdi == kullaniciAdi);
    }

    // Şifreyi SHA256 ile hashle
    private static string SifreyiHashle(string sifre)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(sifre);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
