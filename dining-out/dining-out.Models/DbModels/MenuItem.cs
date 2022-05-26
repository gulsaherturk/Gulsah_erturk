using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class MenuItem
    {
        public MenuItem()
        {
            BookTableOrderedItems = new HashSet<BookTableOrderedItem>();
        }

        public int Id { get; set; }
        public int MenuId { get; set; }
        public int CategoryId { get; set; }
        public string MenuItemName { get; set; }
        public string MenuItemIngredients { get; set; }
        public string MenuItemDescription { get; set; }
        public decimal Price { get; set; }

        public virtual MenuItemCategory Category { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual ICollection<BookTableOrderedItem> BookTableOrderedItems { get; set; }
    }
}
