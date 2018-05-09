using com.educacionit.ms.pet.dataaccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using com.educacionit.ms.pet.dataaccess.Interfaces;

namespace com.educacionit.ms.pet.dataaccess.Repositories
{
    public abstract class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _dbcontext;

        private DbSet<TEntity> Entity { get; set; }

        public GenericRepository(DbContext dbContext)
        {
            this._dbcontext = dbContext;
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
            return Entity.Where(predicate);
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
