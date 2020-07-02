using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public AppDbContext Model { get; set; }
        public Repository(AppDbContext model)
        {
            this.Model = model;
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
            return this.Model.Set<T>();
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
