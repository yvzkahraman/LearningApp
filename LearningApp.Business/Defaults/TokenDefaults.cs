using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace LearningApp.Business.Defaults
{
    public class TokenDefaults{
        public const string Audience = "http://localhost";
        public const string Issuer = "http://localhost";

        public const string Key = "yavuzyavuzFullStack.";

        public const int Expire = 10;
    }
}