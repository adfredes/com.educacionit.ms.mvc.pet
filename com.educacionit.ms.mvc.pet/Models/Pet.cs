using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class Pet
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PetType Type { get; set; }

        public Owner Owner { get; set; }

        public int Age { get; set; }

        public string Specie { get; set; }

        public byte[] Photo { get; set; }

        public Boolean Adopted { get; set; }        
    }
}