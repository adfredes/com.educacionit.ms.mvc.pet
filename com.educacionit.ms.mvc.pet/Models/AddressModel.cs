using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class AddressModel
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Zip { get; set; }
        public int Number { get; set; }
        public CityModel City { get; set; }
    }
}