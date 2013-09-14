using MoneyExample;
using NUnit.Framework;

namespace MoneyExampleTests
{
    [TestFixture]
    internal class MoneyExampleTests
    {
        [Test]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            var product = five.Times(2);
            Assert.That(product.amount, Is.EqualTo(10));
            product = five.Times(3);
            Assert.That(product.amount, Is.EqualTo(15));
        }
    }
}
