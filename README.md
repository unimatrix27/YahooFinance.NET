# YahooFinance.NET
Download historical end of day stock data and historical dividend data

Install via NUGET
```
Install-Package YahooFinance.NET
```

Usage
```
var exchange = "ASX";
var stockCode "AFI";
var yahooFinance = new YahooFinance.NET.YahooFinance();
var yahooStockCode = yahooFinance.GetYahooStockCode(exchange, symbol);
var yahooPriceHistory = yahooFinance.GetHistoricalPriceData(yahooStockCode);
var yahooDividendHistory = yahooFinance.GetHistoricalDividendData(yahooStockCode);
```
