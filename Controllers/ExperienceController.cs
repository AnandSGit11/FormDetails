using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnandPortfolio1.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        public ActionResult Experience()
        {
            ViewBag.Experience = "Hands on Experience on MERN and MEAN stack";
            return View();
        }
    }
}