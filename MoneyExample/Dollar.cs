namespace MoneyExample
{
    public class Dollar
    {
        private readonly int _amount;

        public Dollar(int amount)
        {
            _amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(_amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            var otherDollar = (Dollar)obj;
            return _amount == otherDollar._amount;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }
    }
}
