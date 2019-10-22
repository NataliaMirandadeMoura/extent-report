using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Selenium
{
    [Binding]
    internal class Driver
    {

        internal static IWebDriver Browser() => DriverController.Instance.WebDriver;

        //  internal static IWebDriver Browser(){
        //  return DriverController.Instance.WebDriver;

    }
}
