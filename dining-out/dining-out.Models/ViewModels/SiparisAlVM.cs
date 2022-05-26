using System;
using System.Collections.Generic;

namespace dining_out.Models.ViewModels
{
    public class SiparisAlVM
    {
        public SiparisAlVM()
        {
            menuItemsVM = new List<MenuItemVM>();
        }

        public int MasaRezervationId { get; set; }
        public RestaurantVM restaurantVM { get; set; }
        public BookTableRezervationVM rezervationVM { get; set; }
        public List<MenuItemVM> menuItemsVM { get; set; }
    }
}
