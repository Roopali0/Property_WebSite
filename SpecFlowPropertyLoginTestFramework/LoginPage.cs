using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;
using excel = Microsoft.Office.Interop.Excel;

namespace SpecFlowPropertyLoginTestFramework
{
    public class LoginPage
    {
       // public static string url = "http://new-keys.azurewebsites.net/Account/Login?ReturnUrl=%2fPropertyOwners";
    
        public static void Can_Goto_LoginPage()
        {
          string url = "http://new-keys.azurewebsites.net/Account/Login?ReturnUrl=%2fPropertyOwners";
        Browser.Initialize();
            Browser.GoToUrl(url);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Browser.driver.Manage().Window.Maximize();
        }

        public static void tenant_URL()
        {
            string url = "http://new-keys.azurewebsites.net/Tenants/Home/Onboarding";
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
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Open(@"C:\Users\Dashy\source\repos\SpecFlowPropertyLoginTestFrameworkSolution\TestData_Name_Pwd.xlsx");
            excel._Worksheet worksheet = workbook.Sheets[1];
            excel.Range range = worksheet.UsedRange;
            int rowCount = 0;
           string username;

            for (rowCount = 2; rowCount <= range.Rows.Count; rowCount++)
            {
                username = (range.Cells[rowCount, 1] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.Id("UserName"));
                User_id.Clear();
                User_id.SendKeys(username);
            }
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
          }

        public static void Insert_Password()
        {
           var Pwd_id = Browser.driver.FindElement(By.Id("Password"));
            Pwd_id.SendKeys("ntmv2682");

            //excel.Application application = new excel.Application();
            //excel.Workbook workbook = application.Workbooks.Open(@"C:\Users\Dashy\source\repos\ExcelDemo\TestData_Name_Pwd.xlsx");
            //excel._Worksheet worksheet = workbook.Sheets[1];
            //excel.Range range = worksheet.UsedRange;
            //int rowCount = 0;
            //string password;
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //for (rowCount = 2; rowCount <= range.Rows.Count; rowCount++)
            //{
            //    password = (range.Cells[rowCount, 2] as excel.Range).ToString();
            //    var Pwd_id = Browser.driver.FindElement(By.Id("Password"));
            //    //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            //    Pwd_id.Clear();
            //    Pwd_id.SendKeys(password);
            //    Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
         //   }
        }

        public static void Click_On_Login_Button()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
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
