using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace com.educacionit.ms.pet.domain.model
{
    public class Owner : Person
    {
        public virtual  ICollection<Pet> Pets { get; set; }
    }
}