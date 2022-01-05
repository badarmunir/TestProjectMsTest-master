using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMsTest.PageObjects
{
    public static class GetPages
    {

        public static T GetPage<T>(this IWebDriver webDriver)
        {
            var page = (T)Activator.CreateInstance(typeof(T));
            PageFactory.InitElements(webDriver, page);
            return page;
        }

      
    }
}
