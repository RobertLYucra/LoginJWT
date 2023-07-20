using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserModel> CreateUser(UserModel user);
    }
}
