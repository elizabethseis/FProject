using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProject
{
    class SearchProductPageObject
    {
        public SearchProductPageObject()
        {
            PageFactory.InitElements(FProject.SetUp.driver, this);

        }


        [FindsBy(How = How.XPath, Using = "//input[@id='twotabsearchtextbox']")]
        public IWebElement TxtSearch { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Ir']")]
        public IWebElement BtnSearch { get; set; }

        [FindsBy(How = How.ClassName, Using = "a-price-whole")]
        public IWebElement Price { get; set; }

        [FindsBy(How = How.ClassName, Using = "a-price-fraction")]
        public IWebElement PriceFraction { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Samsung Galaxy S9 64GB Desbloqueado Negro Medianoc')]")]
        public IWebElement ProductSelected { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@id='priceblock_ourprice']")]
        public IWebElement ActualPrice { get; set; }


        [FindsBy(How = How.XPath, Using = "//input[@id='add-to-cart-button']")]
        public IWebElement BtnAddtoCart { get; set; }


        [FindsBy(How = How.XPath, Using = "//div[@class='a-row a-size-base hlb-price a-color-price']")]
        public IWebElement PriceCart { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Alienware AW3418DW Monitor Gaming Curvo 34\", LED-L')]")]
        public IWebElement LinkDisplay { get; set; }

       
    }
}
