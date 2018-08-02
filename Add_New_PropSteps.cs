using System;
using TechTalk.SpecFlow;
using SpecFlowPropertyLoginTestFramework;
using Xunit;

namespace SpecFlowPropertyLoginTestObject
{
    [Binding]
    public class Add_New_PropSteps: Base
    {
        [Given(@"I have logged in as a valid user")]
        public void GivenIHaveLoggedInAsAValidUser()

        {
            Base.Initialize();
            String page_Title = Browser.Return_Title();
            //string expected_Title = "Dashboard";
            //Assert.Equal(page_Title, expected_Title);
        }
        
        [Given(@"I Click on Owners menu")]
        public void GivenIClickOnOwnersMenu()
        {
            Add_New_PropertyPage.Owners_Menu_click();
        }
        
        [Given(@"I Click on the Properties link in the dropdown menu displayed")]
        public void GivenIClickOnThePropertiesLinkInTheDropdownMenuDisplayed()
        {
            Add_New_PropertyPage.Properties_SubMenu_click();
        }
        
        [When(@"I Click on the Add New Property button")]
        public void WhenIClickOnTheAddNewPropertyButton()
        {
            Add_New_PropertyPage.Add_new_property_btn_click();
        }
        
        [Then(@"I should see the property details pagge")]
        public void ThenIShouldSeeThePropertyDetailsPagge()
        {
            Browser.Return_Title();
            String page_Title = Browser.Return_Title();
            string expected_Title = "Properties | Add New Property";
            Assert.Equal(page_Title, expected_Title);
        }

        [Given(@"the Property Details page is open")]
        public void GivenThePropertyDetailsPageIsOpen()
        {
            Add_New_PropertyPage.PageLabel();
                
        }
        [Given(@"I Provide a valid Property Name")]
        public void GivenIProvideAValidPropertyName()
        {
            Add_New_PropertyPage.Property_Name();
        }
       
        [Given(@"I Select a valid Property Type")]
        public void GivenISelectAValidPropertyType()
        {
            Add_New_PropertyPage.Property_Type();
            
        }
        [Given(@"I Provide a Valid Address")]
        public void GivenIProvideAValidAddress()
        {
            Add_New_PropertyPage.Add_New_Address();
        }

        [Given(@"I Provide a valid Description")]
        public void GivenIProvideAValidDescription()
        {
            Add_New_PropertyPage.Add_Description();
        }
        [Given(@"I Provide a valid Target Rent")]
        public void GivenIProvideAValidTargetRent()
        {
            Add_New_PropertyPage.Add_Target_Rent();
        }
        [Given(@"I select a valid Rent Type")]

        public void GivenISelectAValidRentType()
        {
            Add_New_PropertyPage.Select_Rent_Type();
            //Console.Write("hi");
        }

        [Given(@"I  Provide a valid Land Area")]
        public void GivenIProvideAValidLandArea()
        {
            Add_New_PropertyPage.Add_LandArea();
        }
        [Given(@"I Provide a valid Floor Area")]
        public void GivenIProvideAValidFloorArea()
        {
            Add_New_PropertyPage.Add_FloorArea();
        }

        [Given(@"I Provide a valid data for Bedrooms")]
        public void GivenIProvideAValidDataForBedrooms()
        {
            Add_New_PropertyPage.Add_BedRooms();
        }
        [Given(@"I Provide a valid data for Bathrooms")]
        public void GivenIProvideAValidDataForBathrooms()
        {
            Add_New_PropertyPage.Add_Bathrooms();
        }
        [Given(@"I Provide a valid data for CarParks")]
        public void GivenIProvideAValidDataForCarParks()
        {
            Add_New_PropertyPage.Add_CarParks();
        }
        [Given(@"I Provide a valid data for Year Built")]
        public void GivenIProvideAValidDataForYearBuilt()
        {
            Add_New_PropertyPage.Add_Year_Built();
        }

        [Given(@"I Select a photo to upload")]
        public void GivenISelectAPhotoToUpload()
        {
            Add_New_PropertyPage.Add_Select_Photo();
//            Console.Write("In Photo upload call");
        }
        [Given(@"I Click on the Next button")]
        public void GivenIClickOnTheNextButton()
        {
            Add_New_PropertyPage.Next_Click();
        }
        [Given(@"I see the Finance Details Page")]
        public void GivenISeeTheFinanceDetailsPage()
        {
            Browser.Return_Title();
            String page_Title = Browser.Return_Title();
            string expected_Title = "Properties | Add New Property";
            Assert.Equal(page_Title, expected_Title);
            // Console.Write("hello");
        }
        [Given(@"the Finance Details page is open")]
        public void GivenTheFinanceDetailsPageIsOpen()
        {
            // Add_New_PropertyPage.Finance_Details_Label("Finance Details");
           Add_New_PropertyPage.Finance_Details_Label();
            Console.Write("hello");
        }



        [Given(@"I enter a valid Purchase Price")]
        public void GivenIEnterAValidPurchasePrice()
        {
            Add_New_PropertyPage.Add_Purchase_Price();
            Console.Write("hello");
        }
        
        [Given(@"I Provide a valid Mortgage value")]
        public void GivenIProvideAValidMortgageValue()
        {
            Add_New_PropertyPage.Add_Mortgage_Value();
        }

        [Given(@"I Provide a valid Home Value")]
        public void GivenIProvideAValidHomeValu()
        {
            Add_New_PropertyPage.Add_Home_Value();
        }

        [Given(@"I Select  a valid Home Value Type from the dropdown")]
        public void GivenISelectAValidHomeValueTypeFromTheDropdown()
        {
            Add_New_PropertyPage.Select_Home_Value_Type();
        }

        [Given(@"I Click on the Add Repayments option")]
        public void GivenIClickOnTheAddRepaymentsOption()
        {
            Add_New_PropertyPage.Add_Repayment_Click();
        }

        [Given(@"I Provide a valid Amount for the Repayment")]
        public void GivenIProvideAValidAmountForTheRepayment()
        {
            Add_New_PropertyPage.Add_Repayment_Amount();
        }

        [Given(@"I Select a valid Frequency for Repayment")]
        public void GivenISelectAValidFrequencyForRepayment()
        {
            Add_New_PropertyPage.Select_Frequency();
        }

        [Given(@"I Provide a valid Start Date for Repayment")]
        public void GivenIProvideAValidStartDateForRepayment()
        {
            Add_New_PropertyPage.Start_date();
        }

        [Given(@"I Provide a valid End Date for Repaymet")]
        public void GivenIProvideAValidEndDateForRepaymet()
        {
            Add_New_PropertyPage.End_date();
        }

        [Given(@"I Click on the Add Expense option")]
        public void GivenIClickOnTheAddExpenseOption()
        {
            Add_New_PropertyPage.Add_Expense_Click();
        }

        [Given(@"I Provide a valid Amount for the Expense")]
        public void GivenIProvideAValidAmountForTheExpense()
        {
            Add_New_PropertyPage.Add_Expense_Amount();
        }

        [Given(@"I Provide a valid Description for the Expense")]
        public void GivenIProvideAValidDescriptionForTheExpense()
        {
            Add_New_PropertyPage.Add_Expense_Description();
        }

        [Given(@"I Provide a valid Date for the Expense")]
        public void GivenIProvideAValidDateForTheExpense()
        {
            Add_New_PropertyPage.Add_Date_Expense();
        }        
        [When(@"I Click on the Next button to provide Tenant details")]
        public void WhenIClickOnTheNextButtonToProvideTenantDetails()
        {
            Add_New_PropertyPage.Next_Finance_Click();
        }

        [Then(@"I should see the Tenant Details page")]
        public void ThenIShouldSeeTheTenantDetailsPage()
        {
            Browser.Return_Title();
            String page_Title = Browser.Return_Title();
            string expected_Title = "Properties | Add New Property";
            Assert.Equal(page_Title, expected_Title);
        }

        [Given(@"I am on the Tenant Details page")]
        public void GivenIAmOnTheTenantDetailsPage()
        {
            Add_New_PropertyPage.Tenant_Details_Label();
        }

        [Given(@"I Provide the Tenant Email")]
        public void GivenIProvideTheTenantEmail()
        {
            Add_New_PropertyPage.Add_Tenant_Email();
        }

        [Given(@"I Select option from Is Main Tenant dropdown")]
        public void GivenISelectOptionFromIsMainTenantDropdown()
        {
            // Add_New_PropertyPage.is_Main_Tenant();
            Console.Write("Hello");
        }

        [Given(@"I Provide a valid First Name")]
        public void GivenIProvideAValidFirstName()
        {
            Add_New_PropertyPage.tenant_First_Name();
        }

        [Given(@"I Provide a valid Last Name")]
        public void GivenIProvideAValidLastName()
        {
            Add_New_PropertyPage.tenant_Last_Name();
        }

        [Given(@"I Provide a valid Start Date")]
        public void GivenIProvideAValidStartDate()
        {
            Add_New_PropertyPage.tenant_Start_Date();
        }
        [Given(@"I Provide a valid End Date")]
        public void GivenIProvideAValidEndDate()
        {
            Add_New_PropertyPage.tenant_End_Date();
        }

        [Given(@"I Provide a valid Rent Amount")]
        public void GivenIProvideAValidRentAmount()
        {
            Add_New_PropertyPage.Add_Rent_Amount();
        }

        [Given(@"I Provide a valid Payment Frequency")]
        public void GivenIProvideAValidPaymentFrequency()
        {
            Add_New_PropertyPage.Add_Payment_Frequency();
        }

        [Given(@"I Provide a valid Payment start date")]
        public void GivenIProvideAValidPaymentStartDate()
        {
            Add_New_PropertyPage.Tenant_Payment_Start_Date();
        }

        [Given(@"I Provide a valid Payment due date")]
        public void GivenIProvideAValidPaymentDueDate()
        {
            Add_New_PropertyPage.Tenant_Payment_Due_Date();
        }

        [Given(@"I Click on the Add New Liability option")]
        public void GivenIClickOnTheAddNewLiabilityOption()
        {
            Add_New_PropertyPage.Add_New_Liability();
        }

        [Given(@"I Select a Liability Name from the dropdown")]
        public void GivenISelectALiabilityNameFromTheDropdown()
        {
            Add_New_PropertyPage.Add_Liability_Name();
        }

        [Given(@"I Provide a valid amount for the corresponding Liability in the the amount field")]
        public void GivenIProvideAValidAmountForTheCorrespondingLiabilityInTheTheAmountField()
        {
            Add_New_PropertyPage.Add_Liability_Amount();
        }

        [When(@"I Click on the Save button to create a New Property")]
        public void WhenIClickOnTheSaveButtonToCreateANewProperty()
        {
            Add_New_PropertyPage.Save_Property();
        }

        [Then(@"the newly created property should be available")]
        public void ThenTheNewlyCreatedPropertyShouldBeAvailable()
        {
            Console.Write("Hi");
        }
    }
}
