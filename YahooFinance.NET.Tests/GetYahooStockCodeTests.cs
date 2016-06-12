using System;
using Xunit;

namespace YahooFinance.NET.Tests
{
	public class GetYahooStockCodeTests
	{
		[Fact]
		public void TestUppercase()
		{
			var yahooFinanceClient = new YahooFinanceClient();
			var yahooStockCode = yahooFinanceClient.GetYahooStockCode("ASX", "AFI");
			Assert.Equal("AFI.AX", yahooStockCode);
		}

		[Fact]
		public void TestLowerCaseExchange()
		{
			var yahooFinanceClient = new YahooFinanceClient();
			var yahooStockCode = yahooFinanceClient.GetYahooStockCode("asx", "AFI");
			Assert.Equal("AFI.AX", yahooStockCode);
		}

		[Fact]
		public void TestLowerCaseSymbol()
		{
			var yahooFinanceClient = new YahooFinanceClient();
			var yahooStockCode = yahooFinanceClient.GetYahooStockCode("ASX", "afi");
			Assert.Equal("AFI.AX", yahooStockCode);
		}

		[Fact]
		public void TestInvalidExchange()
		{
			var exchange = "ABC";
			var yahooFinanceClient = new YahooFinanceClient();
			var exception = Assert.Throws<Exception>(() => yahooFinanceClient.GetYahooStockCode("ABC", "AFI"));
			Assert.Equal($"The \"{exchange}\" exchange is not supported.", exception.Message);
		}
	}
}
