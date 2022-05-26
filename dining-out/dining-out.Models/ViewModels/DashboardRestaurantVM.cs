using System;
using System.Collections.Generic;

namespace dining_out.Models.ViewModels
{
    public class DashboardRestaurantVM
    {
        public DashboardRestaurantVM()
        {
        }

        public ICollection<RestaurantVM> Restaurants { get; set; }
    }
}
