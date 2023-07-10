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
        public IActionResult Login(LoginUser userLogin)
        {
            var user = _userRepository.Authenticate(userLogin);

            if (user != null)
            {
                var token = _userRepository.Generate(user);

                return Ok(new
                    {
                        succ = true,
                        message = "Usuario Logeado",
                        result = user,
                        rtoken = token
                    });
            }

            return NotFound(
                 new
                 {
                     succ = false,
                     message = "Credenciales incorrectas...",
                     result = ""
                 }
                );
        }
    }
}
