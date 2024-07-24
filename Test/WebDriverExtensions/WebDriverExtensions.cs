using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.WebDriverExtensions
{
    public static class WebDriverExtensions
    {
        //Cac phuong thuc co the su dung lai cho trang
        //Nhap hoac sua vao text box
       
        public static void EnterText(this IWebDriver driver ,By locator, string value)
        {
            IWebElement ele= driver.FindElement(locator);   
            if(ele.Displayed && ele.Enabled)
            {
                ele.Clear();
                ele.SendKeys(value);
            }
        }
        //Click vao button, radio button, checkbox
        public static void Click(this IWebDriver driver ,By locator)
        {
            IWebElement ele = driver.FindElement(locator);
            if (ele.Displayed && ele.Enabled)
            {
                ele.Click();
            }
        }

        public static bool IsElementDisplayed(this IWebDriver driver, By locator )
        {
            IWebElement ele= driver.FindElement(locator);
            if(ele.Displayed)
            {
                return true;
            }
            return true;
        }


        //lay text cua webelement
        public static string getText(this IWebDriver driver, By locator) 
        {
            IWebElement ele= driver.FindElement(locator);
            var text = "";
            if(ele.Displayed)
            {
                text = ele.Text;
            }
            return text;
        }

        //text duoc hien thi

        public static bool getTextWithValueDisplayed(this IWebDriver driver,string value)
        {
            var text = "";
            IWebElement ele = driver.FindElement(By.XPath("//*[text()='" + value + "']"));
            if(ele.Displayed)
            {
                return true;
            }
            return true;
        }

        public static void IsAlertPresent()
        {

        }

        public static void SelectByVisibleTextFromDropDown()
        {

        }
    }
}
