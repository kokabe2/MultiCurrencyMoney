// Copyright(c) 2019 Ken Okabe
// This software is released under the MIT License, see LICENSE.
using System;
using Xunit;
using MultiCurrencyMoney;

namespace MultiCurrencyMoneyTest
{
    public class MoneyTest
    {
        [Fact]
        public void testMultiplication()
        {
            Money five = Money.Dollar(5);
            Assert.Equal(Money.Dollar(10), five.Times(2));
            Assert.Equal(Money.Dollar(15), five.Times(3));
        }

        [Fact]
        public void testEquality()
        {
            Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
            Assert.False(Money.Dollar(5).Equals(Money.Franc(5)));
        }

        [Fact]
        public void testCurrency()
        {
            Assert.Equal("USD", Money.Dollar(1).Currency());
            Assert.Equal("CHF", Money.Franc(1).Currency());
        }
    }
}
