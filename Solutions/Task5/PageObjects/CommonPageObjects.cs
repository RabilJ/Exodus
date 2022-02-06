using OpenQA.Selenium;

namespace Task5.PageObjects;

public class CommonPageObjects
{
    private IWebDriver _webDriver;
    
    private IWebElement SearchBar => _webDriver.FindElement(By.XPath("//*[@id=\"headerSearch\"]"));
    private IWebElement SearchButton => _webDriver.FindElement(By.Id("submit-searchmain"));
    private IWebElement CookiesButton => _webDriver.FindElement(By.XPath("//*[@id=\"onetrust-accept-btn-handler\"]"));
    
    public CommonPageObjects(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }
    
    public void AcceptCookies()
    {
        CookiesButton.Click();
    }
    
    public void InputSearchPhraseAndFind(string searchPhrase)
    {
        SearchBar.SendKeys(searchPhrase);
        SearchButton.Click();
    }
}