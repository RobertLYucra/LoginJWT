using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface IUserRepository
    {
        public UserModel Authenticate(LoginUser loginUser);
        public string Generate(UserModel user);
    }
}
