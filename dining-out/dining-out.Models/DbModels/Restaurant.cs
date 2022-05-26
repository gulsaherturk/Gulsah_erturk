using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.DbModels
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            BookTableOrderedItems = new HashSet<BookTableOrderedItem>();
            BookTableRezervations = new HashSet<BookTableRezervation>();
            Menus = new HashSet<Menu>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public string SystemDefinitionName { get; set; }
        public string City { get; set; }
        public int CityId { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public string Logo { get; set; }
        public string District { get; set; }
        public int DistrictId { get; set; }
        public string Desc { get; set; }
        public string CoverImg { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<BookTableOrderedItem> BookTableOrderedItems { get; set; }
        public virtual ICollection<BookTableRezervation> BookTableRezervations { get; set; }
        public virtual ICollection<Menu> Menus { get; set; }
    }
}
