using _17_10_23.Metods;

namespace _17_10_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ListInit myList = new ListInit();

            //myList.Add(5);
            //myList.AddRange(10, 15, 20);
            //myList.Add(25);

            //Console.WriteLine("List: " + myList.ToString());
            //Console.WriteLine("Sum: " + myList.Sum());

            //Console.WriteLine("Contains 10: " + myList.Contains(10));
            //Console.WriteLine("Contains 30: " + myList.Contains(30));

            //myList.Remove(10);
            //Console.WriteLine("List after removing 10: " + myList.ToString());

            //myList.RemoveRange(15, 25);
            //Console.WriteLine("List after removing 15 and 25: " + myList.ToString());


            //Optional ;) Praktikada yaza bilmediyim
            OnlineMarket market = new OnlineMarket("MyMarket");

            while (true)
            {
                Console.WriteLine("[1] Add a product to the market");
                Console.WriteLine("[2] Remove product from Market");
                Console.WriteLine("[3] Add product to cart");
                Console.WriteLine("[4] Show the products in the market");
                Console.WriteLine("[5] Show products in the basket");
                Console.WriteLine("[6] Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter product name: ");
                        string productName = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double productPrice = double.Parse(Console.ReadLine());
                        Console.Write("Enter quantity in stock: ");
                        int stockQuantity = int.Parse(Console.ReadLine());

                        market.Products.Add(new Product(productName, productPrice, stockQuantity));
                        break;

                    case 2:
                        Console.Write("Enter product ID to remove: ");
                        int removeProductId = int.Parse(Console.ReadLine());
                        market.Products.Remove(removeProductId);
                        break;

                    case 3:
                        Console.Write("Enter product ID to add to cart: ");
                        int productId = int.Parse(Console.ReadLine());
                        Console.Write("Enter quantity to add to cart: ");
                        int quantity = int.Parse(Console.ReadLine());

                        if (market.Products.FindById(productId) != null)
                        {
                            market.Cart.Add(market.Products.FindById(productId), quantity);
                        }
                        else
                        {
                            Console.WriteLine("Product not found in the market.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Products in the market:");
                        market.Products.ShowProducts();
                        break;

                    case 5:
                        Console.WriteLine("Products in the cart:");
                        market.Cart.ShowCart();
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid option.");
                        break;
                }
            }
        }
    }
}