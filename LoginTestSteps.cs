using System;
using TechTalk.SpecFlow;
using SpecFlowPropertyLoginTestFramework;
using Xunit; 


namespace SpecFlowPropertyLoginTestObject
{
    [Binding]
    public class LoginTestSteps
    {
        [Given(@"I launch the url in the Browser")]
        public void GivenILaunchTheUrlInTheBrowser()
        {
            LoginPage.Can_Goto_LoginPage();   
        }
        
        [Given(@"I am on the Login page")]
        public void GivenIAmOnTheLoginPage()
        {
            LoginPage.Can_See_Login_Page_Title();
        }

        [Given(@"I am inserting a valid User")]
        public void GivenIAmInsertingAValidUser()
        { 
            LoginPage.Insert_User_Name();
        }

        [Given(@"I am inserting a valid Password")]
        public void GivenIAmInsertingAValidPassword()
        {
            LoginPage.Insert_Password();
        }
        
        [When(@"I press Login button")]
        public void WhenIPressLoginButton()
        {
            LoginPage.Click_On_Login_Button();
        }
        
        [Then(@"I should see the My Properties page")]
        public void ThenIShouldSeeTheMyPropertiesPage()
        {
            LoginPage.Can_See_Login_Page_Title();
            //LoginPage.Cick_On_Skip_Button();
        }
    }
}