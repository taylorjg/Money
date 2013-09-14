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
            Assert.That(five.Times(2), Is.EqualTo(new Dollar(10)));
            Assert.That(five.Times(3), Is.EqualTo(new Dollar(15)));
        }

        [Test]
        public void TestEquality()
        {
            Assert.That(new Dollar(5), Is.EqualTo(new Dollar(5)));
            Assert.That(new Dollar(5), Is.Not.EqualTo(new Dollar(6)));
        }
    }
}
