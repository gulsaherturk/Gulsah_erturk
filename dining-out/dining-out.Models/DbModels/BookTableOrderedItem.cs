using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class BookTableOrderedItem
    {
        public BookTableOrderedItem()
        {
            BookTablePaymentTransactions = new HashSet<BookTablePaymentTransaction>();
        }

        public int Id { get; set; }
        public int RezervationId { get; set; }
        public int MenuItemId { get; set; }
        public int MenuId { get; set; }
        public int RestaurantId { get; set; }
        public DateTime OrderedDate { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual MenuItem MenuItem { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual BookTableRezervation Rezervation { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BookTablePaymentTransaction> BookTablePaymentTransactions { get; set; }
    }
}
