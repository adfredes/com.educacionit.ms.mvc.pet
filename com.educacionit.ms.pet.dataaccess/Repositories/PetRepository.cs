using com.educacionit.ms.pet.dataaccess.Interfaces;
using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Repositories
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        public PetRepository(PetsDbContext dbContext) : base(dbContext) { }

        public ICollection<Pet> GetPetsForAdoption()
        {            
            return base.FindBy(x => x.Adopted == false).ToList();
        }

        public ICollection<Pet> GetPetsForAdoption(int idType)
        {            
            return base.FindBy(x => x.Adopted == false && x.IdType == idType).ToList();
        }
    }
}
