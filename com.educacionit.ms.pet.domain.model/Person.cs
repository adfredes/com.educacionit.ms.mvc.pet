using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.educacionit.ms.pet.domain.model
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
        
        public virtual Address Address { get; set; }

        public byte[] Photo { get; set; }
    }
}