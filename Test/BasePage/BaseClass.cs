using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Test.BasePage
{
    //Cai dat driver
    //Tai su dung cac phuong thuc
    public class BaseClass
    {
       public static IWebDriver driver;
        [TestInitialize]
        public void Init()
        {
            //Console.WriteLine("Chao mung den voi selenium"); //demowebshop.tricentis.com

            string siteurl = ConfigurationManager.AppSettings["Url"]; //"Url" = https://demowebshop.tricentis.com/register            //Tao 1 instance cho webdriver
            driver = new ChromeDriver();

            //Dieu huong den trang web
            driver.Navigate().GoToUrl(siteurl);

            //Toi uu hoa cua so trinh duyet 
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup() 
        {
            driver.Close();
        }
    }
}
