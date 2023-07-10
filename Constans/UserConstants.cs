using LoginJWT.Models;

namespace LoginJWT.Constans
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel()
            {
                Username = "jperez",
                password = "123",
                Rol = "Administrator",
                EmailAddress = "jperez@gmail.com",
                FirstName = "Juan",
                Lastname = "Perez"
            },
            new UserModel()
            {
                Username = "mgonzales",
                password = "123",
                Rol = "Vendedor",
                EmailAddress = "mgonzales@gmail.com",
                FirstName = "Maria",
                Lastname = "Gonzales"
            }
        };
    }
}
