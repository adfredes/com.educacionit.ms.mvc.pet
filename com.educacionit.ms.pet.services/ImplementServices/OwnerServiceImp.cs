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
    public class OwnerServiceImp :  IOwnerService
    {
        private IUnitOfWork unitOfWork;

        public OwnerServiceImp(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(Owner entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Owner entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Owner entity)
        {
            throw new NotImplementedException();
        }

        public Owner Find(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Owner> FindBy(Expression<Func<Owner, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Owner> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
