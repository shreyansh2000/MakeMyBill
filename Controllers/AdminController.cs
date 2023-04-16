using MakeMyBill.Models;
using Microsoft.AspNetCore.Mvc;

namespace MakeMyBill.Controllers
{
    public class AdminController : Controller
    {
        #region Default
        private readonly InvoGenDbContext bkDb;
        private readonly IWebHostEnvironment henv;

        public AdminController(InvoGenDbContext bkDB, IWebHostEnvironment henv)
        {
            bkDb = bkDB;
            this.henv = henv;
        }
        #endregion Default
        public IActionResult AdminHome()
        {
            return View();
        }

        public IActionResult AdminViewCompanyDetails()
        {
            var companydetails = bkDb.CompanyMasters.ToList();
            return View(companydetails);
        }

        public IActionResult AdminViewComplainDetails()
        {
            var complaindetails = bkDb.ComplainMasters.ToList();
            var companydetails = bkDb.CompanyMasters.ToList();
            ViewBag.compdetails = companydetails;
            return View(complaindetails);
        }

        public IActionResult AdminViewFeedbackDetails()
        {
            var feedbackdetails = bkDb.FeedbackMasters.ToList();
            var companydetails = bkDb.CompanyMasters.ToList();
            ViewBag.compdetails = companydetails;
            return View(feedbackdetails);
        }
    }
}
