using Framework.Utils;
using OpenQA.Selenium;
using System.Threading;

namespace Framework.Pages
{
    class MainPage : BasePage
    {
        public MainPage(IWebDriver webDriver) : base(webDriver) { }

        private static readonly By _whatsNewButton = By.XPath("//span[@id='button-1531-btnInnerEl']");
        private static readonly By _positionTab = By.XPath("//a[@class='x-tab x-unselectable x-tab-after-title x-box-item x-ltr x-tab-default x-top x-tab-top x-tab-default-top x-noicon x-tab-noicon x-tab-default-noicon']");
        private static readonly By _choiceOrderCheckBox = By.XPath("//tbody[@id='gridview-1415-body']//tr//td//div//div");
        private static readonly By _deleteOrderButton = By.XPath("//span[@id='button-1426-btnIconEl']");
        private static readonly By _popUpInfoWindow = By.XPath("//div[@id='d-dialog-orders']//div//div//div[@class='d-body-box x-unselectable']//div//p");

        private static readonly By _listSections = By.XPath("//span[@id='button-1281-btnIconEl']");
        private static readonly By _listSymbols = By.XPath("//div[@class='x-component x-box-item x-ltr x-component-default x-menu-item']");
        private static readonly By _symbol = By.XPath("//div[@class='x-component x-box-item x-ltr x-component-default x-menu-item x-menu-item-unchecked']");
        private static readonly By _listAddedSymbols = By.XPath("//tr[@data-boundview='gridview-1278']");

        private static readonly By _placeOfferButton = By.XPath("//*[@class='spread tradable x-unselectable']");

        public MainPage CloseWhatsNewWindow()
        {
            Thread.Sleep(35000);
            _webDriver.FindElement(_whatsNewButton).Click();
            Logger.ShowInfo("Hide pop-up window with info about updates");

            return this;
        }

        public MainPage ChooseOrder()
        {
            _webDriver.FindElement(_positionTab).Click();
            Thread.Sleep(20000);

            _webDriver.FindElement(_choiceOrderCheckBox).Click();
            Logger.ShowInfo("Choose the first order");
            return this;
        }

        public MainPage DeleteOrder()
        { 
            _webDriver.FindElement(_deleteOrderButton).Click();
            Logger.ShowInfo("Delete selected order");
            return this;
        }

        public string GetDeletingResult()
        {
            Thread.Sleep(20000);
            Logger.ShowInfo("Search information about deleting an item");

            return _webDriver.FindElement(_popUpInfoWindow).Text.Substring(0, 12);
        }

        public MainPage AddSymbol()
        {
            _webDriver.FindElement(_listSections).Click();
            _webDriver.FindElements(_listSymbols)[0].Click();
            Thread.Sleep(10000);

            _webDriver.FindElements(_symbol)[0].Click();

            return this;
        }

        public string GetIdValueElement()
        {
            Thread.Sleep(10000);
            return _webDriver.FindElements(_listAddedSymbols)[0].GetAttribute("id");
        }

        public AddOrderPage AddOrder()
        {
            Thread.Sleep(10000);
            _webDriver.FindElement(_placeOfferButton).Click();

            return new AddOrderPage(_webDriver);
        }
    }
}
