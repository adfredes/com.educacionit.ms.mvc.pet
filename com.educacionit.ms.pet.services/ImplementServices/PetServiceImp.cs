using com.educacionit.ms.pet.dataaccess;
using com.educacionit.ms.pet.dataaccess.Interfaces;
using com.educacionit.ms.pet.domain.entities;
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
        private IUnitOfWork unitOfWork;

        public PetServiceImp(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }        

        public void Add(Pet entity)
        {
            unitOfWork.RepoPet.Add(entity);
        }

        public void Delete(Pet entity)
        {
            unitOfWork.RepoPet.Delete(entity);
        }

        public void Edit(Pet entity)
        {
            unitOfWork.RepoPet.Edit(entity);
        }

        public Pet Find(int id)
        {
            return unitOfWork.RepoPet.Find(id);
        }

        public IQueryable<Pet> FindBy(Expression<Func<Pet, bool>> predicate)
        {
            return unitOfWork.RepoPet.FindBy(predicate);
        }

        public IQueryable<Pet> GetAll()
        {
            return unitOfWork.RepoPet.GetAll();
        }

        public ICollection<Pet> GetPetsForAdoption()
        {
            return FindBy(x => x.Adopted == false)                
                .OrderBy(x => x.Name)                
                .ToList();
        }

        public ICollection<Pet> GetPetsForAdoption(int idType)
        {            
            return FindBy(x => x.Adopted == false && x.IdType == idType)                                
                .OrderBy(x => x.Name)                
                .ToList();
        }

        public ICollection<PetType> GetPetTypes()
        {
            return unitOfWork.RepoPetType.GetAll().ToList();
        }
    }
}
