using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;
using System.IO;

var dbPath = Path.Combine(Directory.GetCurrentDirectory(), "Data", "pomodoro.db");

// 🔧 Klasör varsa geç, yoksa oluştur
var folder = Path.GetDirectoryName(dbPath);
if (!Directory.Exists(folder))
    Directory.CreateDirectory(folder);

Console.WriteLine($"Veritabanı yolu: {dbPath}");

using var context = new UygulamaDbContext();
context.Database.EnsureCreated();
Console.WriteLine("Veritabanı oluşturma kontrolü yapıldı.");

// 🔧 Test için bir kayıt ekleyelim
if (!context.Kullanicilar.Any())
{
    context.Kullanicilar.Add(new Kullanici
    {
        KullaniciAdi = "admin",
        SifreHash = "test123"
    });
    context.SaveChanges();
    Console.WriteLine("Test kullanıcısı eklendi.");
}
else
{
    Console.WriteLine("Veritabanı zaten kayıt içeriyor.");
}
