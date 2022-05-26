using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dining_out.Models.ViewModels;
using dining_out.Models.DbModels;
using dining_out.Utility;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace dining_out.Controllers
{
    public class DashboardRestaurantEkleController : Controller
    {
        private readonly ILogger<DashboardRestaurantEkleController> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DashboardRestaurantEkleController(ILogger<DashboardRestaurantEkleController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            StaticDataManagerUtility.sehirleriDoldur(this);
            StaticDataManagerUtility.IlceleriDoldur(this,"34");
            RestaurantVM sample = new RestaurantVM();
            
            defaultSabitDegerleriEkle(sample);
            
            return View(sample);
        }

        private void defaultSabitDegerleriEkle(RestaurantVM restaurantVM)
        {
            restaurantVM.CityId = "34";
            restaurantVM.DistrictId = "01";
            restaurantVM.Capacity = 40;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Ekle(RestaurantVM restaurantVM)
        {
            int userId = Converters.currentUserId(this);
            diningoutContext dbContext = new diningoutContext();
            var logoUniqueFileName="";
            var coverUniqueFileName = "";
            var logofilePath = "";
            var coverfilePath = "";
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads");
            var contextUploads = Path.Combine(_hostingEnvironment.ContentRootPath, "uploads");

            if (restaurantVM.LogoFile != null)
            {
                logoUniqueFileName = Converters.GetUniqueFileName(restaurantVM.LogoFile.FileName);
                logofilePath = Path.Combine(uploads, logoUniqueFileName);
                restaurantVM.LogoFile.CopyTo(new FileStream(logofilePath, FileMode.Create));
                logofilePath = Path.Combine("/uploads", logoUniqueFileName);
            }

            if (restaurantVM.CoverImgFile != null)
            {
                coverUniqueFileName = Converters.GetUniqueFileName(restaurantVM.CoverImgFile.FileName);
                coverfilePath = Path.Combine(uploads, coverUniqueFileName);
                restaurantVM.CoverImgFile.CopyTo(new FileStream(coverfilePath, FileMode.Create));
                coverfilePath = Path.Combine("/uploads", coverUniqueFileName);
            }

            Restaurant restaurant = new Restaurant();
            restaurant.Address = restaurantVM.Address;
            restaurant.Capacity = restaurantVM.Capacity;
            restaurant.City = StaticDataManagerUtility.sehirBul(restaurantVM.CityId).Value;
            restaurant.CityId = Convert.ToInt32(restaurantVM.CityId);
            restaurant.District = StaticDataManagerUtility.ilceBul(restaurantVM.CityId,restaurantVM.DistrictId).Value;
            restaurant.DistrictId = Convert.ToInt32(restaurantVM.DistrictId);
            restaurant.CoverImg = coverfilePath;
            restaurant.Logo = logofilePath;
            restaurant.Desc = restaurantVM.Desc;
            restaurant.Name = restaurantVM.Name;
            restaurant.SystemDefinitionName = restaurantVM.SystemDefinitionName;
            restaurant.UserId = userId;

            dbContext.Restaurants.Add(restaurant);
            dbContext.SaveChanges();

            StaticDataManagerUtility.sehirleriDoldur(this);
            StaticDataManagerUtility.IlceleriDoldur(this, restaurantVM.CityId);
            ViewBag.Basarili = true;

            return View("Index", restaurantVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
