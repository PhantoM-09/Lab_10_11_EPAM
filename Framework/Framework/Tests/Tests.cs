using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework.Tests
{
    class Tests : CommonConditions
    {
        private static readonly string _expectedFirstTest = "Order FILLED";
        private static readonly string _expectedSecondTest = "gridview-1278-record-AUD/CAD";


        [Test]
        public void Test1()
        {
            string actual = mainPage.CloseWhatsNewWindow()
                                    .ChooseOrder()
                                    .DeleteOrder()
                                    .GetDeletingResult();

            Assert.IsTrue(string.Equals(actual, _expectedFirstTest));
        }

        [Test]
        public void Test2()
        {
            string actual = mainPage.CloseWhatsNewWindow()
                                    .AddSymbol()
                                    .GetIdValueElement();

            Assert.AreEqual(actual, _expectedSecondTest);
        }

    }
}
