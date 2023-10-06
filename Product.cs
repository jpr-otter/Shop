using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {   
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public double Weight { get; set; }
        public string Id { get; set; }

        public Product(string serialNumber, string name, decimal price, int quantity, double weight, string id)
        {
            SerialNumber = serialNumber;
            Name = name;
            Price = price;
            Quantity = quantity;
            Weight = weight;
            Id = id;
        }
    }
}
