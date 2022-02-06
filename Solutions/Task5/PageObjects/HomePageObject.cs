namespace Task5.PageObjects;

using OpenQA.Selenium;

public class HomePageObject
{
    private IWebDriver _webDriver;
    private string homeURL = "https://www.olx.pl/";
    
    public HomePageObject(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public void GoTo()
    {
        _webDriver.Navigate().GoToUrl(homeURL);
    }
}