using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface ILoginRepository
    {
         Task<UserModel> Authenticate(LoginUser loginUser);
        string Generate(UserModel user);
    }
}
