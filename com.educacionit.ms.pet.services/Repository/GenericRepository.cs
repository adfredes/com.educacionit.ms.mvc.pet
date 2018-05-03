using com.educacionit.ms.pet.dataaccess;
using com.educacionit.ms.pet.services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.services.Repository
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly PetsDbContext _dbcontext;
        
        private DbSet<TEntity> Entity { get; set; }

        public GenericRepository()
        {
            this._dbcontext = new PetsDbContext();
            this.Entity = this._dbcontext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            Entity.Add(entity);
            Save();
        }

        public void Delete(TEntity entity)
        {
            _dbcontext.Entry<TEntity>(entity).State = EntityState.Deleted;
            Save();
        }

        public void Edit(TEntity entity)
        {
            _dbcontext.Entry<TEntity>(entity).State = EntityState.Modified;
            Save();
        }

        public IQueryable<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            return Entity;
        }

        public TEntity Find(int id)
        {
            return Entity.Find(id);
        }

        public void Save()
        {
            this._dbcontext.SaveChanges();
        }
    }
}
