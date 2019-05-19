// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount, string currency) : base(amount, currency)
        {
        }
    }
}
