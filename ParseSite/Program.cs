using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ParseSite.Models;
using ParseSite.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseSite
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ParseExcel parseExcel = new ParseExcel(@"D:\Visual\ParseSite\ParseSite\test1.xlsx");
                parseExcel.ParseData("Лист1");
                IWebDriver Browser = new ChromeDriver(@"D:\Visual\test\test\");
                Browser.Navigate().GoToUrl("https://visa.vfsglobal.com/blr/ru/pol/login");
                StartPage homePage = new StartPage(Browser).InpuntInformation("dedmoped@gmail.com", "Dedtest1");
                Console.ReadKey();
                Browser.Quit();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
