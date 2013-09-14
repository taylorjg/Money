namespace MoneyExample
{
    public class Money
    {
        protected int Amount;

        public override bool Equals(object obj)
        {
            var money = (Money)obj;
            return Amount == money.Amount && GetType() == obj.GetType();
        }

        public override int GetHashCode()
        {
            return Amount.GetHashCode();
        }
    }
}
