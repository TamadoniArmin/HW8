using Cw8.Entities;
using Cw8.InitialData;
using Cw8.Inteface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Cw8.Repository
{
    public class ProductRepositoryFile : IProductrepository
    {
        public string filePath = "ListOfProducts.txt";
        public void AddProductToFile(Product product)
        {
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            var p = JsonConvert.SerializeObject(product,settings);
            File.WriteAllText(filePath,p);
        }

        public List<Product> GetAllProducts()
        {
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            List<Product> products = new List<Product>();
            var Products = File.ReadAllText(filePath);
            products = JsonConvert.DeserializeObject<List<Product>>(Products,settings);
            return products;
            
        }
        public void Addproducts(List<Product> pro)
        {
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            var p = JsonConvert.SerializeObject(pro, settings);
            File.WriteAllText(filePath, p);
        }
        public void RemoveProduct(int Id)
        {
            List<Product> list =GetAllProducts();
            foreach (var product in list)
            {
                if (product.Id==Id)
                {
                    list.Remove(product);
                    break;
                }
            }
            Addproducts(list);
            return new Result("product removed.", true);
        }
    }
}
