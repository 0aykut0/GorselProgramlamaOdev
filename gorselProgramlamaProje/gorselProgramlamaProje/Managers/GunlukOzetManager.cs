using System;
using System.Linq;
using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;

namespace gorselProgramlamaProje.Managers
{
    public static class GunlukOzetManager
    {
        // ------------------------------
        // A) “Tarihe göre özet getir” metodu
        public static GunlukOzet? GetOzetByDate(int kullaniciId, DateTime tarih)
        {
            using var ctx = new UygulamaDbContext();
            return ctx.GunlukOzetler
                .FirstOrDefault(o => o.KullaniciId == kullaniciId && o.Tarih == tarih.Date);
        }

        // ------------------------------
        // B) “Yeni günlük özet ekle” metodu
        public static void AddGunlukOzet(GunlukOzet ozet)
        {
            using var ctx = new UygulamaDbContext();
            ctx.GunlukOzetler.Add(ozet);
            ctx.SaveChanges();
        }

        // ------------------------------
        // C) “Varolan özet güncelle” metodu
        public static void UpdateGunlukOzet(GunlukOzet ozet)
        {
            using var ctx = new UygulamaDbContext();
            ctx.GunlukOzetler.Update(ozet);
            ctx.SaveChanges();
        }

        // ------------------------------
        // (Mevcut AddPomodoroDakika ve GetTodayPomodoroDakika metotlarınız burada duruyor.)

        // ------------------------------
        // D) “Tarihe göre Pomodoro dakikası ekleme” metodu
        /// <summary>
        /// Belirli bir kullanıcı ve Tarih’e ait GunlukOzet kaydının ToplamPomodoroDakika
        /// değerine eklenecekDakika kadar ekleme yapar. Eğer o tarihe ait kayıt yoksa,
        /// yeni bir satır oluşturup ToplamPomodoroDakika = eklenecekDakika olarak kaydeder.
        /// </summary>
        public static void AddPomodoroDakikaByDate(int kullaniciId, DateTime tarih, int eklenecekDakika)
        {
            // “tarih.Date” ile yalnızca gün kısmını alıyoruz (saat 00:00:00).
            DateTime gun = tarih.Date;

            using var ctx = new UygulamaDbContext();

            // 1) O güne ait mevcut GunlukOzet kaydını veritabanından al
            var mevcutOzet = ctx.GunlukOzetler
                .FirstOrDefault(o => o.KullaniciId == kullaniciId && o.Tarih == gun);

            if (mevcutOzet == null)
            {
                // 2a) Eğer o gün için kayıt yoksa, yeni bir GunlukOzet oluştur
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
                // 2b) Eğer zaten varsa, mevcut kaydın ToplamPomodoroDakika değerine ekleme yap
                mevcutOzet.ToplamPomodoroDakika += eklenecekDakika;
                ctx.GunlukOzetler.Update(mevcutOzet);
            }

            ctx.SaveChanges();
        }
    }
}
