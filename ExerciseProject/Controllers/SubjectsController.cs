using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ExerciseProject.Model;
using ExerciseProject.Repository;
using ExerciseProject.Service;
using ExerciseProject.DTO;

namespace ExerciseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService _subjectService;

        public SubjectsController(ISubjectService subjectService)
        {
            _subjectService = subjectService;
        }

        // GET: api/Subjects/1
        [HttpGet("{id}")]
        public IEnumerable<SubjectDTO> GetSubjectsByStudent(int id)
        {

            return _subjectService.GetSubjectsByStudent(id);
        }
    }
}
