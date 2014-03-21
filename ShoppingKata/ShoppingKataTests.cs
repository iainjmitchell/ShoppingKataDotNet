using System.Collections.Generic;
using NUnit.Framework;

namespace ShoppingKata
{
    [TestFixture]
    public class ShoppingKataTests
    {
        [Test]
        public void WhenIScanOneAThenTotalIs50()
        {
            var shoppingTil = new ShoppingTil();
            shoppingTil.Scan("A");
            int total = shoppingTil.Total();
            Assert.That(total, Is.EqualTo(50));
        }

        [Test]
        public void WhenIScanOneBThenTotalIs30()
        {
            var shoppingTil = new ShoppingTil();
            shoppingTil.Scan("B");
            int total = shoppingTil.Total();
            Assert.That(total, Is.EqualTo(30));
        }
    }

    public class ShoppingTil
    {
        Dictionary<string,int> priceList = new Dictionary<string, int>
            {
                { "A", 50 },
                { "B", 30 }
            };

        private int total;

        public void Scan(string sku)
        {
            total = priceList[sku];
        }

        public int Total()
        {
            return total;
        }
    }
}
