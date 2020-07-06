using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.DTO
{
    public class ScheduleDTO
    {
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public string SubjectName { get; set; }
        public string ClassName { get; set; }
        public int DayOfWeek { get; set; }
        public string Name { get; set; }
    }
}
