using ExerciseProject.DTO;
using ExerciseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Service
{
    public interface IStudentService
    {
        public Student DeleteStudent(int id);
        public Student UpdateStudent(Student student);
    }
}
