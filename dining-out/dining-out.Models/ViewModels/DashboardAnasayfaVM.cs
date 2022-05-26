using System;
using System.Collections.Generic;

namespace dining_out.Models.ViewModels
{
    public class DashboardAnasayfaVM
    {
        public DashboardAnasayfaVM()
        {
        }

        public ICollection<BookTableRezervationVM> BookTableActiveRezervations { get; set; }
        public ICollection<BookTableRezervationVM> BookTableNewRezervations { get; set; }
        public ICollection<BookTableRezervationVM> BookTableClosedRezervations { get; set; }

    }
}
