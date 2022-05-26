using System;
using System.Collections.Generic;

namespace dining_out.Models.ViewModels
{
    public class DashboardMasaRezervasyonVM:BaseUserVM
    {
        public DashboardMasaRezervasyonVM()
        {
            orderedItemsVM = new List<BookTableOrderedItemVM>();
        }

        public BookTableRezervationVM rezervationVM { get; set; }
        public RestaurantVM restaurantVM { get; set; }
        public List<BookTableOrderedItemVM> orderedItemsVM { get; set; }
        public decimal TotalOrderedPriceByUser { get; set; }
        public string EklenenecekKullaniciIsmi { get; set; }

        public bool OdenecekSiparisVarmi()
        {
            foreach(BookTableOrderedItemVM item in orderedItemsVM)
            {
                if ("SERVICED".Equals(item.Status))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
