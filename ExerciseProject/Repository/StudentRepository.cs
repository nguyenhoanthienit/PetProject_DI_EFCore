using ExerciseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        public Class GetClass(int id)
        {
            throw new NotImplementedException();
        }

        public Schedule GetSchedule(int id)
        {
            throw new NotImplementedException();
        }
    }
}
