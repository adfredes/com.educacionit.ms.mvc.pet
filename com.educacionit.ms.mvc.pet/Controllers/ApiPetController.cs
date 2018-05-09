using AutoMapper;
using com.educacionit.ms.pet.services.ImplementServices;
using com.educacionit.ms.pet.services.Interfaces;
using COM.Educacionit.MS.MVC.Pet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace com.educacionit.ms.mvc.pet.Controllers
{
    public class ApiPetController : ApiController
    {
        private readonly IPetService petService;


        public ApiPetController(IPetService petService)
        {

            this.petService = petService;
        }

        [Route("api/PetTypes")]
        public IHttpActionResult GetPetTypes()
        {
            return Ok(Mapper.Map<List<PetTypeModel>>(petService.GetPetTypes()));
        }

        [Route("api/Pets")]
        public IHttpActionResult GetPets()
        {

            return Ok(Mapper.Map<List<PetModel>>(petService.GetPetsForAdoption()));
        }

        [Route("api/PetType/{id}/Pets")]
        public IHttpActionResult GetPetsByType(int id)
        {

            return Ok(Mapper.Map<List<PetModel>>(petService.GetPetsForAdoption(id)));
        }
    }
}
