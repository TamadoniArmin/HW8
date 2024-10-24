using Cw8.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8.Inteface
{
    public interface IProductrepository
    {
        void AddProductToFile(Product product);
        List<Product> GetAllProducts();
        public void Addproducts(List<Product> pro);
        public void RemoveProduct(int Id);
    }
}
