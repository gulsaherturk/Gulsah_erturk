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
    public class AnasayfaController : Controller
    {
        private readonly ILogger<AnasayfaController> _logger;

        public AnasayfaController(ILogger<AnasayfaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            sehirleriDoldur();
            kisiSayisiDoldur();
            istanbulIlceleriDoldur();
            //Varsayılan olarak Istanbul,Kadıköy ve 2 kişilik arama parametreleri seçili olarak geliyor.
            RestaurantSearchVM sample = new RestaurantSearchVM();
            sample.BookTableDate = DateTime.Now;
            sample.Capacity = 2;
            sample.CityId = "34";
            sample.DistrictId = "22";
            return View("Index", sample);
        }

        [HttpGet]
        public IActionResult RestaurantSearch(RestaurantSearchVM restaurantSearchVM)
        {
            sehirleriDoldur();
            kisiSayisiDoldur();
            istanbulIlceleriDoldur();
            restaurantAra(restaurantSearchVM);
            return View("Restaurant", restaurantSearchVM);
        }

        private void restaurantAra(RestaurantSearchVM restaurantSearchVM)
        {
            diningoutContext _context = new diningoutContext();
            List<RestaurantVM> restaurants = new List<RestaurantVM>();
            IQueryable<Restaurant> restaurantsQuery = _context.Restaurants
                                .Where(res => res.DistrictId.Equals(Int32.Parse(restaurantSearchVM.DistrictId.ToString())))
                                .Where(res => res.CityId.Equals(Int32.Parse(restaurantSearchVM.CityId.ToString())));
            if (restaurantSearchVM.Name != null)
            {
                restaurantsQuery=restaurantsQuery.Where(res => res.Name.Contains(restaurantSearchVM.Name) || res.SystemDefinitionName.Contains(restaurantSearchVM.Name));
            }

            List<Restaurant> restaurantsList = restaurantsQuery.ToList<Restaurant>();
            foreach(Restaurant restaurant in restaurantsList)
            {
                if (tarihUygunluguYokSa(restaurant,restaurantSearchVM, _context))
                {
                    continue;
                }
                RestaurantVM restaurantVM = new RestaurantVM();
                restaurantVM.Id = restaurant.Id;
                restaurantVM.Address = restaurant.Address;
                restaurantVM.Capacity = restaurant.Capacity;
                restaurantVM.City = restaurant.City;
                restaurantVM.CityId = restaurant.CityId.ToString();
                restaurantVM.District = restaurant.District;
                restaurantVM.DistrictId = restaurant.DistrictId.ToString();
                restaurantVM.Logo = restaurant.Logo;
                restaurantVM.Name = restaurant.Name;
                restaurantVM.CoverImg = restaurant.CoverImg;
                restaurantVM.SystemDefinitionName = restaurant.SystemDefinitionName;
                if (restaurant.Desc != null && restaurant.Desc.Length > 100)
                {
                    restaurantVM.Desc = restaurant.Desc.Substring(0, 100);
                }
                else
                {
                    restaurantVM.Desc = restaurant.Desc;
                }

                List<BookTableRezervation> bookTableRezervations = restaurant.BookTableRezervations.OrderBy(book => book.RezervationCreatedDatetime).ToList();
                if(bookTableRezervations!=null && bookTableRezervations.Count > 0)
                {
                    DateTime rezervationCreatedDatetime = bookTableRezervations[0].RezervationCreatedDatetime;
                    TimeSpan difference = DateTime.Now - rezervationCreatedDatetime;
                    restaurantVM.LastRezervationText = "Son rezervasyon "+ difference.TotalMinutes + " dakika önce";
                }
                else
                {
                    restaurantVM.LastRezervationText = "Henüz rezervasyon alınmamış.";
                }

                restaurants.Add(restaurantVM);
            }

            ViewBag.Restaurants = restaurants;

        }

        private bool tarihUygunluguYokSa(Restaurant restaurant, RestaurantSearchVM restaurantSearchVM, diningoutContext _context)
        {
            TimeSpan restaurantSearchTime = restaurantSearchVM.BookTableDate.TimeOfDay;
            TimeSpan restaurantSearchTime2HoursLater = restaurantSearchTime + TimeSpan.FromHours(2);
            TimeSpan restaurantSearchTime2HoursEarlier = restaurantSearchTime - TimeSpan.FromHours(2);

            int? sumAttendees = _context.BookTableRezervations
                .Where(book=>book.RezervationStatus.Equals(ConstantUtility.RezervationStatus.APPROVED.ToString()))
                .Where(book => book.RestaurantId.Equals(restaurant.Id))
                .Where(book => DateTime.Compare(book.RezervationDate, restaurantSearchVM.BookTableDate.Date) == 0)
                .Where(book => TimeSpan.Compare(book.RezervationTime, restaurantSearchTime2HoursEarlier) == 1)
                .Where(book => TimeSpan.Compare(restaurantSearchTime2HoursLater, book.RezervationTime) == 1)
                .Sum(book => book.AttendeeNumber);

            Console.WriteLine(sumAttendees);

            if (restaurantSearchVM.Capacity<=(restaurant.Capacity- sumAttendees))
            {
                return false;
            }
            return true;                   
        }

        public void kisiSayisiDoldur()
        {
            ViewBag.KisilerData = StaticDataManagerUtility.kisiSayisiListesi();
        }

        public void sehirleriDoldur()
        {
            StaticDataManagerUtility.sehirleriDoldur(this);
        }

        public void istanbulIlceleriDoldur()
        {
            StaticDataManagerUtility.IlceleriDoldur(this, "34");
        }

        // cityId : CityId
        [HttpPost]
        public JsonResult GetDistrictiesByCity(string cityId)
        {
            return Json(StaticDataManagerUtility.ilceBul(cityId));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
