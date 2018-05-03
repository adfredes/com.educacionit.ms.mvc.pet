using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.pet.domain.model
{
    public class City
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [ForeignKey("Country")]
        public int IdCountry { get; set; }        
        public Country Country { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}