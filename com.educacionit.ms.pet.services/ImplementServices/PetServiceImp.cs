using com.educacionit.ms.pet.dataaccess;
using com.educacionit.ms.pet.domain.model;
using com.educacionit.ms.pet.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.ImplementServices
{
    public class PetServiceImp : IPetService
    {
        private UnitOfWork unitOfWork;

        public PetServiceImp()
        {
            unitOfWork = new UnitOfWork();
        }        

        public void Add(Pet entity)
        {
            unitOfWork.RepoPet.Add(entity);
        }

        public void Delete(Pet entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Pet entity)
        {
            throw new NotImplementedException();
        }

        public Pet Find(int id)
        {
            return unitOfWork.RepoPet.Find(id);
        }

        public IQueryable<Pet> FindBy(Expression<Func<Pet, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Pet> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<Pet> GetPetsForAdoption()
        {
            return unitOfWork.RepoPet.FindBy(x => x.Adopted == false)                
                .OrderBy(x => x.Name)
                .ToList();
        }

        public ICollection<Pet> GetPetsForAdoption(int idType)
        {
            
            return unitOfWork.RepoPet.FindBy(x => x.Adopted == false && x.IdType == idType)
                .OrderBy(x => x.Name)
                .ToList();
        }

        public ICollection<PetType> GetPetTypes()
        {
            return unitOfWork.RepoPetType.GetAll().ToList();
        }
    }
}
