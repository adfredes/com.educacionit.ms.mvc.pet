using com.educacionit.ms.pet.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.Interfaces
{
    public interface IOwnerService
    {
        IQueryable<Owner> GetAll();
        Owner Find(int id);
        IQueryable<Owner> FindBy(Expression<Func<Owner, bool>> predicate);
        void Add(Owner entity);
        void Delete(Owner entity);
        void Edit(Owner entity);        
    }
}
