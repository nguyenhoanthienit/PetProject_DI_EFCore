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
    public class SchedulesController : ControllerBase
    {
        private readonly IScheduleService _scheduleService;

        public SchedulesController(IScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        // GET: api/Schedules/5
        [HttpGet("{id}")]
        public IQueryable<ScheduleDTO> GetScheduleByStudent(int id)
        {
            var schedule = _scheduleService.GetScheduleByStudent(id);
            return schedule;
        }
    }
}
