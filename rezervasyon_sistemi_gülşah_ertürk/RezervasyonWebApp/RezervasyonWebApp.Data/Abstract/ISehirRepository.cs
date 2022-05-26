using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Data.Abstract
{
     public interface ISehirRepository:IRepository<Sehir>
    {
        string sehirad();

    }

}
