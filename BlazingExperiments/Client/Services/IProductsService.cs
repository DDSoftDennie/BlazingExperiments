using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingExperiments.Client.Services
{
    public interface IProductsService
    {
        IEnumerable<Product> GetAllProducts();
    }
}
