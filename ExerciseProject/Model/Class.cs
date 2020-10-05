using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Model
{
    public class Class
    {asdfasdfasdf
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public virtual IList<Schedule> Schedules { get; set; }
        public virtual IList<Student> Students { get; set; }
    }
}
