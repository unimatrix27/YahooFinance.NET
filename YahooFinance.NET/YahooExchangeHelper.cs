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
			return _exchanges.TryGetValue(exchange.ToUpperInvariant(), out suffix) ? suffix : string.Empty;
		}

		private readonly Dictionary<string, string> _exchanges = new Dictionary<string, string>()
		{
			//Asia Pacific Stock Exchanges
			{"ASX", "AX"},
			{"HKG", "HK"},
			{"SHA", "SS"},
			{"SHE", "SZ"},
			{"NSE", "NS"},
			{"BSE", "BO"},
			{"JAK", "JK"},
			{"SEO", "KS"},
			{"KDQ", "KQ"},
			{"KUL", "KL"},
			{"NZE", "NZ"},
			{"SIN", "SI"},
			{"TPE", "TW"},
			//European Stock Exchanges
			{"WBAG", "VI"},
			{"EBR", "BR"},
			{"EPA", "PA"},
			{"BER", "BE"},
			{"ETR", "DE"},
			{"FRA", "F"},
			{"STU", "SG"},
			{"ISE", "IR"},
			{"BIT", "MI"},
			{"AMS", "AS"},
			{"OSL", "OL"},
			{"ELI", "LS"},
			{"MCE", "MA"},
			{"VTX", "VX"},
			{"LON", "L"},
			//Middle Eastern Stock Exchanges
			{"TLV", "TA"},
			//North American Stock Exchanges
			{"TSE", "TO"},
			{"CVE", "V"},
			{"AMEX", "AMEX"},
			{"NASDAQ", "NASDAQ"},
			{"NYSE", "NYSE"},
		};
	}
}
