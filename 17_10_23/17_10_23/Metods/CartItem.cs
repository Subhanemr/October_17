using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_10_23.Metods
{
    internal class CartItem
    {
        public int Id { get; }
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Quantity = quantity;
        }
    }
}
