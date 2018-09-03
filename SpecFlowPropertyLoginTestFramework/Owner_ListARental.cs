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
using excel = Microsoft.Office.Interop.Excel;

namespace SpecFlowPropertyLoginTestFramework
{
    public class Owner_ListARental
    {
        public static void Owners_Rental_menu()
       {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            var Owner_Menu = Browser.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Owner_Menu.Click();
            var Rental_SubMenu = Browser.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[2]"));
            Rental_SubMenu.Click();
        }

        public static void select_property()
        {
         var Select_property = Browser.driver.FindElement(By.XPath("//*[@id='main - content']/div/form/fieldset/div[2]/select"));            
                SelectElement select_prop_dropdown = new SelectElement(Select_property);
            select_prop_dropdown.SelectByIndex(2);          
        }

        public static void Title()
        { 
        excel.Application application = new excel.Application();
        excel.Workbook workbook = application.Workbooks.Open(@"C:\Users\Dashy\source\repos\SpecFlowPropertyLoginTestFrameworkSolution\TestData_Name_Pwd.xlsx");
        excel._Worksheet worksheet = workbook.Sheets[1];
        excel.Range range = worksheet.UsedRange;
        int rowCount = 0;
        string username;

            for (rowCount = 2; rowCount <= range.Rows.Count; rowCount++)
            {
                username = (range.Cells[rowCount, 3] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.Id("UserName"));
        User_id.Clear();
                User_id.SendKeys(username);
            }
    Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
          }



    }
}
