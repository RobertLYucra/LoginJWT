using LoginJWT.Repository;
using LoginJWT.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoginJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository = new CountryRepository();
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                new{
                    success =true,
                    message = "All countries",
                    result = _countryRepository.GetAllCounties()
                });
        }
    }
}
