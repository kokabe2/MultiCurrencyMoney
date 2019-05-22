// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System.Collections.Generic;

namespace MultiCurrencyMoney
{
    public class Bank
    {
        Dictionary<Pair, int> rates = new Dictionary<Pair, int>();

        public Money Reduce(Expression source, string to)
        {
            return source.Reduce(this, to);
        }

        public void AddRate(string from, string to, int rate)
        {
            rates[new Pair(from, to)] = rate;
        }

        public int Rate(string from, string to)
        {
            if (from.Equals(to)) return 1;
            return rates[new Pair(from, to)];
        }
    }
}
