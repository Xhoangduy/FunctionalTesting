using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.WebDriverExtensions;

namespace Test.Pages
{
    public class LoginPage
    {
        //Instance for webdriver
        public static IWebDriver driver;
        //Constructor

        public LoginPage(IWebDriver driver)
        {
            LoginPage.driver = driver;
        }
        //Page object
        public string getTitle()
        {
            return driver.Title;
        }
        public static readonly By emailtxt = By.Id("Email");
        public static readonly By passwordtxt = By.Id("Password");
        public static readonly By loginbtn = By.CssSelector("input.button-1.login-button");
        //Page method
        public void EnterEmailAddress(string email) //email = 2151050057duy@ou.edu.vn
        {
            driver.EnterText(emailtxt, email); //password = Duy322454
        }
        public void EnterPassword(string password)
        {
            driver.EnterText(passwordtxt, password);
        }

        public void ClickLoginButton()
        {
            driver.Click(loginbtn);
        }
        public bool IsEmailAccountDisplayed(String email)
        {
            return driver.getTextWithValueDisplayed(email);
        }

    }
}
