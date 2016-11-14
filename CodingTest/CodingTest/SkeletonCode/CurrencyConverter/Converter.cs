using System;
using System.Collections.Generic;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
    private readonly Dictionary<string, decimal> _currencyRateDictionary = new Dictionary<string, decimal>
    {
      { "EUR", 0.97m },
      { "GBP", 1.0m }, 
      { "USD", 1.25m } 
    };

	  private void ValidateCurrency(string currencyCode)
	  {
      if (!_currencyRateDictionary.ContainsKey(currencyCode))
      {
        throw new ArgumentException(string.Format("Unrecognised currency '{0}'", currencyCode));
      }
    }

    public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
      ValidateCurrency(inputCurrency);
      ValidateCurrency(outputCurrency);

			return amount;
		}
	}
}
