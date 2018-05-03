using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Mapping
{
    public class AdopterMap : EntityTypeConfiguration<Adopter>
    {
        public AdopterMap()
        {
            HasKey(x => x.Id);
            ToTable("Adopter");
        }
    }
}
