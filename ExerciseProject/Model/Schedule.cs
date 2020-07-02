﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Model
{
    public class Schedule
    {
        [Key]
        [Required]
        public int SubjectId { get; set; }
        [Key]
        [Required] 
        public int ClassId { get; set; }
        public int DayOfWeek { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
