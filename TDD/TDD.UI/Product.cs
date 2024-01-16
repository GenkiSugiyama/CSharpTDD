using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class Product
    {
        public int ProductId { get; }
        public string ProductName { get; }

        public Product(int productId, string productName)
        {
            ProductId = productId;
            ProductName = productName;
        }
    }
}
