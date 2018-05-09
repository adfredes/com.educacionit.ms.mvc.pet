using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Interfaces
{
    public interface IPetRepository : IRepository<Pet>
    {
        IQueryable<Pet> GetPetsForAdoption();
        IQueryable<Pet> GetPetsForAdoption(int idType);
    }
}
