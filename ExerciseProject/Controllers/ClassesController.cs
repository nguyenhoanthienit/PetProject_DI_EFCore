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
//test
    [Route("api/[controller]")]
    [ApiController]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        // GET: api/classes/1
        [HttpGet("{id}")]
        public IEnumerable<StudentDTO> GetStudentsByClass(int id)
        {
            return _classService.GetStudentsByClass(id);
        }
    }
}
