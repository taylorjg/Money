namespace MoneyExample
{
    public interface IExpression
    {
        Money Reduce(Bank bank, string to);
        IExpression Times(int multiplier);
        IExpression Plus(IExpression addend);
    }
}
