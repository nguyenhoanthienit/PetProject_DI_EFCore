using ExerciseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Repository
{
    public class ClassRepository : RepositoryBase<Class>, IClassRepository
    {
        public ClassRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
