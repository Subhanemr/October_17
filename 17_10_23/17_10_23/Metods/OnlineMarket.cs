using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_10_23.Metods
{
    internal class OnlineMarket
    {
        public CartItemList Cart { get; }
        public ProductList Products { get; }
        public string Name { get; }
        private int Id;

        public OnlineMarket(string name)
        {
            Name = name;
            Cart = new CartItemList();
            Products = new ProductList();
            Id = 0;
        }
    }
}
