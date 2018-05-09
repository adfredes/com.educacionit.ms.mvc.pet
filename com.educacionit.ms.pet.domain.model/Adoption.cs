using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.pet.domain.entities
{
    public class Adoption
    {
        public int Id { get; set; }
        public int IdPet { get; set; }
        public virtual Pet Pet { get; set; }
        public int IdAdopter { get; set; }
        public virtual Adopter  Adopter { get; set; }        
        public DateTime Date { get; set; }
    }
}