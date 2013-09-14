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

        private readonly int _amount;
        private readonly string _currency;

        public Money(int amount, string currency)
        {
            _amount = amount;
            _currency = currency;
        }

        public override bool Equals(object obj)
        {
            var other = (Money)obj;

            return
                _amount.Equals(other._amount) &&
                Currency.Equals(other._currency);
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }

        public virtual Money Times(int multiplier)
        {
            return new Money(_amount * multiplier, _currency);
        }

        public string Currency
        {
            get { return _currency; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _amount, _currency);
        }

        public IExpression Plus(Money addend)
        {
            return new Money(_amount + addend._amount, _currency);
        }
    }
}
