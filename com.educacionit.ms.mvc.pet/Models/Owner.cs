using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class OwnerModel : PersonModel
    {
        public List<PetModel> Pets { get; set; }
    }
}