using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace com.educacionit.ms.pet.domain.entities
{
    public class Owner : Person
    {
        public Owner()
        {
            Pets = new HashSet<Pet>();
        }
        public virtual  ICollection<Pet> Pets { get; set; }
    }
}