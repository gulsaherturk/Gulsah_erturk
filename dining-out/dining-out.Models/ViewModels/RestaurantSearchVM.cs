using System;
using System.Collections.Generic;

#nullable disable

namespace dining_out.Models.ViewModels
{
    public partial class RestaurantSearchVM
    {
        public string Name { get; set; }
        public string CityId { get; set; }
        public string DistrictId { get; set; }
        public DateTime BookTableDate { get; set; }
        public int? Capacity { get; set; }
    }
}
