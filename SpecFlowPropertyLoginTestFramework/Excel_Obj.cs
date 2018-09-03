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
    public class Excel_Obj
    {        
        public static excel.Range ExcelApp( )
        {            
            excel.Application application = new excel.Application();
            excel.Workbook workbook = application.Workbooks.Open(@"C:\Users\Dashy\source\repos\SpecFlowPropertyLoginTestFrameworkSolution\TestData_Name_Pwd.xlsx");
            excel._Worksheet worksheet = workbook.Sheets[2];
            excel.Range range = worksheet.UsedRange;
            return range;
        }
        
    }
}
