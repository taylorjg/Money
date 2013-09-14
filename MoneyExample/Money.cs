namespace MoneyExample
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount;
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
    }
}
