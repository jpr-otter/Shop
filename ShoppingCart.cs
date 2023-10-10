using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace JansCornerStore
{
    public class ShoppingCart
    {
        public List<ShoppingCartEntry> Entries { get; set; } = new List<ShoppingCartEntry>();       

        public void AddProduct(Product product)
        {
            var entry = new ShoppingCartEntry { Product = product, PickedQuantity = 1 };
            Entries.Add(entry);
        }

        public bool RemoveProduct(Product product)
        {
            var productToRemove = Entries.Find(entry => entry.Product != null && entry.Product.Id == product.Id);
            return productToRemove != null && Entries.Remove(productToRemove);
        }
    }
}
