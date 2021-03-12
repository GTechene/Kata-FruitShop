using System.Collections.Generic;
using System.Linq;


namespace FruitShop
{
    public class CashRegister
    {
        private int _totalPrice = 0;
        private List<string> _products = new List<string>();

        public int Add(string product)
        {
            var currentProductPrice = 0;

            switch (product)
            {
                case "Pommes":
                    currentProductPrice = 100;
                    break;
                case "Bananes":
                    currentProductPrice = 150;
                    break;
                case "Cerises" when _products.Count(x => x == "Cerises") % 2 == 1:
                    currentProductPrice = 55;
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