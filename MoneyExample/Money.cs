namespace MoneyExample
{
    public class Money : IExpression
    {
        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }

        public int Amount { get; private set; }
        public string Currency { get; private set; }

        public Money(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public virtual Money Times(int multiplier)
        {
            return new Money(Amount * multiplier, Currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(Bank bank, string to)
        {
            var rate = bank.Rate(Currency, to);
            return new Money(Amount / rate, to);
        }

        public override bool Equals(object obj)
        {
            var other = (Money)obj;

            return
                Amount.Equals(other.Amount) &&
                Currency.Equals(other.Currency);
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", Amount, Currency);
        }
    }
}
