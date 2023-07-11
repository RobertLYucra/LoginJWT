using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface IUserRepository
    {
         Task<UserModel> Authenticate(LoginUser loginUser);
        string Generate(UserModel user);
    }
}
