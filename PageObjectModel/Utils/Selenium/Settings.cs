using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Utils.Selenium
{
    public class Settings
    {
        public static string BaseUrl = ConfigurationManager.AppSettings["baseUrl"];
        public static string WelcomeMessage = ConfigurationManager.AppSettings["WelcomeMessage"];
        public static string TestEmail = ConfigurationManager.AppSettings["TestEmail"];
    }
}
