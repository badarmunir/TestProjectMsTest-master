
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestProjectMsTest.PageObjects;


namespace TestProjectMsTest
{
    [TestClass]
    public class TestCases : BaseTest
    {
        [TestMethod, TestCategory("Smoke")/*,Owner("badar")*/]
        
        public void TestMethod1()
        {
            TestUtils helper = new TestUtils();
            ValueObjectData data = new ValueObjectData("skip", "skip", helper.GenerateNumber());
            GetPages.GetPage<HomePage>(driver)
            .NavigateToForm()
            .ClickPracticeForm();
            GetPages.GetPage<FormPage>(driver)
            .FillForm(data);
            Assert.AreEqual(GetPages.GetPage<FormPage>(driver).elem_Submit_Text.Text, TestData.texttoverify);
        }

        [TestMethod, TestCategory("Regression")]
        public void TestMethod2()
        {
            GetPages.GetPage<HomePage>(driver)
                  .NavigateToForm()
            .ClickPracticeForm();
            GetPages.GetPage<FormPage>(driver).Submit();
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_Firstname.GetAttribute("required"));
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_Lastname.GetAttribute("required"));
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_Gender.GetAttribute("required"));
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_UserNumber.GetAttribute("required"));
        }
        [TestMethod,  TestCategory("Regression")]
        //[Ignore("Defect Id : PK1234")]
        public void TestMethod3()
        {

            GetPages.GetPage<HomePage>(driver)
                   .NavigateToForm()
             .ClickPracticeForm();
            GetPages.GetPage<FormPage>(driver).Submit();
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_Firstname.GetAttribute("required"));
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_Lastname.GetAttribute("required"));
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_Gender.GetAttribute("required"));
            Assert.AreEqual("true", GetPages.GetPage<FormPage>(driver).elem_UserNumber.GetAttribute("required"));
        }

    }
}
