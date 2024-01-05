using LearningApp.Business.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            var result = this.courseService.GetCourses();
            return Ok(result);
        }

        [Authorize(Roles = "Student")]
        [HttpGet("MyCourses")]
        public IActionResult MyCourses()
        {
            var userClaim = User.Claims.SingleOrDefault(x => x.Type == "Username");
            if (userClaim != null)
            {
                var username = userClaim.Value;

                var result = this.courseService.GetMyCourses(username);

                if (result != null)
                {
                    return Ok(result);
                }

                return BadRequest("Bu username ile ilgili kurs bulunamadı");
            }
            return BadRequest("Username bulunamadı");

        }
    }
}