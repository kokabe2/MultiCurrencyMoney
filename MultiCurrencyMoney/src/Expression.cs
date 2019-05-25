// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.

namespace MultiCurrencyMoney
{
    public interface Expression
    {
        Expression Times(int multiplier);
        Expression Plus(Expression addend);
        Money Reduce(Bank bank, string to);
    }
}
