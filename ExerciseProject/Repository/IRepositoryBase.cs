using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        IQueryable<T> SelectAll();
        T SelectById(object id);
        T Insert(T item);
        T Update(T item);
        T Delete(object id);
    }
}
