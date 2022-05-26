using System;
using System.Collections.Generic;
using dining_out.Models.DbModels;

namespace dining_out.Models.ViewModels
{
    public class MenuVm
    {
      
        public MenuVm()
        {
            MenuItems = new List<MenuItemVM>();
            MenuItemsDictionary = new Dictionary<string, List<MenuItemVM>>();
        }

        public int Id { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public string Statu { get; set; }
        public RestaurantVM Restaurant { get; set; }
        public int RestaurantId { get; set; }
        public MenuItemVM menuItem { get; set; }
        public List<MenuItemVM> MenuItems { get; set; }
        public Dictionary<string,List<MenuItemVM>> MenuItemsDictionary { get; set; }
    }
}
