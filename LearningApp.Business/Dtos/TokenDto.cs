namespace LearningApp.Business.Dtos
{
    public class TokenDto
    {
        public string FullName { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Token {get; set;} = null!;

        public DateTime Expire { get; set; }
    }


}