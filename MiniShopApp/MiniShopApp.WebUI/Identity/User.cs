using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Identity
{
    public class User:IdentityUser
    { //haızr tablolar yaratıldı üzerine ek olarak user tablosunda bu alamların olmasınıda istediğimi belirtttim.
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
