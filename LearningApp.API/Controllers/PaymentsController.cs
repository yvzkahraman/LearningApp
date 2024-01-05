using LearningApp.Business.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace LearningApp.API.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        private readonly IPaymentService paymentService;

        public PaymentsController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        [HttpGet]
        public IActionResult Pay()
        {
            var result = this.paymentService.Pay();
            return Ok(result);
        }
    }
}