using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dining_out.Models.ViewModels;
using dining_out.Models.DbModels;
using dining_out.Utility;

namespace dining_out.Controllers
{
    public class UyeOlController : Controller
    {
        private readonly ILogger<UyeOlController> _logger;

        public UyeOlController(ILogger<UyeOlController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string kullaniciTipi)
        {
            UyeOLVM uyeOl = new UyeOLVM();
            ViewBag.UserType = "";
            if (ConstantUtility.UserType.CUSTOMER.ToString().Equals(kullaniciTipi))
            {
                uyeOl.UserType = "1";
                ViewBag.UserType = "1";
            } else if (ConstantUtility.UserType.RESTAURANT.ToString().Equals(kullaniciTipi))
            {
                uyeOl.UserType = "2";
                ViewBag.UserType = "2";
            }
            return View("Index", uyeOl);
        }

        [HttpPost]
        public IActionResult UyeOl(UyeOLVM uyeOl)
        {
            diningoutContext dbContext = new diningoutContext();
            bool userFound = dbContext.Users.Where(user => user.UserName.Equals(uyeOl.UserName)).Any();
            var queryString = Request.QueryString;
            if (userFound)
            {
                ViewBag.hataMesaji = "Aynı E-mail adresi ile kayıtlı kullanıcı bulunuyor";
                ViewBag.Basarili = false;
                return View("Index", uyeOl);
            }
            User user = new User();
            user.Name = uyeOl.Name;
            user.Surname = uyeOl.Lastname;
            user.Password = uyeOl.Password;
            user.UserName = uyeOl.UserName;
            user.UserType = "1".Equals(uyeOl.UserType)? ConstantUtility.UserType.CUSTOMER.ToString(): ConstantUtility.UserType.RESTAURANT.ToString();
            user.Description = uyeOl.Description;
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            ViewBag.Basarili = true;

            return View("Index", uyeOl);
        }

    }
}
