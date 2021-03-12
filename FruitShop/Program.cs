using System;
using System.Net.Http.Headers;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashRegister = new CashRegister();
            string product;
            do
            {
                Console.WriteLine("Please enter a product name :");
                product = Console.ReadLine();

                var price = cashRegister.Add(product);

                Console.WriteLine($"{product} -> {price}");
            }
            while (!string.IsNullOrEmpty(product));
        }
    }
}
