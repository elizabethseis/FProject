using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FProject
{
    
    public class SetUp
    {
        public static IWebDriver driver;
       
        public static void OpenBrowser()
        {
            ReadConfigfile.ReadFile();
            Console.WriteLine("URL : " + ReadConfigfile.url);
            Console.WriteLine("Name : " + ReadConfigfile.name);
            Console.WriteLine("Pasword : " + ReadConfigfile.password);
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(ReadConfigfile.url);
        }

        public static void WaitForElement(By Locator, int seconds)
        {
            try
            {
                new WebDriverWait(driver, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementIsVisible(Locator));
            }
            catch (Exception i)
            {
                Console.WriteLine("Element is not displayed");
            }
        }

        public static void Click(string element)
        {
            driver.FindElement(By.Id(element)).Click();
        }

        public static void VAsserts(string element1, string element2)
        {

            try
            {
                Assert.AreEqual(element1, element2);
                Console.WriteLine("Assert is correct");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
       

    }
}
