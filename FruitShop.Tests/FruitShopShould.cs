using System;
using NFluent;
using NUnit.Framework;

namespace FruitShop.Tests
{
    public class FruitShopShould
    {
        [Test]
        public void Display_Pommes_Price()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Pommes");

            Check.That(price).IsEqualTo(100);
        }

        [Test]
        public void Display_Cerises_Price()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Cerises");

            Check.That(price).IsEqualTo(75);
        }

        [Test]
        public void Display_Bananes_Price()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Bananes");

            Check.That(price).IsEqualTo(150);
        }
    }
}
