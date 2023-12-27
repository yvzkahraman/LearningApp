namespace LearningApp.Business.Dtos
{
    public class TokenDto
    {
        public string Token {get; set;} = null!;

        public DateTime Expire { get; set; }
    }


}