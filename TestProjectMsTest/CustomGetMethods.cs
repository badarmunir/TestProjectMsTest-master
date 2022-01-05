using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMsTest
{
    public static class CustomGetMethods
    {
        public static string GetText(this IWebElement element)
        {
            try
            {
                return element.Text;
            }
            catch(Exception e)
            {
                return element.GetAttribute("value");
            }
         
        }
        public static string GetTextFromDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
        }

        //public static IWebElement SetAttribute(this IWebElement element, string name, string value)
        //{
        //    var driver = driver;
        //    var jsExecutor = (IJavaScriptExecutor)driver;
        //    jsExecutor.ExecuteScript("arguments[0].setAttribute(arguments[1], arguments[2]);", element, name, value);
        //    return element;
        //}
    }
}
