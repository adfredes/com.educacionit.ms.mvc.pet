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
    public class AdopterServiceImp : IAdopterService
    {
        public AdopterServiceImp()
        {

        }

        public AdopterServiceImp(PetsDbContext context)
        {

        }

        public void Add(Adopter entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Adopter entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Adopter entity)
        {
            throw new NotImplementedException();
        }

        public Adopter Find(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adopter> FindBy(Expression<Func<Adopter, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Adopter> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
