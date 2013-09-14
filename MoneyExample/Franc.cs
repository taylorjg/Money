namespace MoneyExample
{
    public class Franc
    {
        private readonly int _amount;

        public Franc(int amount)
        {
            _amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var otherFranc = (Franc)obj;
            return _amount == otherFranc._amount;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }
    }
}
