namespace MoneyExample
{
    public abstract class Money
    {
        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

        protected readonly int Amount;
        private readonly string _currency;

        protected Money(int amount, string currency)
        {
            Amount = amount;
            _currency = currency;
        }

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount && GetType() == obj.GetType();
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }

        public abstract Money Times(int multiplier);

        public string Currency
        {
            get { return _currency; }
        }
    }
}
