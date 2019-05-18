using System;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(Object o)
        {
            Dollar dollar = (Dollar)o;
            return amount == dollar.amount;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }
}
