using System.Collections.Generic;
using System.Linq;


namespace FruitShop
{
    public class Prices
    {
        public const int CherryPrice = 75;
        public const int BananaPrice = 150;
        public const int ApplePrice = 100;
    }

    public class CashRegister
    {
        private const int CherryDiscount = 20;
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
                case "Apples" when AlreadyBoughtThisProductTwice("Apples"):
                case "Pommes" when AlreadyBoughtThisProductTwice("Pommes"):
                    currentProductPrice = 0;
                    break;
                case "Mele" when AlreadyBoughtThisProduct("Mele"):
                    currentProductPrice = 0;
                    break;
                case "Apples":
                case "Pommes":
                case "Mele":
                    currentProductPrice = Prices.ApplePrice;
                    break;
                case "Bananes" when AlreadyBoughtThisProduct("Bananes"):
                    currentProductPrice = 0;
                    break;
                case "Bananes":
                    currentProductPrice = Prices.BananaPrice;
                    break;
                case "Cerises" when AlreadyBoughtThisProduct("Cerises"):
                    currentProductPrice = Prices.CherryPrice - CherryDiscount;
                    break;
                case "Cerises":
                    currentProductPrice = Prices.CherryPrice;
                    break;
            }

            if (currentProductPrice != 0)
            {
                _products.Add(product);
            }

            _totalPrice += currentProductPrice;

            return _totalPrice;
        }

        private bool AlreadyBoughtThisProductTwice(string product)
        {
            return _products.Count(x => x == product) % 2 == 0 && _products.Count(x => x == product) > 0;
        }

        private bool AlreadyBoughtThisProduct(string product)
        {
            return _products.Count(x => x == product) % 2 == 1;
        }
    }
}