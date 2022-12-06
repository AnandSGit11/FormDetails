using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnandPortfolio1.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        public ActionResult Skills()
        {

            ViewBag.ClientSide = "React JS & Bootsrap";
            ViewBag.BackendSide = "Node JS";
            ViewBag.Database = "MongoDB";
            return View();
        }
    }
}