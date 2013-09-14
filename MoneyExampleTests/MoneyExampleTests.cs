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
            Assert.That(product.Amount, Is.EqualTo(10));
            product = five.Times(3);
            Assert.That(product.Amount, Is.EqualTo(15));
        }

        [Test]
        public void TestEquality()
        {
            Assert.That(new Dollar(5), Is.EqualTo(new Dollar(5)));
            Assert.That(new Dollar(5), Is.Not.EqualTo(new Dollar(6)));
        }
    }
}
