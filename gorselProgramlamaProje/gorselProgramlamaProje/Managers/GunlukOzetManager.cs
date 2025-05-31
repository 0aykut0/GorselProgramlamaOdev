using System;
using System.Linq;
using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Managers
{
    public static class GunlukOzetManager
    {
        public static GunlukOzet? GetOzetByDate(int kullaniciId, DateTime tarih)
        {
            using var ctx = new UygulamaDbContext();
            return ctx.GunlukOzetler
                .FirstOrDefault(o => o.KullaniciId == kullaniciId && o.Tarih == tarih.Date);
        }


        public static void AddGunlukOzet(GunlukOzet ozet)
        {
            using var ctx = new UygulamaDbContext();
            ctx.GunlukOzetler.Add(ozet);
            ctx.SaveChanges();
        }

        public static void UpdateGunlukOzet(GunlukOzet ozet)
        {
            using var ctx = new UygulamaDbContext();
            ctx.GunlukOzetler.Update(ozet);
            ctx.SaveChanges();
        }
               
    
        public static void AddPomodoroDakikaByDate(int kullaniciId, DateTime tarih, int eklenecekDakika)
        {
            DateTime gun = tarih.Date;

            using var ctx = new UygulamaDbContext();
            var mevcutOzet = ctx.GunlukOzetler
                .FirstOrDefault(o => o.KullaniciId == kullaniciId && o.Tarih == gun);

            if (mevcutOzet == null)
            {
                GunlukOzet yeniOzet = new GunlukOzet
                {
                    KullaniciId = kullaniciId,
                    Tarih = gun,
                    ToplamPomodoroDakika = eklenecekDakika,
                    BasariliGorevSayisi = 0,
                    BasarisizGorevSayisi = 0
                };
                ctx.GunlukOzetler.Add(yeniOzet);
            }
            else
            {
                mevcutOzet.ToplamPomodoroDakika += eklenecekDakika;
                ctx.GunlukOzetler.Update(mevcutOzet);
            }

            ctx.SaveChanges();
        }
    }
}
