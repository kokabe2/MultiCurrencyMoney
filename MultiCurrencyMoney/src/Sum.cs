// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.

namespace MultiCurrencyMoney
{
    public class Sum : Expression
    {
        public Money augend;
        public Money addend;

        public Sum(Money augend, Money addend)
        {
            this.augend = augend;
            this.addend = addend;
        }

        public Money Reduce(Bank bank, string to)
        {
            int amount = augend.amount + addend.amount;
            return new Money(amount, to);
        }
    }
}
