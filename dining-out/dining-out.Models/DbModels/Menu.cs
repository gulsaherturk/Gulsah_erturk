using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class Menu
    {
        public Menu()
        {
            BookTableOrderedItems = new HashSet<BookTableOrderedItem>();
            BookTablePaymentTransactions = new HashSet<BookTablePaymentTransaction>();
            MenuItems = new HashSet<MenuItem>();
        }

        public int Id { get; set; }
        public string MenuName { get; set; }
        public string Description { get; set; }
        public int RestaurantId { get; set; }
        public string Statu { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<BookTableOrderedItem> BookTableOrderedItems { get; set; }
        public virtual ICollection<BookTablePaymentTransaction> BookTablePaymentTransactions { get; set; }
        public virtual ICollection<MenuItem> MenuItems { get; set; }
    }
}
