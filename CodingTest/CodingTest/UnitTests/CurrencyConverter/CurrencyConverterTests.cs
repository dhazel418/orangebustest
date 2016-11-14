using NUnit.Framework;

using SkeletonCode.CurrencyConverter;

namespace UnitTests.CurrencyConverter
{
	[TestFixture]
	public class CurrencyConverterTests
	{
		[Test]
		public void ItShouldConvertFromPoundsToDollarsCorrectly()
		{
			decimal amountInPounds = 1m;
			decimal expectedAmountInDollars =  1.25m;

			Converter converter = new Converter();
			decimal result = converter.Convert("GBP", "USD", amountInPounds);

			Assert.AreEqual(expectedAmountInDollars, result);
		}

		[Test]
		public void ItShouldConvertFromDollarsToPoundsCorrectly()
		{
			decimal amountInDollars = 1m;
			decimal expectedAmountInPounds = 0.8m;

			Converter converter = new Converter();
			decimal result = converter.Convert("USD", "GBP", amountInDollars);

			Assert.AreEqual(expectedAmountInPounds, result);
		}
		
		[Test]
		[ExpectedException()]
		public void AnExceptionShouldBeThrownIfAnUnknownCurrencyTypeIsPassedIn()
		{
			Converter converter = new Converter();
			converter.Convert("USD", "DDD", 100);
		}

	  [Test]
	  public void ItShouldConvertFromPoundsToEurosCorrectly()
	  {
      decimal amountInPounds = 1m;
      decimal expectedAmountInEuros = 0.97m;

      Converter converter = new Converter();
      decimal result = converter.Convert("GBP", "EUR", amountInPounds);

      Assert.AreEqual(expectedAmountInEuros, result);
    }

	  [Test]
	  public void ItShouldConvertFromEurosToPoundsCorrectly()
	  {
      decimal amountInEuros = 1m;
      decimal expectedAmountInPounds = 1.03m;

      Converter converter = new Converter();
      decimal result = converter.Convert("EUR", "GBP", amountInEuros);

      Assert.AreEqual(expectedAmountInPounds, result);
    }

	  [Test]
	  public void ItShouldConvertFromDollarsToEurosCorrectly()
	  {
	    decimal amountInDollars = 1m;
      decimal expectedAmountInEuros = 0.78m;

      Converter converter = new Converter();
      decimal result = converter.Convert("USD", "EUR", amountInDollars);

      Assert.AreEqual(expectedAmountInEuros, result);
    }

    [Test]
    public void ItShouldConvertFromEurosToDollarsCorrectly()
    {
      decimal amountInEuros = 1m;
      decimal expectedAmountInDollars = 1.29m;

      Converter converter = new Converter();
      decimal result = converter.Convert("EUR", "USD", amountInEuros);

      Assert.AreEqual(expectedAmountInDollars, result);
    }
  }
}
