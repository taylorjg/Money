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
        public void TestSimpleAddition()
        {
            var five = Money.Dollar(5);
            var sum = five.Plus(five);
            var bank = new Bank();
            var reduced = bank.Reduce(sum, "USD");
            Assert.That(reduced, Is.EqualTo(Money.Dollar(10)));
        }

        [Test]
        public void TestReduceSum()
        {
            var sum = new Sum(Money.Dollar(3), Money.Dollar(4));
            var bank = new Bank();
            var actual = bank.Reduce(sum, "USD");
            Assert.That(actual, Is.EqualTo(Money.Dollar(7)));
        }

        [Test]
        public void TestReduceMoney()
        {
            var bank = new Bank();
            var actual = bank.Reduce(Money.Dollar(1), "USD");
            Assert.That(actual, Is.EqualTo(Money.Dollar(1)));
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
            Assert.That(Money.Franc(5), Is.Not.EqualTo(Money.Dollar(5)));
        }
    }
}
