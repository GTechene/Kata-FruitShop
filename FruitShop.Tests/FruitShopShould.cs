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

        [Test]
        public void Compute_Sum_of_products_when_several_products_are_added()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Bananes");
            price = cashRegister.Add("Cerises");

            Check.That(price).IsEqualTo(225);
        }

        [Test]
        public void aPply_Discount_On_Cerises()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Cerises");
            price = cashRegister.Add("Cerises");

            Check.That(price).IsEqualTo(130);
        }
    }
}
