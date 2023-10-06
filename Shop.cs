using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class ShoppingCart
    {
        public Dictionary<string, Product> Products { get; set; }

        public ShoppingCart()
        {
            Products = new Dictionary<string, Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product.Id, product);
        }

        public bool RemoveProduct(string productId)
        {
            return Products.Remove(productId);
        }
    }
}
