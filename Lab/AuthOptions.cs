using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Lab
{
    public class AuthOptions
    {
        public const string ISSUER = "MyAuthServer";
        public const string AUDIENCE = "MyAuthClient";
        const string KEY = "7706CB3B-CD32-4B5D-BDA8-13011941C9BDmysupersecret_secretkey!123EEAD4455-5A92-413B-91EE-6AF29B074DDB";
        public const int LIFETIME = 15;
        public static SymmetricSecurityKey GetSymmetricSecurityKey()
        {
            return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
        }
    }
}
