using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using sapecPhBook.Models;

namespace sapecPhBook.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }
        public ViewResult User()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ContactReg()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ContactReg(string Name, string Number, string Company)
        {
            List<Contact> kayitlar = new List<Contact>
            {
                new Contact() {ContactID = 1, Name=Name, Company=Company, Number=Number}
            };
            return View("RegedUser", kayitlar);

        }
    }
}