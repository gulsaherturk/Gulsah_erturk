using System;
namespace dining_out.Models.ViewModels
{
    public class BookTableOrderedItemVM
    {
        public BookTableOrderedItemVM()
        {
        }

        public int Id { get; set; }
        public int  RezervationId { get; set; }
        public int  MenuItemId { get; set; }
        public string  MenuItemName { get; set; }
        public string RestaurantName { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string StatusText { get; set; }
        public string  UserName { get; set; }
        public string PurchasedUserName { get; set; }
        public string OrderedDate { get; set; }

    }
}
