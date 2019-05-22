// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.

namespace MultiCurrencyMoney
{
    public interface Expression
    {
        Money Reduce(Bank bank, string to);
    }
}
