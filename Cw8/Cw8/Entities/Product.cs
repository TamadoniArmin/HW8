using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public Product(int id, string name, string category,int price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }
        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Category: {Category} - Price: {Price}";
        }
    }
}
