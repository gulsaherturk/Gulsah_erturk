using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class BookTablePaymentTransaction
    {
        public int Id { get; set; }
        public int MenuOrderedItemId { get; set; }
        public int PayerUserId { get; set; }
        public decimal Price { get; set; }
        public DateTime PaymentDate { get; set; }
        public int RezervationId { get; set; }
        public int MenuId { get; set; }
        public string CartType { get; set; }
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string CardValidDate { get; set; }
        public string CardSecurityNumber { get; set; }

        public virtual Menu Menu { get; set; }
        public virtual BookTableOrderedItem MenuOrderedItem { get; set; }
        public virtual User PayerUser { get; set; }
        public virtual BookTableRezervation Rezervation { get; set; }
    }
}
