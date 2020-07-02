using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Model
{
    public class Subject
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
