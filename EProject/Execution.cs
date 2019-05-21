using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FProject;
using OpenQA.Selenium;

namespace EProject
{
    [TestClass]
    public class Execution
    {
        string WholePrice;
        [AssemblyInitialize]
        public static void TestOpenBrowser(TestContext tc)
        {
            FProject.SetUp.OpenBrowser();
        }

        [TestMethod]
        public void Test1()
        {
            LoginPageObject page = new LoginPageObject();
            page.LinkIdentificate.Click();
            page.TxtUser.SendKeys(FProject.ReadConfigfile.name);
            page.TxtPassword.SendKeys(FProject.ReadConfigfile.password);
            page.BtnLogin.Click();

        }


        [TestMethod]
        public void Test3()
        {
            SearchProduct("Samsung Galaxy S9 64GB");
            SearchProductPageObject page3 = new SearchProductPageObject();
            string PriceSelected = page3.Price.Text;
            Console.WriteLine("Price Selected: " + PriceSelected);
            string WholeP = page3.PriceFraction.Text;
            Console.WriteLine("Price Fraction: " + WholeP);
            WholePrice = "$" + PriceSelected + "." + WholeP;
            Console.WriteLine("Price Selected: " + WholePrice);
            page3.ProductSelected.Click();
            string ActualPriceS = page3.ActualPrice.Text;
            Console.WriteLine("Detail Price: " + ActualPriceS);
            SetUp.VAsserts(WholePrice, ActualPriceS);
            page3.BtnAddtoCart.Click();
            String PriceCart1 = page3.PriceCart.Text;
            Console.WriteLine("Price into the Cart: " + PriceCart1);
            SetUp.VAsserts(WholePrice, PriceCart1);
            CartPageObject page = new CartPageObject();
            string AmountProduct = page.AmountProducts.Text;
            Console.WriteLine("Amount of products into the Cart: " + AmountProduct);
            string ExpectedText = "1 producto en tu carrito";
            SetUp.VAsserts(AmountProduct, ExpectedText);
        }

        [TestMethod]
        public void Test5()
        {
            SearchProduct("Alienware Aw3418DW");

        }

        [TestMethod]
        public void Test6()
        {
            SearchProductPageObject page1 = new SearchProductPageObject();
            page1.LinkDisplay.Click();
            page1.BtnAddtoCart.Click();
            CartPageObject page2 = new CartPageObject();
            string AmountProduct = page2.AmountProducts.Text;
            Console.WriteLine("Amount of products into the Cart: " + AmountProduct);
            string ExpectedText = "2 productos en tu carrito";
            SetUp.VAsserts(AmountProduct, ExpectedText);
            page2.BtnCarrito.Click();
            CleanCartPageObject page = new CleanCartPageObject();
            page.DeleteDisplay.Click();
            page.BtnCarrito.Click();
            page.DeletePhone.Click();

        }


        [AssemblyCleanup]
        public static void CloseBrowser()
        {
            FProject.SetUp.driver.Close();
        }

        public void SearchProduct(string product)
        {
            SearchProductPageObject page = new SearchProductPageObject();
            page.TxtSearch.SendKeys(product);
            page.BtnSearch.Click();
        }

    }



}
