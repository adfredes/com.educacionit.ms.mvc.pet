using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.pet.domain.model
    
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Street { get; set; }
        [StringLength(10)]
        public string Zip { get; set; }
        public int Number { get; set; }

        public int idCity { get; set; }
        public City City { get; set; }

        public virtual Person Person { get; set; }
    }
}