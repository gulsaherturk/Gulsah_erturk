using RezervasyonWebApp.Data.Abstract;
using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Data.Concrete.EfCore
{
    public class EfCoreBiletRepository : EfCoreGenericRepository<Bilet, RezervasyonWebAppContext>, IBiletRepository
    {
        public int GetCountByKoltuk(int guzergahId)
        {
            using (var context = new  RezervasyonWebAppContext ())
            {
                return context.Bilets
                    .Where(i => i.GuzergahId == guzergahId)
                    .Select(i => i.KoltukNo)
                    .Count();
            }
        }

        public int GetId()
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var id = context.Bilets
                    .OrderByDescending(i => i.BiletId)
                    .Select(i => i.GuzergahId)
                    .FirstOrDefault();
                return id;
            }
        }

        public List<int> GetKoltuk(int guzergahId)
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var koltuk = context.Bilets
                    .Where(i => i.GuzergahId == guzergahId)
                    .Select(i => i.KoltukNo)
                    .ToList();

                return koltuk;
            }
        }

        public string GetSaat(int id)
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var sonbiletsaat = context.Guzergahs
                    .Where(i => i.GuzergahId == id)
                    .Select(i => i.Saat)
                    .FirstOrDefault();

                return sonbiletsaat;
            }
        }

        public Bilet GetSonKayit()
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var sonbilet = context.Bilets
                    .OrderByDescending(i => i.BiletId)
                    .FirstOrDefault();
                return sonbilet;
            }
        }

        public string GetTarih(int id)
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var sonbilettarih = context.Guzergahs
                    .Where(i => i.GuzergahId == id)
                    .Select(i => i.Tarih)
                    .FirstOrDefault();

                return sonbilettarih;
            }
        }
    }
}
