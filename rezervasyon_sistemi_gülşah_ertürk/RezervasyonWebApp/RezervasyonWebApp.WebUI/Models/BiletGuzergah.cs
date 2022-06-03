using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezervasyonWebApp.WebUI.Models
{
    public class BiletGuzergah
    {
        public List<RezervasyonWebApp.Entity.Bilet> Bilets { get; set; }
        public List<Guzergah> Guzergahs { get; set; }
        public List<Sehir> Sehirs { get; set; }
        public Guzergah YeniGuzergah { get; set; }
        public string Saat { get; set; }
        public string tarih { get; set; }
        public Bilet bilet { get; set; }

    }
}
