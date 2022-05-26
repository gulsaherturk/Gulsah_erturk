using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class BookTableRezervation
    {
        public BookTableRezervation()
        {
            BookTableAttendees = new HashSet<BookTableAttendee>();
            BookTableOrderedItems = new HashSet<BookTableOrderedItem>();
            BookTablePaymentTransactions = new HashSet<BookTablePaymentTransaction>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int RezervationUserId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string NameLastname { get; set; }
        public string RezervationStatus { get; set; }
        public DateTime RezervationDate { get; set; }
        public TimeSpan RezervationTime { get; set; }
        public int RestaurantId { get; set; }
        public int AttendeeNumber { get; set; }
        public DateTime RezervationCreatedDatetime { get; set; }

        public virtual Restaurant Restaurant { get; set; }
        public virtual User RezervationUser { get; set; }
        public virtual ICollection<BookTableAttendee> BookTableAttendees { get; set; }
        public virtual ICollection<BookTableOrderedItem> BookTableOrderedItems { get; set; }
        public virtual ICollection<BookTablePaymentTransaction> BookTablePaymentTransactions { get; set; }
    }
}
