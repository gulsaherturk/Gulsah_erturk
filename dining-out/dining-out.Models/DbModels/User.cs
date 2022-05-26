using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class User
    {
        public User()
        {
            BookTableAttendees = new HashSet<BookTableAttendee>();
            BookTableOrderedItems = new HashSet<BookTableOrderedItem>();
            BookTablePaymentTransactions = new HashSet<BookTablePaymentTransaction>();
            BookTableRezervations = new HashSet<BookTableRezervation>();
            Restaurants = new HashSet<Restaurant>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BookTableAttendee> BookTableAttendees { get; set; }
        public virtual ICollection<BookTableOrderedItem> BookTableOrderedItems { get; set; }
        public virtual ICollection<BookTablePaymentTransaction> BookTablePaymentTransactions { get; set; }
        public virtual ICollection<BookTableRezervation> BookTableRezervations { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
