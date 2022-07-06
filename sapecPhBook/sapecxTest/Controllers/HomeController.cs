using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sapecxTest.Models;

namespace sapecxTest.Controllers
{
    public class HomeController : Controller
    {
        private PhContext context = new PhContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(context.xRegs.ToList());
        }
    }
}