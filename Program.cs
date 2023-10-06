using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
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

            cart.AddProduct(new Product("001", "Apple", 0.5m, 100, 200.50,GenerateRandomString(IDLength)));
            //shop.AddProduct(new Product("Banana", 0.3m, 150));
            //shop.AddProduct(new Product("Carrot", 0.2m, 200));

            foreach (var product in cart.Products)
            {
                Console.WriteLine($" Name:      {product.Value.Name}\n Price:     {product.Value.Price} Euro \n Quantity:  {product.Value.Quantity}\n Weight:    {product.Value.Weight} g\n ID:        {product.Value.Id} ");
            }
        }
        
    }

}
