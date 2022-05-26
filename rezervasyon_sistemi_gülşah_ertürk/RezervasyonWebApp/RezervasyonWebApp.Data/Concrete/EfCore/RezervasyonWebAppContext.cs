using Microsoft.EntityFrameworkCore;
using RezervasyonWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonWebApp.Data.Concrete.EfCore
{
   public class RezervasyonWebAppContext:DbContext
    {
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=rezervasyonDb");
        }
        public DbSet<Bilet> Bilets { get; set; }
        public DbSet<Guzergah> Guzergahs { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }

    }
}
