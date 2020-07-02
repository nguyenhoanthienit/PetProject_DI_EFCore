using ExerciseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public interface IStudentRepository : IRepositoryBase<Student>
    {
        Schedule GetSchedule(int id);

    }
}
