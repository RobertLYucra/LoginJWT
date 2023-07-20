using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoginJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController (IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserModel user)
        {
            if (user == null) return BadRequest();
            if(user.Username == string.Empty) ModelState.AddModelError("UserName", "Username must be required");

            await _userRepository.CreateUser(user);

            return Ok(new
            {
                success = true,
                message = "User created",
                result = user
            });
        }
    }
}
