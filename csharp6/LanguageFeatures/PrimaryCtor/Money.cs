using System;

// PRIMARY CTOR REMOVED
// Can still have and set readonly auto property
// Also demonstrates nameof & string templates

namespace LanguageFeatures.PrimaryCtor
{
    public struct Money 
    {
        public Money(string currency, decimal amount)
        {
            Currency = currency;
            Amount = amount;
        }

     
        public string Currency { get; }
        public decimal Amount { get; }

        public static Money operator +(Money m1, Money m2)
        {
            if (string.Compare(m1.Currency, m2.Currency, StringComparison.InvariantCulture) != 0)
            {
                var message = "(Cannot add \{m1.Currency} to \{m2.Currency})";
                throw new InvalidOperationException(message);

                //throw new InvalidOperationException(String.Format("Cannot add {0} to {1}", m1.Currency, m2.Currency));
            }
            return new Money(m1.Currency, m1.Amount + m2.Amount);
        }
    }
}
