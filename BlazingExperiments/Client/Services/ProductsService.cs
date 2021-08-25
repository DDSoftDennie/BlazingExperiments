using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingExperiments.Client.Services
{
    public class ProductsService : IProductsService
    {

        public static List<Product> products = new List<Product>
        {

        };
        public IEnumerable<Product> GetAllProducts() => products;
    }
}
