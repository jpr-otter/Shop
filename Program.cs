using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JansCornerStore
{
    class Program
    {
        private static Random random = new Random();
        public static string GenerateRandomString(int IDLength)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, IDLength)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {
            int IDLength = 7;
            string randomString = GenerateRandomString(IDLength);
            //Console.WriteLine(randomString);

            ShoppingCart cart = new();

            cart.AddProduct(new Product("001", "Apple", 0.5m, 100, 200.50, "2023/12/20", GenerateRandomString(IDLength)));
            cart.AddProduct(new Product("002", "Banana", 0.3m, 150, 345.47, "2023/11/25", GenerateRandomString(IDLength)));
            //shop.AddProduct(new Product("Carrot", 0.2m, 200));

            foreach (var entry in cart.Entries)
            {
                var product = entry.Product;
                if (product != null)
                {
                    Console.WriteLine($" Name:      {product.Name}\n Price:     {product.Price} Euro \n Quantity:  " +
                                      $"{product.AvailableQuantity}\n Weight:    {product.Weight} g\n ID:        " +
                                      $"{product.Id} \n");
                }
            }
        }
    }
}
