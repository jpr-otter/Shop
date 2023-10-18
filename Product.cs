using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JansCornerStore
{//
    public class Product
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }
        public double Weight { get; set; }
        public string ExpiryDate { get; set; }
        public string Id { get; set; }

        public Product(string serialNumber, string name, decimal price, int availablequantity, double weight, string expiryDate, string id)
        {
            SerialNumber = serialNumber;
            Name = name;
            Price = price;
            AvailableQuantity = availablequantity;
            Weight = weight;
            ExpiryDate = expiryDate;
            Id = id;
        }

    }

}
