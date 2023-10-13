using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JansCornerStore
{
    public class ShoppingCartEntry
    {
        public int PickedQuantity { get; set; }
        public Product? Product { get; set; }
        public override string ToString()
        {
            return $"{Product?.Name}    {PickedQuantity}  x  {Product?.Price}€";               
        }
    }
}
