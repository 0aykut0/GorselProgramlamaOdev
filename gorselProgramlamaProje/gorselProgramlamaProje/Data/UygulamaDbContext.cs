using Microsoft.EntityFrameworkCore;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Data;

public class UygulamaDbContext : DbContext
{
    public DbSet<Kullanici> Kullanicilar => Set<Kullanici>();
    public DbSet<Gorev> Gorevler => Set<Gorev>();
    public DbSet<SilinenGorev> SilinenGorevler => Set<SilinenGorev>();
    public DbSet<SureSeti> SureSetleri => Set<SureSeti>();
    public DbSet<KullaniciAyar> KullaniciAyarlari => Set<KullaniciAyar>();
    public DbSet<PomodoroOturumu> PomodoroOturumlari => Set<PomodoroOturumu>();
    public DbSet<GunlukOzet> GunlukOzetler => Set<GunlukOzet>();

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        var projectRoot = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\"));
        var dbPath = Path.Combine(projectRoot, "Data", "pomodoro.db");

        if (!Directory.Exists(Path.GetDirectoryName(dbPath)))
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

        Console.WriteLine("Veritabanı yolu (çözülmüş): " + dbPath);
        options.UseSqlite($"Data Source={dbPath}");
    }

}

