using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject
{
    class CartPageObject
    {
        public CartPageObject()
        {
            PageFactory.InitElements(FProject.SetUp.driver, this);

        }

        [FindsBy(How = How.XPath, Using = "//div[@id='hlb-cart-itemcount-text']")]
        public IWebElement AmountProducts { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@id='a-autoid-0-announce']")]
        public IWebElement BtnCarrito { get; set; }
    }
}
