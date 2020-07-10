using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExerciseProject.DTO;
using ExerciseProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Service
{
    public class ScheduleService : IScheduleService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IMapper _mapper;

        public ScheduleService(IStudentRepository studentRepository, IScheduleRepository scheduleRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }

        public IQueryable<ScheduleDTO> GetScheduleByStudent(int id)
        {
            var listSchedule = (from s in _studentRepository.SelectAll()
                                join c in _scheduleRepository.SelectAll()
                                on s.Class.Id equals c.ClassId
                                where s.Id == id
                                select c);
            return listSchedule.ProjectTo<ScheduleDTO>(_mapper.ConfigurationProvider);
        }
    }
}
