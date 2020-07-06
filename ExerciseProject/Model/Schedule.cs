using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Model
{
    public class Schedule
    {
        public int SubjectId { get; set; }
        public int ClassId { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Class Class { get; set; }
        public int DayOfWeek { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
