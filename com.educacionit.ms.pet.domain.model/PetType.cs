using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.pet.domain.entities
{
    public class PetType
    {
        public PetType()
        {
            Pets = new HashSet<Pet>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}