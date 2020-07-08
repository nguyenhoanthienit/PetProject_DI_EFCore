using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Model
{
    public class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public IList<Schedule> Schedules { get; set; }
        public IList<Student> Students { get; set; }
    }
}
