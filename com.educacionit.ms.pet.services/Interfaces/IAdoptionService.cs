using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.Interfaces
{
    public interface IAdoptionService
    {
        IQueryable<Adoption> GetAll();
        Adoption Find(int id);
        IQueryable<Adoption> FindBy(Expression<Func<Adoption, bool>> predicate);
        void Add(Adoption entity);
        void Delete(Adoption entity);
        void Edit(Adoption entity);        
    }
}
