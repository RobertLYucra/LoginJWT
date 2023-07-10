using LoginJWT.Constans;
using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace LoginJWT.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _config;

        public UserRepository(IConfiguration config)
        {
            _config = config;
        }

        public UserModel Authenticate(LoginUser loginUser)
        {
            var currectUser = UserConstants
                .Users
                .FirstOrDefault(x => x.Username.ToLower() == loginUser.Username.ToLower() && x.password == loginUser.Password);

            if (currectUser != null)
            {
                return currectUser;
            }
            return null;
        }

        public string Generate(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.Username),
                new Claim(ClaimTypes.Email,user.EmailAddress),
                new Claim(ClaimTypes.GivenName,user.FirstName),
                new Claim(ClaimTypes.Surname,user.Lastname),
                new Claim(ClaimTypes.Role,user.Rol),
                new Claim("username",user.Username)
            };

            var token = new JwtSecurityToken(
                                        _config["Jwt:Issuer"],
                                        _config["Jwt:Audience"],
                                        claims,
                                        expires: DateTime.Now.AddMinutes(15),
                                        signingCredentials: credentials
                                        );
            return new JwtSecurityTokenHandler().WriteToken(token);

        }
    }
}
