﻿using ExerciseProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseProject.Service
{
    public interface ISubjectService
    {
        IQueryable<Subject> GetSubjectsByStudent(int studentId);
    }
}
