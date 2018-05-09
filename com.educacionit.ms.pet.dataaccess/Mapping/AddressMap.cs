using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Mapping
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            HasKey(x => x.Id);
            HasRequired<City>(x => x.City)
                .WithMany( g => g.Addresses)
                .HasForeignKey(x => x.idCity)
                .WillCascadeOnDelete(false);
        }
    }
}
