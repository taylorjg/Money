using System;
using System.Collections.Generic;

namespace MoneyExample
{
    public class Bank
    {
        // I have used a Tuple<string, string> here instead of creating a Pair class.
        private readonly IDictionary<Tuple<string, string>, int> _rates = new Dictionary<Tuple<string, string>, int>();

        public Money Reduce(IExpression source, string to)
        {
            return source.Reduce(this, to);
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to))
            {
                return 1;
            }

            var rate = _rates[MakeRatesKey(from, to)];
            return rate;
        }

        public void AddRate(string from, string to, int rate)
        {
            _rates.Add(MakeRatesKey(from, to), rate);
        }

        private static Tuple<string, string> MakeRatesKey(string from, string to)
        {
            return Tuple.Create(from, to);
        }
    }
}
