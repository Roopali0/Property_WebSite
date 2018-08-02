using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using SpecFlowPropertyLoginTestFramework;
using Xunit;

namespace SpecFlowPropertyLoginTestFramework
{
    public class Base
    {
        public static void Initialize()
        {            
            LoginPage.Can_Goto_LoginPage();
            LoginPage.Insert_User_Name();
            LoginPage.Insert_Password();
            LoginPage.Click_On_Login_Button();
            // LoginPage.Cick_On_Skip_Button();
        }
    }
}