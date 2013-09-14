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
            five.Times(2);
            Assert.That(five.amount, Is.EqualTo(10));
        }
    }
}
