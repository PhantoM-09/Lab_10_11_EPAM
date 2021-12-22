using OpenQA.Selenium;
using System.Threading;

namespace Framework.Pages
{
    class AddOrderPage : BasePage
    {
        public AddOrderPage(IWebDriver webDriver) : base(webDriver) { }

        private static readonly By _submitButton = By.XPath("//*[@id='button-1023']");

        public MainPage SubmitAddOrder()
        {
            Thread.Sleep(30000);

            _webDriver.FindElement(_submitButton).Click();

            return new MainPage(_webDriver);
        }
    }
}
