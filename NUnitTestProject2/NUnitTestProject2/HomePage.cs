﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;


namespace SeleniumWebPageObject
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[contains(@href, '/Product')])[1]")]
        private IWebElement allproduct;
        
        [FindsBy(How = How.XPath, Using = "//a[@href='/Account/Logout']")]
        IWebElement logout;

        public AllProductsPage clickallproduct()
        {
            new Actions(driver).Click(allproduct).Build().Perform();
            return new AllProductsPage(driver);
        }

        public LoginPage LogOut()
        {
            new Actions(driver).Click(logout).Build().Perform();
            return new LoginPage(driver);
        }

    }
}