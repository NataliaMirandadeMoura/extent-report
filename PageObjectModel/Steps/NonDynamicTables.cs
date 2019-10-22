using PageObjectModel.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    public sealed class NonDynamicTables:BaseSteps
    {

        [Then(@"I see the page title contains ""(.*)""")]
        public void ThenISeeThePageTitleContains(string expectedTitle)
        {
            InstanceOf<BasePage>().ValidatePageTitle(expectedTitle);
        }
    }
}
