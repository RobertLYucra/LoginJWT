using LoginJWT.Repository;
using LoginJWT.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LoginJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository = new ProductRepository();

        [HttpGet]
        [Authorize]
        public IActionResult GetProduct()
        {
           return Ok(new
           {
               success = true,
               message = "All Products",
               result = _productRepository.GetProducts()
           });

        }
    }
}
