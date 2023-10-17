using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_10_23.Metods
{
    internal class ProductList
    {
        private Product[] products = new Product[100];
        public Product this[int index]
        {
            get
            {
                if (index < 0 || index >= products.Length)
                    throw new IndexOutOfRangeException();
                return products[index];
            }
            set
            {
                if (index >= 0 && index < products.Length)
                    products[index] = value;
                else
                    throw new IndexOutOfRangeException();
            }
        }
        private int productCount = 0;
        private int currentProductId = 1;

        public void Add(Product product)
        {
            product.Id = currentProductId++;
            if (productCount < products.Length)
            {
                products[productCount++] = product;
            }
            else
            {
                Console.WriteLine("Product limit reached. Cannot add more products.");
            }
        }

        public void Remove(int id)
        {
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].Id == id)
                {
                    for (int j = i; j < productCount - 1; j++)
                    {
                        products[j] = products[j + 1];
                    }
                    productCount--;
                    return;
                }
            }
            Console.WriteLine("Product not found in the market.");
        }

        public Product FindById(int id)
        {
            for (int i = 0; i < productCount; i++)
            {
                if (products[i].Id == id)
                {
                    return products[i];
                }
            }
            return null;
        }

        public void ShowProducts()
        {
            for (int i = 0; i < productCount; i++)
            {
                Console.WriteLine($"ID: {products[i].Id}, Name: {products[i].Name}, Price: {products[i].Price}, Stock: {products[i].Stock}");
            }
        }
    }
}
