using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sapecTestVAv2.Models;

namespace sapecTestVAv2.Controllers
{
    public class HomeController : Controller
    {
        private PhBookContext context = new PhBookContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(context.Contacts.ToList());
        }
    }
}