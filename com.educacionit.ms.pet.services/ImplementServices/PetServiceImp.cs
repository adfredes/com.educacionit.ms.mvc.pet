using com.educacionit.ms.pet.domain.model;
using com.educacionit.ms.pet.services.Interfaces;
using com.educacionit.ms.pet.services.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.ImplementServices
{
    public class PetServiceImp : GenericRepository<Pet>, IPetService
    {
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
