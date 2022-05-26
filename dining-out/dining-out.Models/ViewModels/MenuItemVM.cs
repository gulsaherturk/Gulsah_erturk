using System;
using dining_out.Models.DbModels;

namespace dining_out.Models.ViewModels
{
    public class MenuItemVM
    {
        public MenuItemVM()
        {
        }

        public int Id { get; set; }
        public string MenuItemName { get; set; }
        public string MenuItemIngredients { get; set; }
        public string MenuItemDescription { get; set; }
        public decimal Price { get; set; }

        public MenuItemCategoryVM Category { get; set; }
    }
}
