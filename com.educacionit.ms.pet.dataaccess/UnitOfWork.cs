using com.educacionit.ms.pet.dataaccess.Interfaces;
using com.educacionit.ms.pet.dataaccess.Repositories;
using com.educacionit.ms.pet.domain.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.educacionit.ms.pet.dataaccess
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private bool disposed;
        private readonly DbContext _dbContext;
        private IAdopterRepository _repoAdopter;
        private IAdoptionRepository _repoAdoption;
        private IOwnerRepository _repoOwner;
        private IPetRepository _repoPet;
        private IPetTypeRepository _repoPetType;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            disposed = true;
        }

        public UnitOfWork(DbContext dbcontext)
        {
            this._dbContext = dbcontext;
        }

        //public UnitOfWork()
        //{
        //    this._dbContext = new PetsDbContext();
        //}       

        public IAdopterRepository RepoAdopter
        {
            get
            {
                if (_repoAdopter == null)
                    _repoAdopter = new AdopterRepository(_dbContext);
                return _repoAdopter;

            }
        }

        public IAdoptionRepository RepoAdoption
        {
            get
            {
                if (_repoAdoption == null)
                    _repoAdoption = new AdoptionRepository(_dbContext);
                return _repoAdoption;
            }
        }

        public IOwnerRepository RepoOwner
        {
            get
            {
                if (_repoOwner == null)
                    _repoOwner = new OwnerRepository(_dbContext);
                return _repoOwner;
            }
        }

        public IPetRepository RepoPet
        {
            get
            {
                if (_repoPet == null)
                    _repoPet = new PetRepository(_dbContext);
                return _repoPet;
            }
        }

        public IPetTypeRepository RepoPetType
        {
            get
            {
                if (_repoPetType == null)
                    _repoPetType = new PetTypeRepository(_dbContext);
                return _repoPetType;
            }
        }

    }
}
