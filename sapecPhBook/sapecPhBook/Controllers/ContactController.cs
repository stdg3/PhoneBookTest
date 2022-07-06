using sapecPhBook.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace sapecPhBook.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ViewResult Index()
        {
            string[] cources = { "s", "a", "d" };
            return View(cources);
        }
        public ViewResult Kayitlar()
        {
            List<Contact> kayitlar = new List<Contact>
            {
                new Contact() {ContactID = 1, Name="dominos delivery", Company="dominos", Number="12345678901"},
                new Contact() {ContactID = 2, Name="pizza hot delivery", Company="pizza hot", Number="12345678902"},
                new Contact() {ContactID = 3, Name="bulls delivery", Company="buls", Number="12345678903"},
                new Contact() {ContactID = 4, Name="isabella delivery", Company="isabella", Number="12345678904"},
                new Contact() {ContactID = 5, Name="pizzamania delivery", Company="pizzamania", Number="12345678905"},
            };
            ViewBag.UrunSayisi = kayitlar.Count;
            return View(kayitlar);
        }
        public ActionResult xDetails(int asd)
        {
            
            return View(asd);
        }
    }
}