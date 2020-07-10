using ExerciseProject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Service
{
    public interface IScheduleService
    {
        IQueryable<ScheduleDTO> GetScheduleByStudent(int id);
    }
}
