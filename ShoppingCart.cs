using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            if (Entries.Any(existingEntry => existingEntry.Product?.Id == product.Id))
            {
                var existingEntry = Entries.First(existingEntry => existingEntry.Product?.Id == product.Id);
                existingEntry.PickedQuantity++;
            }
            else
            {
                var entry = new ShoppingCartEntry { Product = product, PickedQuantity = 1 };
                Entries.Add(entry);
            }
        }

        public bool RemoveProduct(Product product)
        {
            var productToRemove = Entries.Find(entry => entry.Product != null && entry.Product.Id == product.Id);
        
            return productToRemove != null && Entries.Remove(productToRemove);
        }

        public decimal CalculateTotalPrice()
        {
            // quantity * preis
            //decimal totalPrice = Entries.Select(entry => entry.PickedQuantity * entry.Product!.Price).Sum();
            decimal? totalPrice = 0M;
            foreach (var entry in Entries)
            {
                var totalPriceOfEntry = entry.PickedQuantity*entry.Product?.Price;
                totalPrice +=  totalPriceOfEntry;
            }
            return totalPrice ?? 0;
        }
    }
}
