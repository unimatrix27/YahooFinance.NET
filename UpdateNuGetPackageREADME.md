To update the NuGet package

- Increment AssemblyVersion in AssemblyInfo.cs
- Build in Release mode. The NuGet package will be created in the YahooFinance.NET\YahooFinance.NET directory
- Open command prompt to the directory with the NuGet package
- Set API key if it isnt already set
    nuget.exe setApiKey <API-Key> -Source https://www.nuget.org/api/v2/package
- Push the package
    nuget.exe push YahooFinance.NET.2.0.0.1.nupkg -Source https://www.nuget.org/api/v2/package
