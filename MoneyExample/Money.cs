namespace MoneyExample
{
    public class Money
    {
        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
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
                Currency.Equals(other.Currency);
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }

        public virtual Money Times(int multiplier)
        {
            return new Money(_amount * multiplier, Currency);
        }

        public string Currency
        {
            get { return _currency; }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", _amount, Currency);
        }
    }
}
