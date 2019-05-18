// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;

namespace MultiCurrencyMoney
{
    public class Franc
    {
        int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public override bool Equals(Object o)
        {
            Franc Franc = (Franc)o;
            return amount == Franc.amount;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
