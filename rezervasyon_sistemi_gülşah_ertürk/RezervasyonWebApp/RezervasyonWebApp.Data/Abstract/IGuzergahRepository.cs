using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Data.Abstract
{
    public interface IGuzergahRepository : IRepository<Guzergah>
    {
        string GetNereden(string nereden);
        string GetNereye(string nereye);
        List<Guzergah> GetYolculuk(string nereden, string nereye);
        int GetGuzergahByBslBts(string baslangic, string guzergah1, string guzergah2, string guzergah3, string bitis);
        Guzergah GetGuzergahDetails(int id);

    }
}
