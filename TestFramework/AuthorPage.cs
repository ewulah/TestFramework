using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class AuthorPage
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='content']/div[1]/div/div[2]/h2")]
            
        private OpenQA.Selenium.IWebElement authorName;
        public string AuthorName
        {
            get { return authorName.Text; }
        }

        public bool IsAtAuthorPage(string authorName)
        {
            var authorPage = new AuthorPage();
            PageFactory.InitElements(Browser.Driver, authorPage);
            return authorPage.AuthorName == authorName;
        }
    }
}
