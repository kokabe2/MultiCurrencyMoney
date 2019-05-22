// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;

namespace MultiCurrencyMoney
{
    public class Money : Expression
    {
        public int amount;
        string currency;

        public Money(int amount, string currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public Money Times(int multiplier)
        {
            return new Money(amount * multiplier, currency);
        }

        public Expression Plus(Money addend)
        {
            return new Sum(this, addend);
        }

        public Money Reduce(string to)
        {
            return this;
        }

        public string Currency()
        {
            return currency;
        }

        public override bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount && currency.Equals(money.currency);
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return amount + " " + currency;
        }

        public static Money Dollar(int amount)
        {
            return new Money(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Money(amount, "CHF");
        }
    }
}
