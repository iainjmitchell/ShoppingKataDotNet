using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingKata
{
    [TestFixture]
    public class ShoppingKataTests
    {
        [Test]
        public void WhenIScanOneAIShouldGet50()
        {
            var shoppingTill = new ShoppingTill();
            shoppingTill.Scan("A");
            int total = shoppingTill.Total();
            Assert.That(total, Is.EqualTo(50));
        }

        [Test]
        public void WhenIScanOneBIShouldGet30()
        {
            var shoppingTill = new ShoppingTill();
            shoppingTill.Scan("B");
            int total = shoppingTill.Total();
            Assert.That(total, Is.EqualTo(30));
        }
    }

    public class ShoppingTill
    {
        public Pricelist _priceList;
        private int _total;

        public ShoppingTill()
        {
            _priceList = new Pricelist();
        }

        public void Scan(string sku)
        {
            _total = _priceList._priceList[sku];
        }

        public int Total()
        {
            return _total;
        }
    }

    public class Pricelist
    {
        private const int priceOfA = 50;
        private const int priceOfB = 30;
        private const string skuOfA = "A";
        private const string skuOfB = "B";

        public readonly Dictionary<string, int> _priceList = new Dictionary<string, int>
            {
                {skuOfA, priceOfA},
                {skuOfB, priceOfB}
            };
        
    }
}