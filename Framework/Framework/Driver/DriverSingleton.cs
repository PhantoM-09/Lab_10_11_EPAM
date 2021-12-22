

using Framework.Service;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Framework.Driver
{
    public class DriverSingleton
    {
        private static IWebDriver _webDriver;

        private DriverSingleton() { }

        public static IWebDriver GetDriver()
        {
            if(_webDriver == null)
            {
                switch(BrowserCreator.CreateBrowser().Name)
                {
                    case "firefox": _webDriver = new FirefoxDriver(); break;
                    default: _webDriver = new ChromeDriver(); break;
                }

                _webDriver.Manage().Window.Maximize();
            }

            return _webDriver;
        }

        public static void CloseDriver()
        {
            _webDriver.Quit();
            _webDriver = null;
        }
    }
}
