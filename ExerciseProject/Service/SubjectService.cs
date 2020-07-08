using AutoMapper;
using ExerciseProject.DTO;
using ExerciseProject.Model;
using ExerciseProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;

namespace ExerciseProject.Service
{
    public class SubjectService : ISubjectService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly ISubjectRepository _subjectRepository;
        private readonly IMapper _mapper;

        public SubjectService(IStudentRepository studentRepository, IScheduleRepository scheduleRepository, ISubjectRepository subjectRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _subjectRepository = subjectRepository;
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }

        public IQueryable<SubjectDTO> GetSubjectsByStudent(int studentId)
        {
            var listSubject = (from u in _subjectRepository.SelectAll()
                               join c in _scheduleRepository.SelectAll()
                               on u.Id equals c.SubjectId
                               join s in _studentRepository.SelectAll()
                               on c.ClassId equals s.Class.Id
                               where s.Id == studentId
                               select u).Distinct();
            return listSubject.ProjectTo<SubjectDTO>(_mapper.ConfigurationProvider);
        }
    }
}
