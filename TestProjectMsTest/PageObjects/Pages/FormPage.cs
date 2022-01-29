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
            CustomSetMethods.EnterText(elem_Firstname, firstName);
             return this;
        }
        public FormPage SetLastName(string lastName)
        {
            CustomSetMethods.EnterText(elem_Lastname, lastName);
             return this;
        }
        public FormPage SetGenderMale()
        {
            CustomSetMethods.Clicks(elem_Gender_Male,false);
            return this;
        }
        public FormPage SetUserNumber(string userNumber)
        {
            CustomSetMethods.EnterText(elem_UserNumber, userNumber);
            return this;
        }
        public FormPage Submit()
        {
            CustomSetMethods.EnterText(elem_Submit, Keys.Enter);
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
