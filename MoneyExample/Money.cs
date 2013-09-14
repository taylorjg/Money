namespace MoneyExample
{
    public abstract class Money
    {
        protected int Amount;

        public static Money Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount);
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
    }
}
