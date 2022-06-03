using RezervasyonWebApp.Data.Abstract;
using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Data.Concrete.EfCore
{
    public class EfCoreSehirRepository : EfCoreGenericRepository<Sehir, RezervasyonWebAppContext>, ISehirRepository
    {
        public string sehirad()
        {
            throw new NotImplementedException();
        }
    }
}
