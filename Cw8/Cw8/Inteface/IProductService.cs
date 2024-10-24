using Cw8.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw8.Inteface
{
    public interface IProductService
    {
        Result AddProduct(Product product);
    }
}
