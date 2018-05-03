using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Mapping
{
    public class PetMap : EntityTypeConfiguration<Pet>
    {
        public PetMap()
        {
            HasKey(x => x.Id);

            HasRequired<Owner>(x => x.Owner)
                .WithMany(g => g.Pets)
                .HasForeignKey(f => f.IdOwner)
                .WillCascadeOnDelete(false);

            HasRequired<PetType>(x => x.Type)
                .WithMany(g=>g.Pets)
                .HasForeignKey(f => f.IdType)
                .WillCascadeOnDelete(true);
        }
    }
}
