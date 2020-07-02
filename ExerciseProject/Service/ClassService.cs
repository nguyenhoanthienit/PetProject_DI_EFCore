using ExerciseProject.Model;
using ExerciseProject.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace ExerciseProject.Service
{
    public class ClassService : IClassService
    {
        private readonly IStudentRepository _studentRepository;
        public ClassService(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        public IQueryable<Student> GetStudentsByClass(int classId)
        {
            
            var listStudent = _studentRepository.SelectAll().Where(s => s.ClassId == classId);
            return listStudent;
        }
    }
}
