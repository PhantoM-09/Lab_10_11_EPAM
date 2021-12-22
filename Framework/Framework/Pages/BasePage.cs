using OpenQA.Selenium;

namespace Framework.Pages
{
    class BasePage
    {
        protected IWebDriver _webDriver;

        protected BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}
