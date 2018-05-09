using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess.Interfaces
{
    public interface IUnitOfWork
    {
        IAdopterRepository RepoAdopter { get; }
        
        IAdoptionRepository RepoAdoption { get; }

        IOwnerRepository RepoOwner { get; }
        
        IPetRepository RepoPet { get; }
        
        IPetTypeRepository RepoPetType { get; }        
    }
}
