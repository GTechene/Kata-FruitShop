namespace FruitShop
{
    public class CashRegister
    {
        public int Add(string product)
        {
            if (product == "Pommes")
            {
                return 100;
            }

            if (product == "Bananes")
            {
                return 150;
            }

            return 75;
        }
    }
}