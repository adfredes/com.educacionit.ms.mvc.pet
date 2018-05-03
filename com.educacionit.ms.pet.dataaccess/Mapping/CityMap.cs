using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Mapping
{
    public class CityMap: EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            HasKey(x => x.Id);

            HasRequired<Country>(x => x.Country)
                .WithMany(g => g.Cities)
                .HasForeignKey(f => f.IdCountry)
                .WillCascadeOnDelete(false);

        }
    }
}
