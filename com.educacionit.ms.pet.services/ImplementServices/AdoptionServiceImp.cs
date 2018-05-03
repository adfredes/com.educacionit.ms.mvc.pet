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
    public class AdoptionServiceImp : GenericRepository<Adoption>, IAdoptionService
    {
    }
}
