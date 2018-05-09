using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using com.educacionit.ms.pet.services.ImplementServices;
using com.educacionit.ms.pet.services.Interfaces;
using COM.Educacionit.MS.MVC.Pet.Models;



namespace com.educacionit.ms.mvc.pet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPetService petService;

        public HomeController(IPetService petService)
        {
            this.petService = petService;
        }

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
        public ActionResult GiveInAdoption (PetModel pet)
        {
            ViewBag.Message = String.Concat ("Thank you very much for register to ", pet.Owner.Name);

            return View ();
        }

        [HttpGet]
        public ActionResult Adopt()
        {            
            ViewBag.PetTypes = Mapper.Map<ICollection<PetTypeModel>>(petService.GetPetTypes());
            return View();
        }

        [HttpGet]
        public ActionResult PetsInAdoption(int?  id = null)
        {
            List<PetModel> pets;            

            if (id.HasValue) {
                pets = Mapper.Map<List<PetModel>>(petService.GetPetsForAdoption(id.Value));                                                   
            }
            else
            {
                pets = Mapper.Map<List<PetModel>>(petService.GetPetsForAdoption());                
            }

            return PartialView(pets);
        }

        [HttpGet]
        public ActionResult AdoptPet (int id)
        {
            AdoptionModel adoption = new AdoptionModel();            
            var pet = Mapper.Map<PetModel>(petService.Find(id));                
            adoption.Pet = pet;
            adoption.Date = DateTime.Now;
            return PartialView(adoption);
        }

        
    }
}