using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using dining_out.Models.ViewModels;
using dining_out.Models.DbModels;
using dining_out.Utility;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace dining_out.Controllers
{
    public class DashboardRestaurantMenuDuzenleController : Controller
    {
        private readonly ILogger<DashboardRestaurantMenuDuzenleController> _logger;
        private readonly IHostingEnvironment _hostingEnvironment;

        public DashboardRestaurantMenuDuzenleController(ILogger<DashboardRestaurantMenuDuzenleController> logger, IHostingEnvironment hostingEnvironment)
        {
            _logger = logger;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Index(int restaurantId)
        {
            diningoutContext _context = new diningoutContext();
            Restaurant restaurant = _context.Restaurants.Where(res => res.Id.Equals(restaurantId)).Single();
            RestaurantVM restaurantVM = Converters.convertModel(restaurant);

            MenuVm menu;
            if (restaurantVM.Menu != null)
            {
                menu = restaurantVM.Menu;
            }
            else
            {
                menu = new MenuVm();
            }

            MenuItemCategoryVM menuItemCategoryVM = new MenuItemCategoryVM();
            MenuItemVM menuItemVM = new MenuItemVM();
            menuItemVM.Category = menuItemCategoryVM;
            menuItemVM.Price = 10;
            menu.Restaurant = restaurantVM;
            menu.RestaurantId = restaurantId;
            menu.menuItem = menuItemVM;

            menu.MenuItemsDictionary = new Dictionary<string, List<MenuItemVM>>();
            foreach (MenuItemVM item in menu.MenuItems)
            {
                if (menu.MenuItemsDictionary.ContainsKey(item.Category.CategoryName))
                {
                    menu.MenuItemsDictionary[item.Category.CategoryName].Add(item);
                }
                else
                {
                    menu.MenuItemsDictionary.Add(item.Category.CategoryName, new List<MenuItemVM>());
                    menu.MenuItemsDictionary[item.Category.CategoryName].Add(item);
                }
            }

            return View(menu);
        }

        [HttpPost]
        [Authorize]
        public IActionResult MenuItemEkle(int restaurantId, int Id,MenuVm menuVm)
        {
            diningoutContext _context = new diningoutContext();
            Restaurant restaurant = _context.Restaurants.Where(res => res.Id.Equals(restaurantId)).Single();
            RestaurantVM restaurantVM = Converters.convertModel(restaurant);

            MenuItemVM menuItem = menuVm.menuItem;
            menuVm.Restaurant = restaurantVM;
            menuVm.RestaurantId = restaurantId;
            if (!Request.Form.ContainsKey("mainSaveButton"))
            {
                menuVm.MenuItems.Add(menuItem);
            }
            
            MenuItemCategoryVM menuItemCategoryVM = new MenuItemCategoryVM();
            MenuItemVM menuItemVM = new MenuItemVM();
            menuItemVM.Category = menuItemCategoryVM;
            menuItemVM.Price = 10;

            menuVm.menuItem = menuItemVM;

            menuVm.MenuItemsDictionary = new Dictionary<string, List<MenuItemVM>>();
            foreach (MenuItemVM item in menuVm.MenuItems)
            {
                if (menuVm.MenuItemsDictionary.ContainsKey(item.Category.CategoryName))
                {
                    menuVm.MenuItemsDictionary[item.Category.CategoryName].Add(item);
                }
                else
                {
                    menuVm.MenuItemsDictionary.Add(item.Category.CategoryName, new List<MenuItemVM>());
                    menuVm.MenuItemsDictionary[item.Category.CategoryName].Add(item);
                }
            }

            if (Request.Form.ContainsKey("mainSaveButton"))
            {
                veritabaninaKaydet(menuVm);
            }

            return PartialView("_AllMenuItems", menuVm);
        }

        private void veritabaninaKaydet(MenuVm menuVm)
        {
            diningoutContext dbContext = new diningoutContext();
            menuVm.MenuItemsDictionary = new Dictionary<string, List<MenuItemVM>>();
            foreach (MenuItemVM item in menuVm.MenuItems)
            {
                if (menuVm.MenuItemsDictionary.ContainsKey(item.Category.CategoryName))
                {
                    menuVm.MenuItemsDictionary[item.Category.CategoryName].Add(item);
                }
                else
                {
                    menuVm.MenuItemsDictionary.Add(item.Category.CategoryName, new List<MenuItemVM>());
                    menuVm.MenuItemsDictionary[item.Category.CategoryName].Add(item);
                }
            }

            Menu menu = new Menu();
            menu.Description = menuVm.Description;
            menu.MenuName = menuVm.MenuName;
            menu.RestaurantId = menuVm.RestaurantId;
            menu.Statu = "ACTIVE";
            dbContext.Menus.Add(menu);
            dbContext.SaveChanges();

            foreach (string key in menuVm.MenuItemsDictionary.Keys)
            {
                List<MenuItemVM> menuItemVMs = menuVm.MenuItemsDictionary[key];
                MenuItemCategory menuItemCategory = new MenuItemCategory();
                menuItemCategory.CategoryName = key;
                dbContext.MenuItemCategories.Add(menuItemCategory);
                dbContext.SaveChanges();

                foreach (MenuItemVM itemVM in menuItemVMs)
                {
                    MenuItem menuItem = new MenuItem();
                    menuItem.CategoryId = menuItemCategory.Id;
                    menuItem.MenuId = menu.Id;
                    menuItem.MenuItemDescription = itemVM.MenuItemDescription;
                    menuItem.MenuItemIngredients = itemVM.MenuItemIngredients;
                    menuItem.MenuItemName = itemVM.MenuItemName;
                    menuItem.Price = itemVM.Price;
                    dbContext.MenuItems.Add(menuItem);
                    dbContext.SaveChanges();
                }

            }
            ViewBag.Basarili = true;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
