using Cw8.Entities;
using Cw8.Inteface;
using Cw8.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8.Service
{
    public class ProductService : IProductService
    {
        string filePath = "ListOfProducts.txt";
        IProductrepository productRep = new ProductRepositoryFile();
        public Result AddProduct(Product product)
        {
            if (product != null)
            {
                productRep.AddProductToFile(product);
                return new Result("Product Added.",true);
            }
            return new Result("Product not found.",false);
        }
        public Result ListOfProducts()
        {
            foreach(var item in productRep.GetAllProducts())
            {
                Console.WriteLine(item.ToString());
            }
            return new Result("success", true);
        }
    }
}
