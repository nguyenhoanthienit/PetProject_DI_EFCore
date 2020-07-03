using ExerciseProject.Model;
using ExerciseProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Service
{
    public class SubjectService : ISubjectService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly ISubjectRepository _subjectRepository;
        public SubjectService(IStudentRepository studentRepository, IScheduleRepository scheduleRepository, ISubjectRepository subjectRepository)
        {
            _studentRepository = studentRepository;
            _subjectRepository = subjectRepository;
            _scheduleRepository = scheduleRepository;
        }

        public IQueryable<Subject> GetSubjectsByStudent(int studentId)
        {
            var listSubject = (from u in _subjectRepository.SelectAll()
                              join c in _scheduleRepository.SelectAll()
                              on u.Id equals c.SubjectId
                              join s in _studentRepository.SelectAll()
                              on c.ClassId equals s.ClassId
                              where s.Id == studentId
                              select u).Distinct();
            return listSubject;
        }
    }
}
