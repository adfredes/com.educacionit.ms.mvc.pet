using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.Interfaces
{
    public interface IPetService
    {
        IQueryable<Pet> GetAll();
        Pet Find(int id);
        IQueryable<Pet> FindBy(Expression<Func<Pet, bool>> predicate);
        void Add(Pet entity);
        void Delete(Pet entity);
        void Edit(Pet entity);        
        ICollection<Pet> GetPetsForAdoption();
        ICollection<Pet> GetPetsForAdoption(int idType);
        ICollection<PetType> GetPetTypes();
    }
}
