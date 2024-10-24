using Cw8.Entities;
using Cw8.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8.InitialData
{
    public static class SeedData
    {
        public static void SeedDataa()
        {
            string filePath = "ListOfProducts.txt";
           List<Product> Products = new List<Product>()
           {
            new Product(1,"Laptop","Electronics",60),
            new Product(2,"S24Ultra","Electronics",40)
           };
            var settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.Objects
            };
            var p = JsonConvert.SerializeObject(Products,settings);
            File.WriteAllText(filePath, p);
            
        }
    }
}
