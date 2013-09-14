namespace MoneyExample
{
    public class Sum : IExpression
    {
        public Sum(Money augend, Money addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public Money Augend;
        public Money Addend;

        public Money Reduce(string to)
        {
            var amount = Augend.Amount + Addend.Amount;
            return new Money(amount, to);
        }
    }
}
