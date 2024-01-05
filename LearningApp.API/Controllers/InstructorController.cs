using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            this.instructorService = instructorService;
        }

        [HttpGet("GetCourses/{instructorId}")]
        public IActionResult GetCourses(int instructorId)
        {
            var courses = this.instructorService.GetInstructorCourses(instructorId);
            return Ok(courses);
        }

        [HttpPost]
        public IActionResult CreateCourse(CreateCourseDto dto)
        {
            var createdCourse = this.instructorService.CreateCourse(dto);
            return Created("", createdCourse);
        }
    }
}