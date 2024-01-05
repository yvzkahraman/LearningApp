using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IUserService userService;

        public AuthController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("[action]")]
        public IActionResult Register(RegisterDto dto)
        {
            var result = this.userService.RegisterUser(dto);
            return Created("", result);
        }

        [HttpPost("Token")]
        public IActionResult Login(LoginDto dto)
        {
            var result = this.userService.CheckUser(dto);
            if (result != null)
            {
                return Created("", result);
            }
            return BadRequest("Kullanıcı adı veya şifre hatalı");

        }
    }
}
