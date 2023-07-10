using LoginJWT.Constans;
using LoginJWT.Models;
using LoginJWT.Repository.Interfaces;

namespace LoginJWT.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<ProductModel> GetProducts()
        {
            return ProductConstants.productModels;
        }
    }
}
