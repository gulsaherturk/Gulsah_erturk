using RezervasyonWebApp.Entity;
using System.Collections.Generic;

namespace RezervasyonWebApp.WebUI.Controllers
{
    internal class BiletGuzergah
    {
        public BiletGuzergah()
        {
        }

        public List<Sehir> Sehirs { get; set; }
        public object Guzergahs { get; set; }
        public List<Bilet> Bilets { get; internal set; }
    }
}