using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace TestFramework
{
    public class HomePage
    {
        static string Url = "https://pluralsight.com";
        public static string PageTitle = "Pluralsight | Unlimited Online Developer, IT and Creative Training";

        [FindsBy(How = How.Name, Using = "q")]
        private OpenQA.Selenium.IWebElement searchbox;

        private OpenQA.Selenium.IWebElement authorLink;

        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt()
        {
            return Browser.title == PageTitle;
        }

        public void SelectAuthor(string authorName)
        {

            //Utils utils = new Utils();
            searchbox.Click();
            searchbox.SendKeys("authors");
            //searchbox.Click();
            searchbox.SendKeys(Keys.Enter);
            // utils.Wait(2000, 1000);
            Thread.Sleep(5000);
            Browser.Driver.FindElement(By.XPath(".//*[@id='author-list-target']/div/div[4]/a/div[2]")).Click();
            Thread.Sleep(10000);
        }

    }
}
