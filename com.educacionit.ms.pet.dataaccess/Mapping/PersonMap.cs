using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Mapping
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            HasKey(x => x.Id);
            HasRequired(x => x.Address)
                .WithRequiredPrincipal(ad => ad.Person)
                .WillCascadeOnDelete(true);
        }
    }
}
