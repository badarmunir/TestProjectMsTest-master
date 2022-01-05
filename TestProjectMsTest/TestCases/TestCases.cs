
using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            ValueObjectData data = new ValueObjectData("fname", "lname", helper.GenerateNumber());
            GetPages.GetPage<HomePage>(driver)
            .NavigateToForm()
            .ClickPracticeForm();
            GetPages.GetPage<FormPage>(driver)
            .FillForm(data);
            //Assert.AreEqual(form_page.elem_Submit_Text.GetTextfromInputField(), TestData.texttoverify);
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
