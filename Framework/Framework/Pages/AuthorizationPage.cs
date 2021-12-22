using Framework.Model;
using Framework.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace Framework.Pages
{
    class AuthorizationPage : BasePage
    {
        public AuthorizationPage(IWebDriver webDriver) : base(webDriver) { }

        private static readonly string _url = "https://demo-login.dukascopy.com/web-platform/";

        private static readonly By _loginInput = By.XPath("//input[@name='login']");
        private static readonly By _passwordInput = By.XPath("//input[@name='password']");
        private static readonly By _loginButton = By.XPath("//span[@id='dds-button-ripple-1035-btnIconEl']");

        public AuthorizationPage OpenPage()
        {
            _webDriver.Navigate().GoToUrl(_url);
            Logger.ShowInfo("Open Login page");

            return this;
        }

        public AuthorizationPage EnterUsernameAndPassword(User user)
        {
            Thread.Sleep(10000);

            _webDriver.FindElement(_loginInput).SendKeys(user.Login);
            _webDriver.FindElement(_passwordInput).SendKeys(user.Password);

            Logger.ShowInfo("Enter login and password");
            return this;
        }

        public MainPage SignIn()
        { 
            _webDriver.FindElement(_loginButton).Click();
            Logger.ShowInfo("Click SignIn button");

            return new MainPage(_webDriver);
        }
    }
}
