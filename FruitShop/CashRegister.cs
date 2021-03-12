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
            int currentProductPrice = 0;

            if (product == "Pommes")
            {
                currentProductPrice = 100;
            }

            if (product == "Bananes")
            {
                currentProductPrice = 150;
            }

            if (product == "Cerises")
            {
                if (_products.Count(x => x == "Cerises") == 1 || _products.Count(x => x == "Cerises") == 3)
                {
                    currentProductPrice = 55;
                }
                else
                {
                    currentProductPrice = 75;
                }
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