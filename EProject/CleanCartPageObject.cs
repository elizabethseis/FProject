using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject
{
    class CleanCartPageObject
    {
        public CleanCartPageObject()
        {
            PageFactory.InitElements(FProject.SetUp.driver, this);

        }


        [FindsBy(How = How.XPath, Using = "//div[@class='a-column a-span8']//input[@value='Eliminar']")]
        public IWebElement DeleteDisplay { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Carrito')]")]
        public IWebElement BtnCarrito { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='a-column a-span8']//input[@value='Eliminar']")]
        public IWebElement DeletePhone { get; set; }
    }
}
