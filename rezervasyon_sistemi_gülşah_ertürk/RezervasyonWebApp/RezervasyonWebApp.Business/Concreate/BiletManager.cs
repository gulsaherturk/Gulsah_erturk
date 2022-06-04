using RezervasyonWebApp.Business.Abstract;
using RezervasyonWebApp.Data.Abstract;
using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Business.Concreate
{
   public class BiletManager:IBiletService
    {
        private IBiletRepository _biletRepository;
        public BiletManager(IBiletRepository biletRepository)
        {
            _biletRepository = biletRepository;
        }

        public void Create(Bilet entity)
        {
            _biletRepository.Create(entity);
        }

        public void Delete(Bilet entity)
        {
            _biletRepository.Delete(entity);
        }

        public List<Bilet> GetAll()
        {
            return _biletRepository.GetAll();
        }

        public Bilet GetById(int id)
        {
            return _biletRepository.GetById(id);
        }

        public int GetCountByKoltuk(int guzergahId)
        {
            return _biletRepository.GetCountByKoltuk(guzergahId);

        }

        public int GetId()
        {
            return _biletRepository.GetId();
        }

        public List<int> GetKoltuk(int guzergahId)
        {
            return _biletRepository.GetKoltuk(guzergahId);

        }

        public string GetSaat(int id)
        {
            return _biletRepository.GetSaat(id);

        }

        public Bilet GetSonKayit()
        {
            return _biletRepository.GetSonKayit();

        }

        public string GetTarih(int id)
        {
            return _biletRepository.GetTarih(id);

        }

        public void Update(Bilet entity)
        {
            _biletRepository.Update(entity);

        }

        public void Update(Bilet entity, int[] biletIds)
        {
            throw new NotImplementedException();
        }
    }
}
