using System.Collections.Generic;

namespace YahooFinance.NET
{
	internal class YahooExchangeHelper
	{
		public string GetYahooStockCode(string exchange, string code)
		{
			var exchangeSuffix = GetYahooExchangeSuffix(exchange);

			return !string.IsNullOrEmpty(exchangeSuffix) ? $"{code}.{exchangeSuffix}" : code;
		}

		private string GetYahooExchangeSuffix(string exchange)
		{
			string suffix;
			return _exchanges.TryGetValue(exchange, out suffix) ? suffix : string.Empty;
		}

		private readonly Dictionary<string, string> _exchanges = new Dictionary<string, string>()
		{
			{"ASX", "AX"}
		};
	}
}
