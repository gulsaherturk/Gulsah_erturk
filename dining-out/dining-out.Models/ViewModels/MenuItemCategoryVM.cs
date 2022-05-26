using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class MenuItemCategoryVM
    {
        public MenuItemCategoryVM()
        {
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

    }
}
