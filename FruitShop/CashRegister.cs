namespace FruitShop
{
    public class CashRegister
    {
        private int _totalPrice = 0;

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
                currentProductPrice = 75;
            }

            _totalPrice += currentProductPrice;

            return _totalPrice;
        }
    }
}