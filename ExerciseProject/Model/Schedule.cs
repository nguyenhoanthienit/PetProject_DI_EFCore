using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Model
{
    public class Schedule
    {
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public int DayOfWeek { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
