using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class AdoptionModel
    {
        public int Id { get; set; }
        public PetModel Pet { get; set; }
        public AdopterModel  Adopter { get; set; }
        public DateTime Date { get; set; }
    }
}