using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public AppDbContext AppDbContext { get; set; }
        public RepositoryBase(AppDbContext appDbContext)
        {
            this.AppDbContext = appDbContext;
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Insert(T item)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> SelectAll()
        {
            return this.AppDbContext.Set<T>();
        }

        public T SelectById(object id)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
