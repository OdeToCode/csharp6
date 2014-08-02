using System;

namespace LanguageFeatures.PrimaryCtor
{
    public struct Money2
    {
        public Money2(string currency, decimal amount) : this()
        {
            Currency = currency;
            Amount = amount;
        }

        public string Currency { get;set; }
        public decimal Amount { get; set; }
    }

    public struct Money(string currency, decimal amount)
    {
        public string Currency { get; } = currency;
        public decimal Amount { get; } = amount;

        public static Money operator +(Money m1, Money m2)
        {
            if (string.Compare(m1.Currency, m2.Currency, StringComparison.InvariantCulture) != 0)
            {
                throw new InvalidOperationException(String.Format("Cannot add {0} to {1}", m1.Currency, m2.Currency));
            }
            return new Money(m1.Currency, m1.Amount + m2.Amount);
        }
    }
}
