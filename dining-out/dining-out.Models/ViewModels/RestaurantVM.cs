using System;
using Microsoft.AspNetCore.Http;

namespace dining_out.Models.ViewModels
{
    public class RestaurantVM
    {
        public RestaurantVM(){}

        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public int? UserId { get; set; }
        public string SystemDefinitionName { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string CityId { get; set; }
        public string DistrictId { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public string Logo { set; get; }
        public string CoverImg { get; set; }
        public MenuVm Menu { get; set; }
        public IFormFile LogoFile { set; get; }
        public IFormFile CoverImgFile { get; set; }
        public string LastRezervationText { get; set; }
        public int NewBookingCount { get; set; }
        public int ApprovedBookingCount { get; set; }
        public int ClosedBookingCount { get; set; }

    }
}
