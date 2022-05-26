using System;
namespace dining_out.Models.ViewModels
{
    public class UserVM
    {
        public UserVM()
        {
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserType { get; set; }
        public string Description { get; set; }

        public bool isCustomer()
        {
            return UserTypeEnum.CUSTOMER.ToString().Equals(this.UserType);
        }

        public bool isRestaurant()
        {
            return UserTypeEnum.RESTAURANT.ToString().Equals(this.UserType);
        }

        public enum UserTypeEnum
        {
            CUSTOMER, RESTAURANT
        }
    }
}
