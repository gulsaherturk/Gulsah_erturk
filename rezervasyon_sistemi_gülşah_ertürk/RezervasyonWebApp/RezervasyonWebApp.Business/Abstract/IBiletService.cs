using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Business.Abstract
{
  public  interface IBiletService
    {
        Bilet GetById(int id);
        void Create(Bilet entity);
        void Update(Bilet entity);
        void Delete(Bilet entity);
        void Update(Bilet entity, int[] biletIds);
        List<Bilet> GetAll();
        int GetCountByKoltuk(int guzergahId);
        List<int> GetKoltuk(int guzergahId);
        Bilet GetSonKayit();
        int GetId();
        string GetTarih(int id);
        string GetSaat(int id);
    }
}
