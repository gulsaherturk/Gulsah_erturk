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
using Microsoft.AspNetCore.Authorization;

namespace dining_out.Controllers
{
    public class DashboardRestaurantController : Controller
    {
        private readonly ILogger<DashboardRestaurantController> _logger;

        public DashboardRestaurantController(ILogger<DashboardRestaurantController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            int userId = Converters.currentUserId(this);
            diningoutContext dbContext = new diningoutContext();
            List<Restaurant> restaurants = dbContext.Restaurants.Where(res => res.UserId.Equals(userId)).ToList();
            List<RestaurantVM> restaurantVMs = new List<RestaurantVM>();

            foreach(Restaurant restaurant in restaurants)
            {
                restaurantVMs.Add(Converters.convertModel(restaurant));
            }

            DashboardRestaurantVM dashboardRestaurantVM = new DashboardRestaurantVM();
            dashboardRestaurantVM.Restaurants = restaurantVMs;
            return View(dashboardRestaurantVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
