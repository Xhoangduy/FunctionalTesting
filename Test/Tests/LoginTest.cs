using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Test.BasePage;
using Test.Pages;
using System.Configuration;
namespace Test.Tests
{
    [TestClass]
    public class LoginTest : BaseClass
    {
        HomePage homePage;
        [TestMethod]
        [TestCategory("Smoke")]
        public void VertifyLoginFunctionalityWithValidData() //Test case pass
        {
            string username = ConfigurationManager.AppSettings["Email"];
            string password = ConfigurationManager.AppSettings["Password"];
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(username);
            loginPage.EnterPassword(password);
            loginPage.ClickLoginButton();
        }


        [TestMethod] //Test case fail 1
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials()
        {
            string invalidUsername = "invalid@example.com";
            string invalidPassword = "invalidpassword";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn"); 
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }

        [TestMethod] //Test case fail 2
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials2()
        {
            string invalidUsername = "invalid2@example.com";
            string invalidPassword = "invalid2password";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }

        [TestMethod] //Test case fail 3
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials3()
        {
            string invalidUsername = "invalid3@example.com";
            string invalidPassword = "invalid3password";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }

        [TestMethod] //Test case fail 4
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials4()
        {
            string invalidUsername = "invalid4@example.com";
            string invalidPassword = "invalid4password";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }

        [TestMethod] //Test case fail 5
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials5()
        {
            string invalidUsername = "invalid5@example.com";
            string invalidPassword = "invalid5password";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }

        [TestMethod] //Test case fail 6
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials6()
        {
            string invalidUsername = "invalid6@example.com";
            string invalidPassword = "invalid6password";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }

        [TestMethod] //Test case fail 7
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials7()
        {
            string invalidUsername = "invalid7@example.com";
            string invalidPassword = "invalid7password";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }

        [TestMethod] //Test case fail 8
        [TestCategory("Regression")]
        public void VerifyLoginFunctionalityWithInvalidCredentials8()
        {
            string invalidUsername = "invalid8@example.com";
            string invalidPassword = "invalid8password";
            homePage = new HomePage(driver);
            LoginPage loginPage = new LoginPage(driver);
            homePage.ClickLoginLink();
            string title = homePage.getTitle();
            Assert.AreEqual(title, "Demo Web Shop. Login");
            loginPage.EnterEmailAddress(invalidUsername);
            loginPage.EnterPassword(invalidPassword);
            loginPage.ClickLoginButton();
            bool isErrorDisplayed = loginPage.IsEmailAccountDisplayed("2151050057duy@ou.edu.vn");
            Assert.IsTrue(isErrorDisplayed, "Expected error message to be displayed when logging in with invalid credentials.");
        }
    }
}
