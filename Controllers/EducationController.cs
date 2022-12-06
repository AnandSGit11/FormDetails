using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnandPortfolio1.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult Education()
        {
            ViewBag.SchoolName = "Montfort";
            ViewBag.SchoolPlace = "Chennai";
            ViewBag.SchoolPercentage = 78;
            ViewBag.UgCollegeName = "University of madras";
            ViewBag.CollegePercentage = 82;
            ViewBag.CollegeStream = "Computer Science";
            ViewBag.PgCollegeName = "Anna University";
            ViewBag.CollegePercentage = 85;
            ViewBag.CollegeStream = "Computer application";
            return View();
        }
    }
}