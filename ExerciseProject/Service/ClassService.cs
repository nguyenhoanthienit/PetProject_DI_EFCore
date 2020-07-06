using ExerciseProject.Model;
using ExerciseProject.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using ExerciseProject.DTO;
using AutoMapper;
using System.Runtime.InteropServices.WindowsRuntime;
using AutoMapper.QueryableExtensions;

namespace ExerciseProject.Service
{
    public class ClassService : IClassService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public ClassService(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }
        public IQueryable<StudentDTO> GetStudentsByClass(int classId)
        {
            var listStudent = _studentRepository.SelectAll().Where(s => s.Class.Id == classId);
            return listStudent.ProjectTo<StudentDTO>(_mapper.ConfigurationProvider);
        }
    }
}
