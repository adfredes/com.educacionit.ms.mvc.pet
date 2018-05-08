using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class CityModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public CountryModel Country { get; set; }
    }
}