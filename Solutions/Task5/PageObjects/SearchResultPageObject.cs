using OpenQA.Selenium;

namespace Task5.PageObjects;

public class SearchResultPageObject
{
    private IWebDriver _webDriver;
    
    private IEnumerable<IWebElement> PriceElementList => _webDriver.FindElements(By.XPath("//p[@class='price']/strong")); 
    
    
    public SearchResultPageObject(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }
        
    public IEnumerable<string> GetPrices()
    {
        return PriceElementList
            .Where(webElement => !string.IsNullOrEmpty(webElement.Text))
            .Select(webElement => webElement.Text);
    }
}