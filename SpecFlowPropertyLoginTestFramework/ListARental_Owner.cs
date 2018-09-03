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
    public class ListARental_Owner
    {       
       public static void Owners_Rental_menu()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            var Owner_Menu = Browser.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Owner_Menu.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var rental_Listing = Browser.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]/div/a[2]"));
            rental_Listing.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public static void click_ListARental_btn()
        {
            new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='main-content']/div/div[1]/div[2]/div/div[2]/a")));
            Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/div[1]/div[2]/div/div[2]/a")).Click();

        }
        public static void select_Property()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var select_prop_dropdown = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[2]/select"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            var select_prop_dropdown_value = new SelectElement(select_prop_dropdown);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            select_prop_dropdown_value.SelectByText("44 Wonder Street, Sunshine, Broad Day, 9999");
        }
        public static void title()
        {
            var Rows_Count = Excel_Obj.ExcelApp();

            int rowCount = 0;
            string listing_Title;

            for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
            {
                listing_Title = (Rows_Count.Cells[rowCount, 1] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[3]/div[1]/input[1]"));
                User_id.Clear();
                User_id.SendKeys(listing_Title);
            }
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void moving_Cost()
        {
            
            var Rows_Count = Excel_Obj.ExcelApp();
            int rowCount = 0;
            string moving_Cost;

            for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
            {
                moving_Cost = (Rows_Count.Cells[rowCount, 2] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[3]/div[1]/input[2]"));
                User_id.Clear();
                User_id.SendKeys(moving_Cost);
            }
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Description()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Rows_Count = Excel_Obj.ExcelApp();

            int rowCount = 0;
            string description;

            for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
            {
                description = (Rows_Count.Cells[rowCount, 3] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[3]/div[2]/textarea"));
                User_id.Clear();
                User_id.SendKeys(description);
            }
        }

        public static void Target_Rent()

        {
            var Rows_Count = Excel_Obj.ExcelApp();
            int rowCount = 0;
            string description;

            for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
            {
                description = (Rows_Count.Cells[rowCount, 4] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[4]/div[1]/input"));
                User_id.Clear();
                User_id.SendKeys(description);
            }
        }

        public static void Furnishing()
        {
            var Rows_Count = Excel_Obj.ExcelApp();
            int rowCount = 0;
            string furnishing;

            for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
            {
                furnishing = (Rows_Count.Cells[rowCount, 5] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[4]/div[2]/input"));
                User_id.Clear();
                User_id.SendKeys(furnishing);
            }
        }
        public static void Available_Date()
        {
            //var Rows_Count = Excel_Obj.ExcelApp();
            //int rowCount = 0;
            //string available_Date;
            //for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
                //{
                //    available_Date = (Rows_Count.Cells[rowCount, 6] as excel.Range).Text;
                //    var User_id = Browser.driver.FindElement(By.Name("AvailableDate"));
                //    User_id.Clear();
                //    User_id.SendKeys(available_Date);
                //}

                Browser.driver.FindElement(By.Name("AvailableDate")).SendKeys("28/08/2017");
        }
        public static void Ideal_Tenant()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Rows_Count = Excel_Obj.ExcelApp();
            int rowCount = 0;
            string ideal_tenant;
            for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
            {
                ideal_tenant = (Rows_Count.Cells[rowCount, 7] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[5]/div[2]/input"));
                User_id.Clear();
                User_id.SendKeys(ideal_tenant);
            }
        }
        public static void Occupants_Count()
        {
            var Rows_Count = Excel_Obj.ExcelApp();
            int rowCount = 0;
            string occupants;
            for (rowCount = 2; rowCount <= Rows_Count.Rows.Count; rowCount++)
            {
                occupants = (Rows_Count.Cells[rowCount, 8] as excel.Range).Text;
                var User_id = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[6]/div[1]/input"));
                User_id.Clear();
                User_id.SendKeys(occupants);
            }
        }

        public static void pets_Allowed()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var select_pets_Allowed = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[6]/div[2]/select"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            var select_pets_Allowed_value = new SelectElement(select_pets_Allowed);
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            select_pets_Allowed_value.SelectByText("No");
        }
        public static void photo_Upload()
        {
            var choose_FilesBTN = Browser.driver.FindElement(By.Id("file-upload"));
            choose_FilesBTN.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
            SendKeys.SendWait(@"C:\Users\Dashy\Pictures\Car Photos\Test");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(70);
            SendKeys.SendWait(@"{Enter}");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
        }
        public static void save_Btn()
        {
            var Save_Btn = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/form/fieldset/div[8]/div/button[1]"));
            Save_Btn.Click();
        }   
    }
    }
