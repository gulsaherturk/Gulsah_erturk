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
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace dining_out.Controllers
{
    public class LoginController : Controller
    {
        diningoutContext dbContext = new diningoutContext();
        private readonly ILogger<LoginController> _logger;

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GirisYap()
        {
            return View(new LoginVM());
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(LoginVM loginVm)
        {
            string ReturnUrl = HttpContext.Request.Query["ReturnUrl"];
            User loginedUser = dbContext.Users.SingleOrDefault(user => user.UserName.Equals(loginVm.Username) && user.Password.Equals(loginVm.Password));
            if (loginedUser!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,loginVm.Username),
                    new Claim(ClaimTypes.Role,loginedUser.UserType),
                    new Claim(ClaimTypes.NameIdentifier,loginedUser.Id.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,principal);

                if (!String.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
                    return Redirect(ReturnUrl);
                else
                    return RedirectToAction("Index", "Anasayfa");

            }
            return View(new LoginVM());
        }

        [HttpGet]
        public IActionResult CikisYap()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Anasayfa");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
