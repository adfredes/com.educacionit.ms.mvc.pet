using com.educacionit.ms.pet.dataaccess.Interfaces;
using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Repositories
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        public PetRepository(DbContext dbContext) : base(dbContext) { }

        public IQueryable<Pet> GetPetsForAdoption()
        {            
            return base.FindBy(x => x.Adopted == false);
        }

        public IQueryable<Pet> GetPetsForAdoption(int idType)
        {            
            return base.FindBy(x => x.Adopted == false && x.IdType == idType);
        }
    }
}
