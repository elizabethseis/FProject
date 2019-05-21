using FProject;
using System;
using TechTalk.SpecFlow;

namespace EProject
{
    [Binding]
    public class AmazonTestSteps
    {
        string WholePrice;
        [Given(@"Launch Chrome")]
        public void GivenLaunchChrome()
        {
            FProject.SetUp.OpenBrowser();
        }
        
        [Given(@"Login into the amazon")]
        public void GivenLoginIntoTheAmazon()
        {
            LoginPageObject page = new LoginPageObject();
            page.LinkIdentificate.Click();
            page.TxtUser.SendKeys(FProject.ReadConfigfile.name);
            page.TxtPassword.SendKeys(FProject.ReadConfigfile.password);
            page.BtnLogin.Click();
        }
        
        [Given(@"Search the first product")]
        public void GivenSearchTheFirstProduct()
        {
            SearchProductPageObject page = new SearchProductPageObject();
            page.TxtSearch.SendKeys("Samsung Galaxy S9 64GB");
            page.BtnSearch.Click();
        }
        
        [Then(@"compare the prices")]
        public void ThenCompareThePrices()
        {
            SearchProductPageObject page = new SearchProductPageObject();
            string PriceSelected = page.Price.Text;
            Console.WriteLine("Price Selected: " + PriceSelected);
            string WholeP = page.PriceFraction.Text;
            Console.WriteLine("Price Fraction: " + WholeP);
            WholePrice = "$" + PriceSelected + "." + WholeP;
            Console.WriteLine("Price Selected: " + WholePrice);
            page.ProductSelected.Click();
            string ActualPriceS = page.ActualPrice.Text;
            Console.WriteLine("Detail Price: " + ActualPriceS);
            SetUp.VAsserts(WholePrice, ActualPriceS);
            page.BtnAddtoCart.Click();
            String PriceCart1 = page.PriceCart.Text;
            Console.WriteLine("Price into the Cart: " + PriceCart1);
            SetUp.VAsserts(WholePrice, PriceCart1);
        }
        
        [Then(@"add to the cart the first product")]
        public void ThenAddToTheCartTheFirstProduct()
        {
            CartPageObject page = new CartPageObject();
            string AmountProduct = page.AmountProducts.Text;
            Console.WriteLine("Amount of products into the Cart: " + AmountProduct);
            string ExpectedText = "1 producto en tu carrito";
            SetUp.VAsserts(AmountProduct, ExpectedText);
        }
        
        [Then(@"search the second product")]
        public void ThenSearchTheSecondProduct()
        {
            SearchProductPageObject page = new SearchProductPageObject();
            page.TxtSearch.SendKeys("Alienware Aw3418DW");
            page.BtnSearch.Click();
        }
        
        [Then(@"add to the cart the second product")]
        public void ThenAddToTheCartTheSecondProduct()
        {
            SearchProductPageObject page1 = new SearchProductPageObject();
            page1.LinkDisplay.Click();
            page1.BtnAddtoCart.Click();
        }
        
        [Then(@"validate the amount of products")]
        public void ThenValidateTheAmountOfProducts()
        {
            CartPageObject page2 = new CartPageObject();
            string AmountProduct = page2.AmountProducts.Text;
            Console.WriteLine("Amount of products into the Cart: " + AmountProduct);
            string ExpectedText = "2 productos en tu carrito";
            SetUp.VAsserts(AmountProduct, ExpectedText);
            page2.BtnCarrito.Click();
        }
        
        [Then(@"clean the cart and close the browser")]
        public void ThenCleanTheCartAndCloseTheBrowser()
        {
            CleanCartPageObject page = new CleanCartPageObject();
            page.DeleteDisplay.Click();
            page.BtnCarrito.Click();
            page.DeletePhone.Click();
            FProject.SetUp.driver.Close();
        }
    }
}
