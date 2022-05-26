using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Data.Concrete.EfCore
{
   public class EfCoreGuzergahRepository : EfCoreGenericRepository<Guzergah, RezervasyonWebAppContext>,IGuzergahRepository
    {
    }
}
