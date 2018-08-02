using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;


namespace SpecFlowPropertyLoginTestFramework
{
    public class Browser
       {
        public static IWebDriver driver
        {
            get;
            set;
        }
        internal static void GoToUrl(string url)
        {
            driver.Url = url;
        }

        public static void Initialize()
        {
            driver = new ChromeDriver();
        }

        public static string Return_Title()
        {
            return driver.Title;
        }
    }
}
