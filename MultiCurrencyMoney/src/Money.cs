// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;

namespace MultiCurrencyMoney
{
    public class Money
    {
        protected int amount;

        public override bool Equals(Object o)
        {
            Money money = (Money)o;
            return amount == money.amount;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
