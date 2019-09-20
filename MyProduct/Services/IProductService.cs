using MyProduct.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProduct.Services
{
    public interface IProductService
    {
        List<Product> GetProducts();
        List<Category> GetCategories();
        List<SubCategory> GetSubCategories();
    }
}
