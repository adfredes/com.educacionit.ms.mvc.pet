using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Mapping
{
    public class AdoptionMap : EntityTypeConfiguration<Adoption>
    {
        public AdoptionMap()
        {
            HasKey(x => x.Id);

            HasRequired <Adopter>(x => x.Adopter)
                .WithMany(g => g.Adoptions)
                .HasForeignKey(f => f.IdAdopter)
                .WillCascadeOnDelete(false);

            HasRequired<Pet>(x => x.Pet)
                .WithMany(g => g.Adoptions)
                .HasForeignKey(f => f.IdPet)
                .WillCascadeOnDelete(false);
        }
    }
}
