using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Test.BasePage;
using Test.Pages;

namespace Test.Tests
{
    [TestClass]
    public class RegisterTest : BaseClass
    {
        String email = "21510500999duy@ou.edu.vn";
        public HomePage homePage;
        public RegisterPage registerPage;
        [TestCategory("Smoke")]
        [TestMethod]
        public void VerifyRegisterFuntionalityWithValidData() //test case pass
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail(email);
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed(email);
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        //[TestCategory("UnitTest")]
        //[TestMethod]
        //public void VerifyAppLogoDisplayed()
        //{

        //}

        [TestMethod]
        [TestCategory("Smoke")]

        public void VerifyRegisterFuntionalityWithValidData1() //Test case fail 1
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050057duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyRegisterFuntionalityWithValidData2() //Test case fail 2
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050058duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyRegisterFuntionalityWithValidData3() //Test case fail 3
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050059duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyRegisterFuntionalityWithValidData4() //Test case fail 4
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050060duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyRegisterFuntionalityWithValidData5() //Test case fail 5
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050061duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyRegisterFuntionalityWithValidData6() //Test case fail 6
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050062duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyRegisterFuntionalityWithValidData7() //Test case fail 7
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050063duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }

        [TestMethod]
        [TestCategory("Smoke")]
        public void VerifyRegisterFuntionalityWithValidData8() //Test case fail 8
        {
            homePage = new HomePage(driver);
            registerPage = new RegisterPage(driver);
            Assert.AreEqual(homePage.getTitle(), "Demo Web Shop");
            homePage.ClickRegisterLink();
            Assert.AreEqual(registerPage.getTitle(), "Demo Web Shop. Register");
            registerPage.SelectMaleRadio();
            registerPage.EnterFirstName("Hoang");
            registerPage.EnterLastName("Duy");
            registerPage.EnterEmail("2151050064duy@ou.edu.vn");
            registerPage.EnterPassword("Duy322454");
            registerPage.EnterConfirmPassword("Duy322454");
            registerPage.ClickRegisterbtn();
            String result = registerPage.GetSuccessfullMessage();
            Assert.AreEqual(result, "Your registration completed");
            bool isTrue = registerPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isTrue);
            registerPage.clickLogout();
        }
    }
}
