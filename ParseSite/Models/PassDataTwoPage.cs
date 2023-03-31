using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseSite.Models
{
    class PassDataTwoPage
    {
        IWebDriver _Browser;
        public PassDataTwoPage(IWebDriver Browser)
        {
            _Browser = Browser;
        }
        public void Login(string login,string pasword)
        {
            WebDriverWait wait = new WebDriverWait(_Browser, TimeSpan.FromSeconds(20));
            wait.Until(e => e.FindElement(By.Id("mat-input-0"))).SendKeys(login);
            wait.Until(e => e.FindElement(By.Id("mat-input-1"))).SendKeys(pasword);
        }
    }
}
