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
            var five = Money.Dollar(5);
            Assert.That(five.Times(2), Is.EqualTo(Money.Dollar(10)));
            Assert.That(five.Times(3), Is.EqualTo(Money.Dollar(15)));
        }

        [Test]
        public void TestFrancMultiplication()
        {
            var five = Money.Franc(5);
            Assert.That(five.Times(2), Is.EqualTo(Money.Franc(10)));
            Assert.That(five.Times(3), Is.EqualTo(Money.Franc(15)));
        }

        [Test]
        public void TestCurrency()
        {
            Assert.That(Money.Dollar(1).Currency, Is.EqualTo("USD"));
            Assert.That(Money.Franc(1).Currency, Is.EqualTo("CHF"));
        }

        [Test]
        public void TestEquality()
        {
            Assert.That(Money.Dollar(5), Is.EqualTo(Money.Dollar(5)));
            Assert.That(Money.Dollar(5), Is.Not.EqualTo(Money.Dollar(6)));
            Assert.That(Money.Franc(5), Is.EqualTo(Money.Franc(5)));
            Assert.That(Money.Franc(5), Is.Not.EqualTo(Money.Franc(6)));
            Assert.That(Money.Franc(5), Is.Not.EqualTo(Money.Dollar(5)));
        }

        [Test]
        public void TestDifferentClassEquality()
        {
            Assert.That(new Money(10, "CHF"), Is.EqualTo(new Franc(10, "CHF")));
        }
    }
}
