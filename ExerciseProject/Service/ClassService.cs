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
        IRepository<Student> _studentRepo;
        public ClassService(IRepository<Student> studentRepo)
        {
            _studentRepo = studentRepo;
        }
        public IQueryable<Student> GetStudentsByClass(int classId)
        {
            var listStudent = _studentRepo.SelectAll().Where(s => s.ClassId == classId);
            return listStudent;
        }
    }
}
