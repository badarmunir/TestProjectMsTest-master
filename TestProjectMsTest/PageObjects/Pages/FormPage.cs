using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace TestProjectMsTest.PageObjects
{
    class FormPage
    {
        [FindsBy(How = How.Id, Using = "firstName")]
        [CacheLookup]
        public IWebElement elem_Firstname { get; set; }

        [FindsBy(How = How.Id, Using = "lastName")]
        [CacheLookup]
        public IWebElement elem_Lastname { get; set; }

        [FindsBy(How = How.Id, Using = "gender-radio-1")]
        [CacheLookup]
        public IWebElement elem_Gender { get; set; }

        [FindsBy(How = How.XPath, Using = "//label[text()='Male']")]
        [CacheLookup]
        public IWebElement elem_Gender_Male { get; set; }

        [FindsBy(How = How.Id, Using = "userNumber")]
        [CacheLookup]
        public IWebElement elem_UserNumber { get; set; }

        [FindsBy(How = How.Id, Using = "submit")]
        [CacheLookup]
        public IWebElement elem_Submit { get; set; }

        [FindsBy(How = How.Id, Using = "example-modal-sizes-title-lg")]
        [CacheLookup]
        public IWebElement elem_Submit_Text { get; set; }

        public FormPage SetFirstName(string firstName)
        {
            elem_Firstname.SendKeys(firstName);
             return this;
        }
        public FormPage SetLastName(string lastName)
        {
            elem_Lastname.SendKeys(lastName);
             return this;
        }
        public FormPage SetGenderMale()
        {
            elem_Gender_Male.Click();
             return this;
        }
        public FormPage SetUserNumber(string userNumber)
        {
            elem_UserNumber.SendKeys(userNumber);
             return this;
        }
        public FormPage Submit()
        {
            elem_Submit.SendKeys(Keys.Enter);
            return this;
        }

        public FormPage FillForm(ValueObjectData formData)
        {
            SetFirstName(formData.FirstName);
            SetLastName(formData.LastName);
            SetGenderMale();
            SetUserNumber(formData.Number);
            Submit();
            return this;
        }


    }

}
