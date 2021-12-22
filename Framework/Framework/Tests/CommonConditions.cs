

using Framework.Driver;
using Framework.Model;
using Framework.Pages;
using Framework.Service;
using Framework.Utils;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Framework.Tests
{
    class CommonConditions
    {
        protected IWebDriver webDriver;

        protected MainPage mainPage;

        [SetUp]
        public void StartPageSetup()
        {
            Logger.ShowInfo($"Start test: {TestContext.CurrentContext.Test.MethodName}");

            webDriver = DriverSingleton.GetDriver();
            User testUser = UserCreator.CreateUserWithCredentialsFromProperty();
            mainPage = new AuthorizationPage(webDriver).OpenPage().EnterUsernameAndPassword(testUser).SignIn();
        }

        //[TearDown]
        //public void CloseBrowser()
        //{
        //    Logger.ShowInfo($"Close test: {TestContext.CurrentContext.Test.MethodName}");
        //    DriverSingleton.CloseDriver();
        //}
    }
}
