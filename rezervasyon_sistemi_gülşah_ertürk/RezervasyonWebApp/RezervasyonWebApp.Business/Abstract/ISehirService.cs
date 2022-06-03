using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Business.Abstract
{
   public interface ISehirService
    {
        Sehir GetById(int id);
        string sehirad();
        void Create(Sehir entity);
        void Update(Sehir entity);
        void Delete(Sehir entity);
        void Update(Sehir entity, int[] sehirIds);
        List<Sehir> GetAll();
    }
}
