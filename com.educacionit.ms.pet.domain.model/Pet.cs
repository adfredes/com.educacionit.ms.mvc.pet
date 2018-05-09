using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace com.educacionit.ms.pet.domain.entities
{
    public class Pet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int IdType { get; set; }
        public virtual PetType Type { get; set; }

        public int IdOwner { get; set; }
        public virtual Owner Owner { get; set; }

        public int Age { get; set; }

        public string Specie { get; set; }

        public byte[] Photo { get; set; }

        public Boolean Adopted { get; set; }

        public virtual ICollection<Adoption> Adoptions { get; set; }
    }
}