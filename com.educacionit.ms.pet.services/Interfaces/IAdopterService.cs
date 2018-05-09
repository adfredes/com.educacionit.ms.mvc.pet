using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.Interfaces
{
    public interface IAdopterService
    {
        IQueryable<Adopter> GetAll();
        Adopter Find(int id);
        IQueryable<Adopter> FindBy(Expression<Func<Adopter, bool>> predicate);
        void Add(Adopter entity);
        void Delete(Adopter entity);
        void Edit(Adopter entity);
        
    }
}
