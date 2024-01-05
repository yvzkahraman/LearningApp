using LearningApp.Business;
using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private readonly IStudentService studentService;

        public StudentsController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        [HttpPost("[action]")]
        public IActionResult AssignCourse(AssignCourseDto dto)
        {
            this.studentService.AssignCourse(dto);
            return Ok();
        }
    }

}