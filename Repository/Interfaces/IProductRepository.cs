using LoginJWT.Models;

namespace LoginJWT.Repository.Interfaces
{
    public interface IProductRepository
    {
        public List<ProductModel> GetProducts();
    }
}
