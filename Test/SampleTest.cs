using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Test
{
    [TestClass]
    public class SampleTest
    {
        String email = "2151050057duy@ou.edu.vn";
        IWebDriver driver;
        [TestInitialize]
        public void Init() 
        {
            //Console.WriteLine("Chao mung den voi selenium"); //demowebshop.tricentis.com
            //Tao 1 instance cho webdriver
            driver = new ChromeDriver();

            //Dieu huong den trang web
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");

            //Toi uu hoa cua so trinh duyet 
            driver.Manage().Window.Maximize();
        }
        [TestCategory("SampleTest")]
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                //Console.WriteLine("Chao mung den voi selenium"); //demowebshop.tricentis.com
                //Tao 1 instance cho webdriver
                IWebDriver driver = new ChromeDriver();

                //Dieu huong den trang web
                driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");

                //Toi uu hoa cua so trinh duyet 
                driver.Manage().Window.Maximize();
                String title = driver.Title;
                Assert.AreEqual(title, "Demo Web Shop");

                //Click vao Register link
                driver.FindElement(By.ClassName("ico-register")).Click();
                String registerTitle = driver.Title;
                Assert.AreEqual(registerTitle, "Demo Web Shop. Register");

                //Chon Male Gender
                driver.FindElement(By.Id("gender-male")).Click();

                //Nhap Firstname
                driver.FindElement(By.Id("FirstName")).SendKeys("Hoang");

                //Nhap Lastname
                driver.FindElement(By.Id("LastName")).SendKeys("Duy");

                //Nhap Email
                driver.FindElement(By.Id("Email")).SendKeys(email);

                //Nhap Password
                driver.FindElement(By.Name("Password")).SendKeys("Duy322454");

                //Nhap lai Password
                driver.FindElement(By.Id("ConfirmPassword")).SendKeys("Duy322454");

                //Click vao nut Register
                driver.FindElement(By.Id("register-button")).Click();

                //Hien thi tin nhan thanh cong
                String message = driver.FindElement(By.ClassName("result")).Text;
                Assert.AreEqual(message, "Your registration completed");
                IWebElement emailAccount = driver.FindElement(By.XPath("//*[text()='" + email + "']"));
                Assert.IsTrue(emailAccount.Displayed);

                //Log out
                driver.FindElement(By.ClassName("ico-logout")).Click();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        [TestCleanup]
        public void CloseBrower()
        {
            driver.Close();
        }
        
    }
}
