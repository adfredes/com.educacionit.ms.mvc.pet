using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class Adoption
    {
        public int Id { get; set; }
        public Pet Pet { get; set; }
        public Adopter  Adopter { get; set; }
        public DateTime Date { get; set; }
    }
}