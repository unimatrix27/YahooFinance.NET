# YahooFinance.NET
Download historical end of day stock data and historical dividend data

Install via NUGET
```
Install-Package YahooFinance.NET
```

Usage
```
string exchange = "ASX";
string stockCode "AFI";
YahooFinance.NET.YahooFinance yahooFinance = new YahooFinance.NET.YahooFinance();
string yahooStockCode = yahooFinance.GetYahooStockCode(exchange, symbol);
List<YahooHistoricalPriceData> yahooPriceHistory = yahooFinance.GetHistoricalPriceData(yahooStockCode);
List<HistoricalDividendData> yahooDividendHistory = yahooFinance.GetHistoricalDividendData(yahooStockCode);
```
