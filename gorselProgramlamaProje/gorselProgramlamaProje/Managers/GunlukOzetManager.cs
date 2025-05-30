using gorselProgramlamaProje.Data;
using gorselProgramlamaProje.Models;
using System;
using System.Linq;

namespace gorselProgramlamaProje.Managers
{
    public static class GunlukOzetManager
    {
        /// <summary>
        /// Bugünün özetine Pomodoro dakikası ekler (kullanıcıya özgü).
        /// </summary>
        public static void AddPomodoroDakika(int dakikaToAdd, int kullaniciId)
        {
            using var ctx = new UygulamaDbContext();
            var today = DateTime.Today;

            // Bu kullanıcı ve bugüne ait özet kaydını al
            var ozet = ctx.GunlukOzetler
                .FirstOrDefault(o => o.Tarih == today && o.KullaniciId == kullaniciId);

            if (ozet == null)
            {
                // Yeni kayıt oluştur
                ozet = new GunlukOzet
                {
                    KullaniciId = kullaniciId,
                    Tarih = today,
                    ToplamPomodoroDakika = dakikaToAdd,
                    BasariliGorevSayisi = 0,
                    BasarisizGorevSayisi = 0
                };
                ctx.GunlukOzetler.Add(ozet);
            }
            else
            {
                // Var olanın üzerine ekle
                ozet.ToplamPomodoroDakika += dakikaToAdd;
                ctx.GunlukOzetler.Update(ozet);
            }

            ctx.SaveChanges();
        }

        /// <summary>
        /// Bugünkü toplam Pomodoro dakikasını getirir.
        /// </summary>
        public static int GetTodayPomodoroDakika(int kullaniciId)
        {
            using var ctx = new UygulamaDbContext();
            var today = DateTime.Today;

            var ozet = ctx.GunlukOzetler
                .FirstOrDefault(o => o.Tarih == today && o.KullaniciId == kullaniciId);

            return ozet?.ToplamPomodoroDakika ?? 0;
        }
    }
}
