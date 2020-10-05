using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//test
namespace ExerciseProject.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public AppDbContext AppDbContext { get; set; }
        public RepositoryBase(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public T Delete(object id)
        {
            var entity = AppDbContext.Set<T>().Find(id);
            if (entity == null)
            {
                return entity;
            }
            AppDbContext.Set<T>().Remove(entity);
            AppDbContext.SaveChanges();
            return entity;
        }

        public T Insert(T item)
        {
            AppDbContext.Set<T>().Add(item);
            AppDbContext.SaveChanges();
            return item;
        }


        public IQueryable<T> SelectAll()
        {
            return AppDbContext.Set<T>();
        }

        public T SelectById(object id)
        {
            return AppDbContext.Set<T>().Find(id);
        }

        public T Update(T item)
        {
            AppDbContext.Entry(item).State = EntityState.Modified;
            AppDbContext.SaveChanges();
            return item;
        }
    }
}
