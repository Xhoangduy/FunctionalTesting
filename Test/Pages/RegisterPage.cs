using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.WebDriverExtensions;

namespace Test.Pages
{
    public class RegisterPage
    {
        //Webdriver instance
        public static IWebDriver driver;
        //Constructer
        public RegisterPage(IWebDriver driver)
        {
              RegisterPage.driver = driver;
        }

        public String getTitle()
        {
            return driver.Title;
        }

        //page object
        public static readonly By genderMale = By.Id("gender-male");
        public static readonly By firstName = By.Id("FirstName");
        public static readonly By lastName = By.Id("LastName");
        public static readonly By emailadress = By.Id("Email");
        public static readonly By password = By.Id("Password");
        public static readonly By confirmpassword = By.Id("ConfirmPassword");
        public static readonly By registerbutton = By.Id("register-button");

        public static readonly By result = By.ClassName("result");
        public static readonly By logout = By.ClassName("ico-logout");

        //page method
        //click on gender male radio button
        public void SelectMaleRadio ()
        {
            driver.Click(genderMale);
        }

        /// Nhap firstname
        public void EnterFirstName (String value)
        {
            driver.EnterText(firstName,value);  
        }
        /// Nhap lastname
        public void EnterLastName(String value)
        {
            driver.EnterText(lastName,value);
        }
        /// Nhap email
        public void EnterEmail(String value) 
        {
            driver.EnterText(emailadress,value);
        }
        /// Nhap password
        public void EnterPassword(String pass)
        {
            driver.EnterText(password,pass);
        }
        /// Nhap lai password 
        public void EnterConfirmPassword(String pass)
        {
            driver.EnterText(confirmpassword,pass);
        }
        /// Click nut register
        public void ClickRegisterbtn()
        {
            driver.Click(registerbutton);
        }

        public String GetSuccessfullMessage()
        {
            return driver.getText(result);
        }

        public bool IsEmailAccountDisplayed(String email)
        {
            return driver.getTextWithValueDisplayed(email);
        }

        public void clickLogout()
        {
            driver.Click(logout);
        }
    }
}
