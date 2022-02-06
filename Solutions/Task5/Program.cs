namespace Task5;

using PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class Program
{
    private const string SearchPhrase = "kotki";

    public static void Main(string[] args)
    {
        IWebDriver webDriver = new ChromeDriver();
        RunWebCrawl(webDriver);
    }
    
    static void RunWebCrawl(IWebDriver webDriver)
    {
        HomePageObject homePageObject = new(webDriver);
        CommonPageObjects commonPageObjects = new(webDriver);
        SearchResultPageObject searchResultPageObject = new(webDriver);
        
        homePageObject.GoTo();
        commonPageObjects.AcceptCookies();
        commonPageObjects.InputSearchPhraseAndFind(SearchPhrase);
        var prices = searchResultPageObject.GetPrices();
        Console.WriteLine($"Average price: {GetAveragePrice(prices)}");
    }

    static double GetAveragePrice(IEnumerable<string> priceList)
    {
        return priceList
            .Select(listElement => listElement
                .Replace("Za darmo", "0")
                .Replace(" zł", "")
                .Replace(" ", ""))
            .Select(priceString => double.Parse(priceString))
            .Average();
    }
}