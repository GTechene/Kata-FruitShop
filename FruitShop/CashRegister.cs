using System.Collections.Generic;
using System.Linq;


namespace FruitShop
{
    public class CashRegister
    {
        private const int CherryPrice = 75;
        private const int CherryDiscount = 20;
        private const int BananaPrice = 150;
        private const int ApplePrice = 100;
        private int _totalPrice;
        private readonly List<string> _products = new List<string>();

        public int Add(string input)
        {
            var products = input.Split(',');
            if (products.Length > 0)
            {
                foreach (var product in products)
                {
                    AddProduct(product.Trim());
                }

                return _totalPrice;
            }

            return AddProduct(input);
        }

        private int AddProduct(string product)
        {
            var currentProductPrice = 0;

            switch (product)
            {
                case "Apples":
                case "Pommes":
                case "Mele":
                    currentProductPrice = ApplePrice;
                    break;
                case "Bananes" when AlreadyBoughtThisProduct("Bananes"):
                    currentProductPrice = 0;
                    break;
                case "Bananes":
                    currentProductPrice = BananaPrice;
                    break;
                case "Cerises" when AlreadyBoughtThisProduct("Cerises"):
                    currentProductPrice = CherryPrice - CherryDiscount;
                    break;
                case "Cerises":
                    currentProductPrice = CherryPrice;
                    break;
            }

            if (currentProductPrice != 0)
            {
                _products.Add(product);
            }

            _totalPrice += currentProductPrice;

            return _totalPrice;
        }

        private bool AlreadyBoughtThisProduct(string product)
        {
            return _products.Count(x => x == product) % 2 == 1;
        }
    }
}