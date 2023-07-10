using LoginJWT.Constans;
using LoginJWT.Models;
using System.Security.Claims;

namespace LoginJWT.Resource
{
    public class TokenResource
    {
        public string key { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public string Subject { get; set; }

        public static dynamic ValidateToken(ClaimsIdentity claimsIdentity)
        {
            if (claimsIdentity == null)
            {
                return (
                    new
                    {
                        success = false,
                        message = "Token inválido o nulo",
                        result = ""
                    });
            }

            if(claimsIdentity.Claims.Count() == 00)
            {
                return (new
                    {
                        success = false,
                        message = "Token inválido o nulo",
                        result = ""
                    });
            }

            var username = claimsIdentity.Claims.FirstOrDefault(x=>x.Type == "username").Value;
            UserModel user = UserConstants.Users.FirstOrDefault(x=>x.Username == username);

            return new
            {
                success = true,
                message = "Token validado",
                result = user
            };

        } 
    }
}
