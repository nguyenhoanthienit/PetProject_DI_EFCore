using ExerciseProject.DTO;
using ExerciseProject.Model;
using ExerciseProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Student DeleteStudent(int id)
        {
            return _studentRepository.Delete(id);
        }

        public Student UpdateStudent(Student student)
        {
            return _studentRepository.Update(student);
        }
    }
}
