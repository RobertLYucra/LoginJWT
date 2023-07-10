using LoginJWT.Models;
using LoginJWT.Repository;
using LoginJWT.Repository.Interfaces;
using LoginJWT.Resource;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LoginJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository = new EmployeeRepository();

        [HttpGet]
       // [Authorize(Roles = "Administrator")]
        public IActionResult Get()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            var rToken = TokenResource.ValidateToken(identity);
            if (!rToken.success) return BadRequest(rToken);
            UserModel user = rToken.result;

            if(user.Rol !="Administrator")
            {
                return Ok(new
                {
                    succes = false,
                    message ="No tienes permiso para realizar estas operacion"
                });
            }

            return Ok(
                new
                {
                    success = true,
                    message = "All Employees",
                    user = new{
                            email = user.EmailAddress,
                            role = user.Rol,
                            firstName = user.FirstName,
                            lastName = user.Lastname
                            },
                    result = _employeeRepository.GetAllEmployes()
                }
                );
        }
    }
}
