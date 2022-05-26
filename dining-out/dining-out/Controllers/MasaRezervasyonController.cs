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
    public class MasaRezervasyonController : Controller
    {
        private readonly ILogger<MasaRezervasyonController> _logger;

        public MasaRezervasyonController(ILogger<MasaRezervasyonController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index(int restaurantId)
        {
            diningoutContext _context = new diningoutContext();
            RestaurantDetayı(restaurantId);
            ViewBag.KisilerData = StaticDataManagerUtility.kisiSayisiListesi();
            return View("Index", new MasaRezervasyonVM(restaurantId));
        }

        [HttpPost]
        [Route("/MasaRezervasyon/RezervasyonYap/{restaurantId:int}")]
        [Authorize]
        public IActionResult RezervasyonYap(int restaurantId, MasaRezervasyonVM masaRezervasyonVM)
        {
            diningoutContext _context = new diningoutContext();
            RestaurantDetayı(restaurantId);
            BookTableRezervation rezervation = new BookTableRezervation();
            rezervation.Description = masaRezervasyonVM.Aciklama;
            rezervation.AttendeeNumber = masaRezervasyonVM.KisiSayisi;
            rezervation.Email = masaRezervasyonVM.Email;
            rezervation.NameLastname = masaRezervasyonVM.IsimSoyisim;
            rezervation.PhoneNumber = masaRezervasyonVM.Telefon;
            rezervation.RestaurantId = restaurantId;
            rezervation.RezervationDate = masaRezervasyonVM.Tarih.Date;
            rezervation.RezervationTime = masaRezervasyonVM.TarihSaat.TimeOfDay;
            rezervation.RezervationCreatedDatetime = DateTime.Now;
            rezervation.RezervationUserId = Converters.currentUserId(this);
            rezervation.RezervationStatus = ConstantUtility.RezervationStatus.NEW.ToString();
            _context.BookTableRezervations.Add(rezervation);
            _context.SaveChanges();

            BookTableAttendee attendee = new BookTableAttendee();
            attendee.BooktableRezervationId = rezervation.Id;
            attendee.UserId = rezervation.RezervationUserId;
            _context.BookTableAttendees.Add(attendee);
            _context.SaveChanges();

            ViewBag.KisilerData = StaticDataManagerUtility.kisiSayisiListesi();
            ViewBag.Basarili = true;
            return View("Index", new MasaRezervasyonVM(restaurantId));
        }

        public void RestaurantDetayı(int restaurantId)
        {
            diningoutContext _context = new diningoutContext();
            Restaurant restaurant = _context.Restaurants.Where(res => res.Id.Equals(restaurantId)).Single();
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
            restaurantVM.Desc = restaurant.Desc;
            restaurantVM.CoverImg = restaurant.CoverImg;
            restaurantVM.SystemDefinitionName = restaurant.SystemDefinitionName;
            ViewBag.Restaurant = restaurantVM;

        }

    }
}
