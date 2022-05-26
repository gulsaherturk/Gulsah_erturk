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
    public class DashboardAnasayfaController : Controller
    {
        private readonly ILogger<DashboardAnasayfaController> _logger;

        public DashboardAnasayfaController(ILogger<DashboardAnasayfaController> logger)
        {
            _logger = logger;
        }

        [Authorize]
        public IActionResult Index()
        {
            int userId=Converters.currentUserId(this);
            diningoutContext dbContext = new diningoutContext();
            User user = dbContext.Users.Where(user => user.Id.Equals(userId)).Single();
            List<BookTableRezervation> bookTableRezervations = new List<BookTableRezervation>();
            List<int> bookTableRezervationIds = new List<int>();
            if (ConstantUtility.UserType.CUSTOMER.ToString().Equals(user.UserType))
            {
                bookTableRezervations = dbContext.BookTableRezervations.Where(book => book.RezervationUserId.Equals(user.Id)).ToList();
                
                foreach (BookTableRezervation bookTable in bookTableRezervations)
                {
                    bookTableRezervationIds.Add(bookTable.Id);
                }

                List<BookTableAttendee> bookTableAttendees = dbContext.BookTableAttendees.Where(attendee => attendee.UserId.Equals(user.Id)).ToList();
                foreach(BookTableAttendee bookTableAttendee in bookTableAttendees)
                {
                    if (!bookTableRezervationIds.Contains(bookTableAttendee.BooktableRezervation.Id))
                    {
                        bookTableRezervations.Add(bookTableAttendee.BooktableRezervation);
                        bookTableRezervationIds.Add(bookTableAttendee.BooktableRezervation.Id);
                    }
                }
            }
            else
            {
                List<int> restIDList = dbContext.Restaurants.Where(rest => rest.UserId.Equals(user.Id)).Select(rest=>rest.Id).ToList();
                bookTableRezervations = dbContext.BookTableRezervations.Where(book => restIDList.Contains(book.RestaurantId)).ToList();
            }

            DashboardAnasayfaVM dashboardAnasayfaVM = new DashboardAnasayfaVM();
            List<BookTableRezervationVM> bookTableActiveRezervationVMs = new List<BookTableRezervationVM>();
            List<BookTableRezervationVM> bookTableNewRezervationVMs = new List<BookTableRezervationVM>();
            List<BookTableRezervationVM> bookTableClosedRezervationVMs = new List<BookTableRezervationVM>();
            dashboardAnasayfaVM.BookTableActiveRezervations = bookTableActiveRezervationVMs;
            dashboardAnasayfaVM.BookTableNewRezervations = bookTableNewRezervationVMs;
            dashboardAnasayfaVM.BookTableClosedRezervations = bookTableClosedRezervationVMs;

            foreach (BookTableRezervation bookTableRezervation in bookTableRezervations)
            {
                BookTableRezervationVM rezervationVM = Converters.convertModel(bookTableRezervation);

                if (ConstantUtility.RezervationStatus.NEW.ToString().Equals(bookTableRezervation.RezervationStatus))
                {
                    dashboardAnasayfaVM.BookTableNewRezervations.Add(rezervationVM);
                }
                if (ConstantUtility.RezervationStatus.APPROVED.ToString().Equals(bookTableRezervation.RezervationStatus))
                {
                    dashboardAnasayfaVM.BookTableActiveRezervations.Add(rezervationVM);
                }
                if (ConstantUtility.RezervationStatus.CLOSED.ToString().Equals(bookTableRezervation.RezervationStatus)
                    || ConstantUtility.RezervationStatus.CANCELLED.ToString().Equals(bookTableRezervation.RezervationStatus))
                {
                    dashboardAnasayfaVM.BookTableClosedRezervations.Add(rezervationVM);
                }
                
            }

            return View(dashboardAnasayfaVM);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Hata()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
