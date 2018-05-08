using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class PetModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public PetTypeModel Type { get; set; }

        public OwnerModel Owner { get; set; }

        public int Age { get; set; }

        public string Specie { get; set; }

        public byte[] Photo { get; set; }

        public Boolean Adopted { get; set; }        
    }
}