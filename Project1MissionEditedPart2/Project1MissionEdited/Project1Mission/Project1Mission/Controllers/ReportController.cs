using Project1Mission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project1Mission.Controllers
{
    public class ReportController : Controller
    {
        public static List<HourlyReport> lstHourlyReport = new List<HourlyReport>();

        // GET: Report
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HourlyReport userResponse)
        {
            if (ModelState.IsValid)
            {
               
                lstHourlyReport.Add(userResponse);
               
                return View();
            }
            else
            {
                //Validation Error
                return View();
            }
        }

        public ActionResult DisplayData()
        {
            if (lstHourlyReport.Count == 0)
            {
                ViewBag.Nothing = "No data is available to present!  Please add in some data.";
            }

            return View();
        }
    }
}