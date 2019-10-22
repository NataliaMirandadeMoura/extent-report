using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectModel.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static PageObjectModel.Utils.Selenium.Driver;

namespace PageObjectModel.Pages
{
    public class BasePage: Page
    {
        public IWebDriver Driver { get; internal set; }
        public string GetTitle => Driver.Title;
        public string GetPageSource => Driver.PageSource;

        public void ValidateMultipleTextInPageSource(Table table)
        {
           foreach(var row in table.Rows)
            {
                var textToValidate = row["expectedText"];
                Assert.IsTrue(GetPageSource.Contains(textToValidate), "This gyugyu is not the expected text!");
                Console.WriteLine(":: The text " + textToValidate + "is in the PageSource");
            }
        }

        public void ValidatePageTitle(string expectedTitle)
        {
            var titleToValidate = Driver.Title.Contains(expectedTitle);
            Assert.IsTrue(titleToValidate);
            Console.WriteLine(":: the title of the site is" + GetTitle);
        }
        public void NavigateMainEnterPoint()
        {
            var baseUrl = Settings.BaseUrl;
            Browser().Navigate().GoToUrl(baseUrl);
            Browser().Manage().Window.Maximize();
            Console.WriteLine(Settings.WelcomeMessage);
            
        }

    }
}
