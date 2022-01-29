using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMsTest
{
    public static class CustomSetMethods
    {
        public static void EnterText(this IWebElement element, string value)
        {
            if(value == "skip")
            {
                Console.WriteLine("Skiping this Value");
            }
            else
            {
                element.SendKeys(value);
            }
        
        }
        public static void Clicks(this IWebElement element ,bool value = true)
        {
            if(value == false)
            {
                Console.WriteLine("Skiping this Click");
            }
            else
            {
                element.Click();
            }
            
        }
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
        }
    }
}
