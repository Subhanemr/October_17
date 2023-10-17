using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_10_23.Metods
{
    internal class CartItemList
    {
        private CartItem[] items = new CartItem[100];
        public CartItem this[int index]
        {
            get
            {
                if (index < 0 || index >= items.Length)
                    throw new IndexOutOfRangeException();
                return items[index];
            }
            set
            {
                if (index >= 0 && index < items.Length)
                    items[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }

        private int itemCount = 0;

        public void Add(Product product, int quantity)
        {
            if (IsExists(product.Id))
            {
                FindById(product.Id).Quantity += quantity;
            }
            else
            {
                if (itemCount < items.Length)
                {
                    items[itemCount++] = new CartItem(product, quantity);
                }
                else
                {
                    Console.WriteLine("Cart limit reached. Cannot add more items.");
                }
            }
        }

        public bool IsExists(int id)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (items[i].Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public CartItem FindById(int id)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (items[i].Id == id)
                {
                    return items[i];
                }
            }
            return null;
        }

        public void ShowCart()
        {
            for (int i = 0; i < itemCount; i++)
            {
                Console.WriteLine($"ID: {items[i].Id}, Name: {items[i].Name}, Price: {items[i].Price}, Quantity: {items[i].Quantity}");
            }
        }
    }
}
