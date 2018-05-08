using com.educacionit.ms.pet.dataaccess.Interfaces;
using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Repositories
{
   public  class AdopterRepository : GenericRepository<Adopter>, IAdopterRepository
    {
        public AdopterRepository(PetsDbContext dbContext) : base(dbContext) { }
    }
}
