using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.pet.domain.entities
{
    public class Adopter : Person
    {
        public Adopter()
        {
            Adoptions = new HashSet<Adoption>();
        }

        public virtual ICollection<Adoption> Adoptions { get; set; }
    }
}