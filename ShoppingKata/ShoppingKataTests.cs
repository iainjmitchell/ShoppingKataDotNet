using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingKata
{
    [TestFixture]
    public class ShoppingKataTests
    {

        [Test]
        public void WhenIScanOneATheTotalShouldReturn50()
        {
            const string skuOfA = "A";
            const int priceOfA = 50;
            var checkout = new Checkout(priceOfA);
            checkout.Scan(skuOfA);
            object value = checkout.Total();
            Assert.That(value, Is.EqualTo(priceOfA));
        }

        [Test]
        public void WhenIScanOneBTheTotalShouldReturn30()
        {
            const string skuOfB = "B";
            const int priceOfB = 30;
            var checkout = new Checkout(50);
            checkout.Scan(skuOfB);
            object value = checkout.Total();
            Assert.That(value, Is.EqualTo(priceOfB));
        }
    }

    public class Checkout
    {
        private readonly int _priceOfA;
        private int total;

        public Checkout(int priceOfA)
        {
            _priceOfA = priceOfA;
        }

        public void Scan(string sku)
        {
            if (sku.Equals("A")) total = _priceOfA;
            else total = 30;
        }

        public int Total()
        {
            return total;
        }
    }
}