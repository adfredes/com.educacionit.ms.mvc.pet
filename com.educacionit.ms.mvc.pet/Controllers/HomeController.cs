using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using COM.Educacionit.MS.MVC.Pet.Models;



namespace com.educacionit.ms.mvc.pet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GiveInAdoption ()
        {
            return View ();
        }

        [HttpPost]
        public ActionResult GiveInAdoption (Pet pet)
        {
            ViewBag.Message = String.Concat ("Thank you very much for register to ", pet.Contact.Name);

            return View ();
        }
    }
}