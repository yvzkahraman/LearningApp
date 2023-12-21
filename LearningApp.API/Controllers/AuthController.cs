using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUserService userService;

        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public IActionResult Register(RegisterDto dto)
        {
            var result = this.userService.RegisterUser(dto);
            return Created("", result);
        }
    }
}
