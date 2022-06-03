using Microsoft.EntityFrameworkCore;
using RezervasyonWebApp.Data.Abstract;
using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Data.Concrete.EfCore
{
    public class EfCoreGuzergahRepository : EfCoreGenericRepository<Guzergah, RezervasyonWebAppContext>, IGuzergahRepository
    {
        public int GetGuzergahByBslBts(string baslangic, string guzergah1, string guzergah2, string guzergah3, string bitis)
        {
            throw new NotImplementedException();
        }

        public Guzergah GetGuzergahDetails(int id)
        {
            using (var context = new RezervasyonWebAppContext())
            {
                return context.Guzergahs
                    .Where(i => i.GuzergahId == id)
                    .AsNoTracking()
                    .FirstOrDefault();
            }
        }

        public string GetNereden(string nereden)
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var nrdn = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereden))
                    .Select(i => i.SehirAd)
                    .ToList();
                return nrdn[0];
            }
        }

        public string GetNereye(string nereye)
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var nry = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereye))
                    .Select(i => i.SehirAd)
                    .ToList();
                return nry[0];
            }
        }

        public List<Guzergah> GetYolculuk(string nereden, string nereye)
        {
            using (var context = new RezervasyonWebAppContext())
            {
                var nrdn = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereden))
                    .Select(i => i.SehirAd)
                    .ToList();
                var nry = context.Sehirs
                    .Where(i => i.SehirId == Convert.ToInt32(nereye))
                    .Select(i => i.SehirAd)
                    .ToList();
                var guzergahs = context.Guzergahs
                    .FromSqlRaw($"select * from Guzergahs where ((baslangic='{nrdn[0]}' or guzergah1='{nrdn[0]}' or guzergah2='{nrdn[0]}' or guzergah3='{nrdn[0]}' ) and (bitis='{nry[0]}' or guzergah3='{nry[0]}' or guzergah2='{nry[0]}' or guzergah1='{nry[0]}' )) ")
                    .ToList();

                return guzergahs;

            }
        }
    }
}
