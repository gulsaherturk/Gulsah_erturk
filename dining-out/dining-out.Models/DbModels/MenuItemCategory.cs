using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class MenuItemCategory
    {
        public MenuItemCategory()
        {
            MenuItems = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
