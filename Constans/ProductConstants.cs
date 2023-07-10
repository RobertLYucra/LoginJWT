using LoginJWT.Models;

namespace LoginJWT.Constans
{
    public class ProductConstants
    {
        public static List<ProductModel> productModels = new List<ProductModel>()
        {
            new ProductModel()
            {
                Name = "Galleta Crag",
                Descripction = "galleta seca"
            },
            new ProductModel()
            {
                Name = "Gaseoa",
                Descripction = "Gaseoa seca"
            },
            new ProductModel()
            {
                Name = "Platano ",
                Descripction = " seca"
            },
            new ProductModel()
            {
                Name = "Cerveza ",
                Descripction = " Cerveza"
            },
            new ProductModel()
            {
                Name = "Sopa Verde",
                Descripction = " Verde"
            },
        };
    }
}
