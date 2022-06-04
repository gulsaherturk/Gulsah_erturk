using Microsoft.AspNetCore.Mvc;
using RezervasyonWebApp.Business.Abstract;
using RezervasyonWebApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezervasyonWebApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IBiletService _biletService;
        public AdminController(IBiletService biletService)
        {
            this._biletService = biletService;

        }
        public IActionResult AdminList()
        {
            return View(new BiletGuzergah()
            {
                Bilets = _biletService.GetAll()
            });
        }
        public IActionResult IptalBilet(int biletId)
        {
            var bilet = _biletService.GetById(biletId);
            if (bilet!=null)
            {
                _biletService.Delete(bilet);

            }
            return RedirectToAction("AdminList");
        }
    }
}
