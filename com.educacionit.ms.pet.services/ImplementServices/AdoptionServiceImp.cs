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
    public class AdoptionServiceImp : IAdoptionService
    {
        private IUnitOfWork unitOfWork;

        public AdoptionServiceImp(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(Adoption entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Adoption entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Adoption entity)
        {
            throw new NotImplementedException();
        }

        public Adoption Find(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adoption> FindBy(Expression<Func<Adoption, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adoption> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
