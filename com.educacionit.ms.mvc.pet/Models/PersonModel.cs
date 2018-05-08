using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace COM.Educacionit.MS.MVC.Pet.Models
{
    public class PersonModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public AddressModel Address { get; set; }

        public byte[] Photo { get; set; }
    }
}