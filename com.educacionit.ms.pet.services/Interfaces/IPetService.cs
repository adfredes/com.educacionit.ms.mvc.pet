using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.Interfaces
{
    public interface IPetService : IRepository<Pet>
    {
        ICollection<Pet> GetPetsForAdoption();
        ICollection<Pet> GetPetsForAdoption(int idType);
    }
}
