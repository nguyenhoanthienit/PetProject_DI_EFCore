using ExerciseProject.DTO;
using ExerciseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Service
{
    public interface IClassService
    {
        IQueryable<StudentDTO> GetStudentsByClass(int classId);
    }
}
