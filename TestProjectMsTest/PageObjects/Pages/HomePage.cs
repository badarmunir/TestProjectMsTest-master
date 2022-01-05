using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProjectMsTest.PageObjects
{
    class HomePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='card mt-4 top-card'][2]")]
        [CacheLookup]
        private IWebElement elem_Form { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[text()='Practice Form']")]
        [CacheLookup]
        private IWebElement elem_PracticeForm { get; set; }

        public HomePage NavigateToForm()
        {
            elem_Form.Click();
            return this;
        }
        public HomePage ClickPracticeForm()
        {
            elem_PracticeForm.Click();
            return this;
        }
    }
}
