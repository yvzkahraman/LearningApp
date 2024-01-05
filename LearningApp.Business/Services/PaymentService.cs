using LearningApp.Business.Dtos;
using LearningApp.Business.Interfaces;

namespace LearningApp.Business.Services
{
    public class PaymentService : IPaymentService
    {
        public PaymentDto Pay()
        {
            var dto = new PaymentDto();
            Random random = new Random();
            var generatedNumber = random.Next(1, 10);
            if (generatedNumber < 3)
            {
                dto.Success = false;
                return dto;
            }
            dto.Success = true;
            return dto;
        }
    }
}