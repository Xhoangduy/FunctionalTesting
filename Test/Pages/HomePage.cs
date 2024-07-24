using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.WebDriverExtensions;

namespace Test.Pages
{
    public class HomePage
    {   //Instance cua Webdriver
        public static IWebDriver driver;
        //Tao mot contructorr
        public HomePage(IWebDriver driver)
        {
            HomePage.driver = driver;
        }

        public String getTitle()
        {
            return driver.Title;
        }

        //Page Objects - for webelements
       public static readonly By registerLink = By.ClassName("ico-register");
       public static readonly By loginLink = By.ClassName("ico-login");

        //Page method
        public void ClickRegisterLink()
        {
            driver.Click(registerLink);
        }

        public void ClickLoginLink() 
        { 
            driver.Click(loginLink);
        }
    }
}
 