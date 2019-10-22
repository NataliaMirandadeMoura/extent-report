using PageObjectModel.Pages;
using PageObjectModel.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    [Binding]
    public sealed class BaseScenariosSteps:BaseSteps
    {

        [Given(@"I navigate to the homepage")]
        public void GivenINavigateToTheHomepage()
        {
            InstanceOf<BasePage>().NavigateMainEnterPoint();
        }

        [Then(@"I see the page title contains ""(.*)""")]
        public void ThenISeeThePageTitleContains(string expectedText)
        {
            InstanceOf<BasePage>().ValidatePageTitle(expectedText);
        }

        [Then(@"I see")]
        public void ThenISee(Table table)
        {
            InstanceOf<BasePage>().ValidateMultipleTextInPageSource(table);
        }


    }
}
