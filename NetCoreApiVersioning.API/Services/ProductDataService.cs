using NetCoreApiVersioning.API.Models;

namespace NetCoreApiVersioning.API.Services
{
    public class ProductDataService
    {
        public static List<ProductViewModelv1> GetProductsv1()
        {
            var resultList = new List<ProductViewModelv1>()
            {
              new ProductViewModelv1()
              {
                  Id = 1,
                  Name = "Product-1",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                  Price = 10
              },
              new ProductViewModelv1()
              {
                  Id = 2,
                  Name = "Product-2",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                  Price = 20
              },
              new ProductViewModelv1()
              {
                  Id = 3,
                  Name = "Product-3",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                  Price = 20
              },
            };

            return resultList;
        }

        public static List<ProductViewModelv2> GetProductsv2()
        {
            var resultList = new List<ProductViewModelv2>()
            {
              new ProductViewModelv2()
              {
                  Id = 1,
                  Name = "Product-1",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                  Price = 10,
                  Stock = 100
              },
              new ProductViewModelv2()
              {
                  Id = 2,
                  Name = "Product-2",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                  Price = 20,
                  Stock = 200

              },
              new ProductViewModelv2()
              {
                  Id = 3,
                  Name = "Product-3",
                  Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. ",
                  Price = 20,
                  Stock = 300
              },
            };

            return resultList;
        }
    }
}
