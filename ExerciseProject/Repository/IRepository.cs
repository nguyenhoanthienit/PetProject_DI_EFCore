using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> SelectAll();
        T SelectById(object id);
        void Insert(T item);
        void Update(T item);
        void Delete(object id);
        void Save();
    }
}
