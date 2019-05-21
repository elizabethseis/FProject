using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using FProject;

namespace EProject
{
    public class LoginPageObject
    {
        public LoginPageObject()
        {
            PageFactory.InitElements(FProject.SetUp.driver, this);
            
        }
        [FindsBy(How= How.XPath, Using = "//span[contains(text(),'Hola, Identifícate')]")]
        public IWebElement LinkIdentificate { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='ap_email']")]
        public IWebElement TxtUser { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='ap_password']")]
        public IWebElement TxtPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='signInSubmit']")]
        public IWebElement BtnLogin { get; set; }

    }
}
