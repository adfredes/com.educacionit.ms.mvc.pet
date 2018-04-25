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

        public ActionResult Index(int? id = null)
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
            ViewBag.Message = String.Concat ("Thank you very much for register to ", pet.Owner.Name);

            return View ();
        }

        [HttpGet]
        public ActionResult Adopt()
        {
            ViewBag.PetTypes = getPetTypes();
            return View();
        }

        [HttpGet]
        public ActionResult PetsInAdoption(int?  id = null)
        {
            List<Pet> pets;

            if (id.HasValue) {                 
                pets = getPets();
                var filterPets = pets.Where(x => x.Type.Id == id).ToList();
                return PartialView(filterPets);
            }
            else
            {
                pets = new List<Pet>();
                return PartialView(pets);
            }
        }

        [HttpGet]
        public ActionResult AdoptPet (int id)
        {
            Adoption adoption = new Adoption();
            var pet = getPets().FirstOrDefault(x => x.Id == id);
            adoption.Pet = pet;
            adoption.Date = DateTime.Now;
            return PartialView(adoption);
        }


        private List<Pet> getPets()
        {
            return new List<Pet>{new Pet() {Id = 1, Name = "Max", Age = 4, Specie = "Pug", Type = new PetType{ Name = "Perro" , Id = 1} },
                new Pet() {Id = 2, Name = "Olivia", Age = 10, Specie = "Siames", Type = new PetType{ Name = "Gato", Id = 2 } }};
        }

        private List<PetType> getPetTypes()
        {
            return new List<PetType> { new PetType { Name = "Perro", Id = 1 }, new PetType { Name = "Gato", Id = 2 } };                
        }
    }
}