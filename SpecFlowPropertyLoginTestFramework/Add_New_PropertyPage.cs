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

namespace SpecFlowPropertyLoginTestFramework
{
    public class Add_New_PropertyPage
    {

        public static void Owners_Menu_click()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            var Owner_Menu = Browser.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Owner_Menu.Click();
        }

        public static void Properties_SubMenu_click()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Properties_SubMenu = Browser.driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/div[1]"));
            Properties_SubMenu.Click();

        }

        public static void Add_new_property_btn_click()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //IWebElement Btn_Add_New_Prop = Browser.driver.FindElement(By.ClassName("ui teal button"));
            var Add_new_property_btn = Browser.driver.FindElement(By.XPath("//*[@id='main-content']/div/div[1]/div/div[2]/div/div[2]/a[2]"));
            // / html / body / div[2] / div / div[1] / div / div[2] / div / div[2] / a[2]
            Add_new_property_btn.Click();
        }

        public static string PageLabel()
        {
            IWebElement Page_Label = Browser.driver.FindElement(By.ClassName("keys-heading"));
            string Page_Label_text = Page_Label.Text;
            if (Page_Label_text == "Property Details")
                return "Pass";
            else
                return "Fail";
        }

        public static void Property_Name()
        {
            var Prop_Name = Browser.driver.FindElement(By.Name("propertyName"));
            Prop_Name.SendKeys("Sydney Properties");
        }

        public static void Property_Type()
        {
            //  Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
              IWebElement Prop_Type = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[2]/div[2]/div"));
            
            Prop_Type.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            IWebElement Prop_Type_Section = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[2]/div[2]/div/div[2]/div[2]"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Prop_Type_Section.Click();

            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
         //   SelectElement select_prop_type = new SelectElement(Prop_Type);
           // select_prop_type.SelectByIndex(2);
           
          // IJavaScriptExecutor js = (IJavaScriptExecutor)Browser.driver;

          //  ((IJavaScriptExecutor)Browser.driver).ExecuteScript("arguments[0].click();",
            //     Browser.driver.FindElement(By.XPath("//html/body/form/select/option[1]")));
        }

        public static void Add_New_Address()
        {
            IList<IWebElement> Number_City_PostCode = Browser.driver.FindElements(By.Id("street_number"));

            Console.WriteLine(Number_City_PostCode.Count());

            Number_City_PostCode[0].SendKeys("400");
            Number_City_PostCode[1].SendKeys("Tauranga");
            Number_City_PostCode[2].SendKeys("3116");

            IList<IWebElement> Street_Suburb = Browser.driver.FindElements(By.Id("route"));
            Console.WriteLine(Street_Suburb.Count());
            Street_Suburb[0].SendKeys("Maunganui Road");
            Street_Suburb[1].SendKeys("Mount Maunganui");
            var Region = Browser.driver.FindElement(By.Id("region"));
            Region.SendKeys("Test");
        }

        public static void Add_Description()
        {
            var decsription_txtfield = Browser.driver.FindElement(By.ClassName("add-prop-desc"));
            decsription_txtfield.SendKeys("This housing of Sydney properties is available at an afffordable price.");
        }

        public static void Add_Target_Rent()
        {
            var Target_Rent = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[4]/div/div[1]/div[1]/input"));
            Target_Rent.SendKeys("500");
        }

        public static void Select_Rent_Type()
         {
           Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
           var rent_Type = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[4]/div/div[2]/div"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            rent_Type.Click();         
          //var rent_Type_Dropdown = new SelectElement(rent_Type);
         //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);            
           //          rent_Type_Dropdown.SelectByValue("1");
         }

        public static void Add_LandArea()
        {
            var Land_area = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[5]/div[1]/div/input"));
            Land_area.SendKeys("1000");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Add_FloorArea()
        {
            var Floor_Area = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[5]/div[2]/div/input"));
            Floor_Area.SendKeys("500");
        }

        public static void Add_BedRooms()
        {
            var BedRooms = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[6]/div[1]/div[1]/input"));
            BedRooms.SendKeys("2");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Add_Bathrooms()
        {
            var BathRooms = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[6]/div[2]/div[1]/input"));
            BathRooms.SendKeys("2");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void Add_CarParks()
        {
            var CarParks = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[7]/div[1]/div[1]/input"));
            CarParks.SendKeys("1");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public static void Add_Year_Built()
        {
            var YearBuilt = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[7]/div[2]/div[1]/input"));
            YearBuilt.SendKeys("2001");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            
        }
       
        public static void Add_Select_Photo()
        {
            var photo_text_Field = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[9]/div[1]/div"));
            photo_text_Field.Click();
        //    IWebElement choose_File_Btn = Browser.driver.FindElement(By.Id("file-upload"));
        //  choose_File_Btn.Click();            
        //   String path = "C:\\Users\\Dashy\\Pictures\\IMG_5091.JPG";
        // LocalFileDetector detector = new LocalFileDetector();
        }

        public static void Next_Click()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var next_btn = Browser.driver.FindElement(By.XPath("//*[@id='property-details']/div[10]/div/button[1]"));
            new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id='property-details']/div[10]/div/button[1]")));
            next_btn.Click();
         //   Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);            
         //   new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(50)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='financeSection']/h2")));
         //   var purchase_Price_TxtField = Browser.driver.FindElement(By.Name("purchasePrice"));
            // purchase_Price_TxtField.SendKeys("200000");
        }

        public static void Finance_Details_Label()
      {
       Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
      new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='financeSection']/h2")));
       Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        }

        //public static string Finance_Details_Label(string label)
        //{
        // Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
        //  new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(0)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='financeSection']/h2")));

        //      var Fin_det_label = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/h2"));
        //      var Fin_det_labelText = Fin_det_label.Text;
        //      if (Fin_det_labelText == label)
        //          return "Pass";
        //      else
        //          return "Fail";
        //  }

        public static void Add_Purchase_Price()
        {
            new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(50)).Until(ExpectedConditions.ElementIsVisible(By.Name("purchasePrice")));            
            var purchase_Price_TxtField = Browser.driver.FindElement(By.Name("purchasePrice"));
            purchase_Price_TxtField.SendKeys("200000");
        }

        public static void Add_Mortgage_Value()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var purchase_Price_TxtField = Browser.driver.FindElement(By.Name("mortgagePrice"));
            purchase_Price_TxtField.SendKeys("100000");
        }

        public static void Add_Home_Value()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var home_Value_TxtField = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[1]/div[3]/div[1]/input"));
            home_Value_TxtField.SendKeys("300000");
        }

        public static void Select_Home_Value_Type()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var home_Value_Type_select = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[1]/div[4]/div"));           
           home_Value_Type_select.Click();
            var home_Value_Type_Estimated = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[1]/div[4]/div/div[2]/div[2]"));
            home_Value_Type_Estimated.Click();
            //var select_home_Value_type = new SelectElement(home_Value_Type_select);
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //select_home_Value_type.SelectByIndex(2);               
        }

        public static void Add_Repayment_Click()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Add_Repayment = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[4]/div/a"));
            Add_Repayment.Click();
        }

        public static void Add_Repayment_Amount()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Add_Repayment_Amt = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[3]/div[1]/div[1]/div[1]/input"));
            Add_Repayment_Amt.SendKeys("1000");
        }

        public static void Select_Frequency()
        {
            var Select_Frequency_Repayment = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[3]/div[1]/div[2]/select"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          //  var Select_Frequency_Repayment_dropdown = new SelectElement(Select_Frequency_Repayment);
          //  Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Select_Frequency_Repayment_dropdown.SelectByIndex(1);
        }

        public static void Start_date()
        {
            var start_date_textField = Browser.driver.FindElement(By.Id("payment-start-date"));
            start_date_textField.SendKeys("23/07/2018");
        }

        public static void End_date()
        {
            var end_date_textField = Browser.driver.FindElement(By.Id("payment-end-date"));
            end_date_textField.SendKeys("22/07/2023");
        }

        public static void Add_Expense_Click()
        {
            var Add_Expense = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[7]/div/a"));
            Add_Expense.Click();
        }

        public static void Add_Expense_Amount()
        {
           IList<IWebElement> expense_Amount = Browser.driver.FindElements(By.Id("Text1"));
           expense_Amount[0].SendKeys("400");            
        }

        public static void Add_Expense_Description()
        {
            IList<IWebElement> expense_Description = Browser.driver.FindElements(By.Id("Text1"));
            expense_Description[1].SendKeys("This is a test decsription for expense");
        }

        public static void Add_Date_Expense()
        {
            var end_date_textField = Browser.driver.FindElement(By.Id("expense-date"));
            end_date_textField.SendKeys("25/07/2023");
        }
        public static string Tenant_Details_Label()
        {
            var tenant_detail_header = Browser.driver.FindElement(By.XPath("//*[@id='tenantSection']/h2"));
            var tenant_detail_header_txt = tenant_detail_header.Text;
            if (tenant_detail_header_txt == "Tenant Details")
                return "Pass";
            else
                return "Fail";
        }

        public static void Next_Finance_Click()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var next_btn_finance = Browser.driver.FindElement(By.XPath("//*[@id='financeSection']/div[8]/button[3]"));       
            next_btn_finance.Click();
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }
        public static void Add_Tenant_Email()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var tenant_Email_Txtfield = Browser.driver.FindElement(By.Id("email"));
            tenant_Email_Txtfield.SendKeys("roopalihello@gmail.com");
        }
        public static void is_Main_Tenant()
        {
            //var is_Main_Tenant_select = Browser.driver.FindElement(By.Id("email"));
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);            
          //  var is_Main_Tenant_Dropdown = new SelectElement(is_Main_Tenant_select);
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //             is_Main_Tenant_Dropdown.SelectByValue("1");
        }
        public static void tenant_First_Name()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var first_Name_TextField = Browser.driver.FindElement(By.Id("fname"));
            first_Name_TextField.SendKeys("Roopali");
        }
        public static void tenant_Last_Name()
        {
            var last_Name_TextField = Browser.driver.FindElement(By.Id("lname"));
            last_Name_TextField.SendKeys("Jain");
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void tenant_Start_Date()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var tenant_Start_Date = Browser.driver.FindElement(By.Id("sdate"));
            tenant_Start_Date.SendKeys("10/09/2018");
        }

        public static void tenant_End_Date()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var tenant_End_Date = Browser.driver.FindElement(By.Id("edate"));
            tenant_End_Date.SendKeys("09/09/2020");
        }
        public static void Add_Rent_Amount()
        {
            var Tenant_Rent_Amount = Browser.driver.FindElement(By.Id("ramount"));
            Tenant_Rent_Amount.SendKeys("500");
        }
        public static void Add_Payment_Frequency()
        {
            var Add_Payment_Frequency = Browser.driver.FindElement(By.XPath("//*[@id='tenantSection']/div[1]/div[8]/div"));
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Add_Payment_Frequency.Click();
            var Add_Payment_Frequency_Weekly = Browser.driver.FindElement(By.XPath("//*[@id='tenantSection']/div[1]/div[8]/div/div[2]/div[1]"));
            Add_Payment_Frequency_Weekly.Click();
            //var Select_Tenant_Payment_Frequency= new SelectElement(Add_Payment_Frequency);
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Select_Tenant_Payment_Frequency.SelectByIndex(1);
        }

        public static void Tenant_Payment_Start_Date()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            var Payment_Start_Date = Browser.driver.FindElement(By.Id("psdate"));
            Payment_Start_Date.SendKeys("11/09/2018");
        }
     
        public static void Tenant_Payment_Due_Date()
        {
            Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Payment_Due_Date = Browser.driver.FindElement(By.XPath("//*[@id='tenantSection']/div[1]/div[10]/div"));
            Payment_Due_Date.Click(); 
            //*[@id="tenantSection"]/div[1]/div[10]/div/div[2]/div[5]
            var Payment_Due_Date_Five = Browser.driver.FindElement(By.XPath("//*[@id='tenantSection']/div[1]/div[10]/div/div[2]/div[5]"));
            Payment_Due_Date_Five.Click();

            //var Payment_Due_Date_Dropdown = new SelectElement(Payment_Due_Date);
            ///Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Payment_Due_Date_Dropdown.SelectByValue("3");
        }

        public static void Add_New_Liability()
        {
            var New_Liability = Browser.driver.FindElement(By.XPath("//*[@id='tenantSection']/div[4]/a"));
            New_Liability.Click();
        }

        public static void Add_Liability_Name()
        {
            var Liability_Name = Browser.driver.FindElement(By.XPath("//*[@id='LiabilityDetail']/div/div[1]/div[1]/select"));
            Liability_Name.Click();
            Liability_Name.Click();

            // var Liability_Name_Dropdown = new  SelectElement(Liability_Name);
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Liability_Name_Dropdown.SelectByValue("2");
        }

        public static void Add_Liability_Amount()
        {
            //Browser.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var Liability_Amount = Browser.driver.FindElement(By.XPath("//*[@id='LiabilityDetail']/div/div[1]/div[2]/div[1]/input"));
            Liability_Amount.SendKeys("2000");
        }
        public static void Save_Property()
        {
            new WebDriverWait(Browser.driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(By.Id("saveProperty")));
            var Save_Property_Btn = Browser.driver.FindElement(By.Id("saveProperty"));
            Save_Property_Btn.Click();
         }
    }
    }
   