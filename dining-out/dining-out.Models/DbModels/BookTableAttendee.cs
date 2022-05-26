using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class BookTableAttendee
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BooktableRezervationId { get; set; }

        public virtual BookTableRezervation BooktableRezervation { get; set; }
        public virtual User User { get; set; }
    }
}
