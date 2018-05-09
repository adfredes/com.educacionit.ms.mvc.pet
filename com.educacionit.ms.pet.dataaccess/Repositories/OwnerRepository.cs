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
    public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(DbContext dbContext) : base(dbContext) { }
    }
}
