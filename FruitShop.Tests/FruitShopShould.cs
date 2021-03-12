﻿using System;
using NFluent;
using NUnit.Framework;

namespace FruitShop.Tests
{
    public class FruitShopShould
    {
        [TestCase("Pommes")]
        [TestCase("Apples")]
        [TestCase("Mele")]
        public void Display_Pommes_Price(string product)
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add(product);

            Check.That(price).IsEqualTo(Prices.ApplePrice);
        }

        [Test]  
        public void Display_Cerises_Price()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Cerises");

            Check.That(price).IsEqualTo(Prices.CherryPrice);
        }

        [Test]
        public void Display_Bananes_Price()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Bananes");

            Check.That(price).IsEqualTo(Prices.BananaPrice);
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
        public void Apply_Discount_On_Cerises()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Cerises");
            price = cashRegister.Add("Cerises");

            Check.That(price).IsEqualTo(130);
        }

        [Test]
        public void Apply_Discount_On_Cerises_With_4()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Cerises");
            price = cashRegister.Add("Cerises");
            price = cashRegister.Add("Cerises");
            price = cashRegister.Add("Cerises");

            Check.That(price).IsEqualTo(260);
        }

        [Test]
        public void Parse_multiple_products_separated_with_a_comma()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Pommes, Cerises, Bananes");

            Check.That(price).IsEqualTo(325);
        }

        [Test]
        public void Offer_second_bananas()
        {
            var cashRegister = new CashRegister();
            var price = cashRegister.Add("Bananes");
            price = cashRegister.Add("Bananes");

            Check.That(price).IsEqualTo(Prices.BananaPrice);
        }
    }
}
