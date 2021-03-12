using System.Collections.Generic;
using System.Linq;


namespace FruitShop
{
    public class CashRegister
    {
        private int _totalPrice = 0;
        private List<string> _products = new List<string>();

        public int Add(string input)
        {
            var products = input.Split(',');
            if (products.Length > 0)
            {
                foreach (var p in products)
                {
                    AddProduct(p.Trim());
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
                case "Pommes":
                    currentProductPrice = 100;
                    break;
                case "Bananes" when _products.Count(x => x == "Bananes") % 2 == 1:
                    currentProductPrice = 0;
                    break;
                case "Bananes":
                    currentProductPrice = 150;
                    break;
                case "Cerises" when _products.Count(x => x == "Cerises") % 2 == 1:
                    currentProductPrice = 45;
                    break;
                case "Cerises":
                    currentProductPrice = 75;
                    break;
            }

            if (currentProductPrice != 0)
            {
                _products.Add(product);
            }

            _totalPrice += currentProductPrice;

            return _totalPrice;
        }
    }
}