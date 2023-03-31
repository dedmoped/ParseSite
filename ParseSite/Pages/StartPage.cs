using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using ParseSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseSite.Pages
{
    class StartPage
    {
        private IWebDriver _Browser;
      
        public StartPage(IWebDriver Browser)
        {
            _Browser = Browser;
            PageFactory.InitElements(Browser, this);
        }

        public StartPage InpuntInformation(string login,string password)
        {
            PassDataTwoPage passData = new PassDataTwoPage(_Browser);
            passData.Login(login, password);
            return this;

        }
    }
}
