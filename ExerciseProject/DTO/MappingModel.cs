using AutoMapper;
using ExerciseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.DTO
{
    public class MappingModel : Profile
    {
        public MappingModel()
        {
            CreateMap<Student, StudentDTO>()
                .ForMember(dest => dest.ClassName,
                opt => opt.MapFrom(src => src.Class.Name));

            CreateMap<Schedule, ScheduleDTO>()
                .ForMember(dest => dest.ClassName,
                opt => opt.MapFrom(src => src.Class.Name))
                .ForMember(dest => dest.SubjectName,
                opt => opt.MapFrom(src => src.Subject.Name));

            CreateMap<Class, ClassDTO>()
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name));

            CreateMap<Subject, SubjectDTO>()
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(src => src.Name));
        }
    }
}
