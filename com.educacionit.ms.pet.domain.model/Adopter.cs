using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.pet.domain.model
{
    public class Adopter : Person
    {
        public virtual ICollection<Adoption> Adoptions { get; set; }
    }
}