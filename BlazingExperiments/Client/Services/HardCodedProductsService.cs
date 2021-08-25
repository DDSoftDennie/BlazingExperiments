using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingExperiments.Client.Services
{
    public class HardCodedProductsService : IProductsService
    {
        public static List<Product> products = new List<Product>
        {
            new Product
            {
                Name = "Isabelle's Homemade Marmelade",
                Description = "...",
                UnitPrice = 1.99M
            }, new Product
            {
                Name = "Liesbet's Applecake",
                Description = "Apple cake from Ostend!",
                UnitPrice = 3.98M
            }
        };
        public IEnumerable<Product> GetAllProducts() => products;
    }
}
