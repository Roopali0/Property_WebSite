using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowPropertyLoginTestFramework
{
    public class LoginPage
    {
        public static string url = "http://new-keys.azurewebsites.net/Account/Login?ReturnUrl=%2fPropertyOwners";

        public static void Can_Goto_LoginPage()
        {
            Browser.Initialize();
            Browser.GoToUrl(url);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.driver.Manage().Window.Maximize();
        }

        public static string Can_See_Login_Page_Title()
        {
            return Browser.driver.Title;
        }

        public static void Insert_User_Name()
        {
            var User_id = Browser.driver.FindElement(By.Id("UserName"));
            User_id.Clear();
            User_id.SendKeys("vincent.nguyen@mvpstudio.co.nz");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
       }

        public static void Insert_Password()
         {
            var Pwd_id = Browser.driver.FindElement(By.Id("Password"));
            Pwd_id.Clear();
            Pwd_id.SendKeys("ntmv2682");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Click_On_Login_Button()
        {
            Browser.driver.FindElement(By.XPath("//*[@id='sign_in']/div[1]/div[4]/button")).Click();
        }

        //public static void Cick_On_Skip_Button()
       // {
         //   Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
           // Browser.driver.FindElement(By.XPath("/html/body/div[5]/div/div[5]/a[1]")).Click();
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        //}
    }
}
