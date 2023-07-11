using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;
using LoginJWT.Resource;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Linq;



namespace LoginJWT.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _config;
        internal MongoResource _mongoResource = new MongoResource();
        private IMongoCollection<UserModel> Collection;


        public UserRepository(IConfiguration config, MongoResource mongoResource )
        {
            _config = config;
            _mongoResource = mongoResource;
            Collection = _mongoResource.database.GetCollection<UserModel>("Users");
        }


        public async Task<UserModel> Authenticate(LoginUser loginUser)
        {
            var filter = Builders<UserModel>.Filter.And(
                Builders<UserModel>.Filter.Eq(x => x.Username, loginUser.Username),
                Builders<UserModel>.Filter.Eq(x => x.password, loginUser.Password)
            );

            var currentUser = await Collection.Find(filter).FirstOrDefaultAsync();

            if (currentUser != null)
            {
                return currentUser;
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
