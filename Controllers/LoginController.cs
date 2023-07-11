using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoginJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserRepository _userRepository;

        public LoginController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUser userLogin)
        {

            var user = _userRepository.Authenticate(userLogin).Result;

            if (user != null)
            {
                var token = _userRepository.Generate( user);
                return Ok(new
                {
                    succ = true,
                    message = "Usuario Logeado",
                    result = new
                    {
                        username = user.Username,
                        email = user.EmailAddress,
                        role = user.Rol,
                        firstName = user.FirstName,
                        lastName = user.Lastname
                    },
                    rtoken = token
                });
            }
            else
            {
                return Ok(
                new
                {
                    success = false,
                    message = "Credenciales incorrectas...",
                    result = ""
                 });
            }



        }
    }
}
