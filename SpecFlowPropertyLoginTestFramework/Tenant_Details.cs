using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using System.Windows.Forms;

namespace SpecFlowPropertyLoginTestFramework
{
    public class Tenant_Details
    {
        public static string tenant_details_header()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            var tenant_Header = Browser.driver.FindElement(By.ClassName("keys-heading")).Text;
            if (tenant_Header == "Tenant Details")
                return ("Pass");
            else
                return ("Fail");
        }

        public static void tenant_DOB()
        {
            var DOB = Browser.driver.FindElement(By.Id("DOB"));
            DOB.SendKeys("10/12/1998");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
        public static void home_Phone_Number()
        {
            var home_Number = Browser.driver.FindElement(By.Name("HomePhoneNumber"));
            home_Number.SendKeys("123456789");
        }
        public static void mobile_Phone_Number()
        {
            var mobile_Number = Browser.driver.FindElement(By.Name("MobilePhoneNumber"));
            mobile_Number.SendKeys("0123456789");
        }

        public static void current_Address()
        {
            var current_Add = Browser.driver.FindElement(By.Name("searchAddress"));
            current_Add.SendKeys("1001A High Street, Avalon, Lower Hutt, New Zealand");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public static void photo_Upload()
        {
            Browser.driver.FindElement(By.Id("file-upload")).Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            SendKeys.SendWait(@"C:\Users\Dashy\Pictures\Car Photos\Test");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);
            SendKeys.SendWait(@"{Enter}");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            Browser.driver.FindElement(By.XPath("//*[@id='tenant - details']/div[2]/div/div[2]/div[1]/div")).Click();
        }
        public static void save_Click()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
            new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(By.Id("Save")));
            Browser.driver.FindElement(By.Id("Save")).Click();
        }

        public static void Cick_On_Skip_Button()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            Browser.driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

    }
}