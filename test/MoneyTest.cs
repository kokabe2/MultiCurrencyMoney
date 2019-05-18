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
            Dollar five = new Dollar(5);

            five.Times(2);

            Assert.Equal(10, five.amount);
        }
    }
}
