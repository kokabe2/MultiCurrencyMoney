// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;

namespace MultiCurrencyMoney
{
    public abstract class Money
    {
        protected int amount;
        protected string currency;

        protected Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public abstract Money Times(int multiplier);

        public string Currency()
        {
            return currency;
        }

        public override bool Equals(Object o)
        {
            Money money = (Money)o;
            return amount == money.amount
                    && GetType().Name.Equals(money.GetType().Name);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }
    }
}
