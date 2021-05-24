﻿using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;


namespace SeleniumWebPageObject
{
    class LoginPage : AbstractPage
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement Name;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement Password;


        public HomePage enterlogin()
        {
            new Actions(driver).Click(Name).SendKeys("user").Build().Perform();
            new Actions(driver).Click(Password).SendKeys("user").SendKeys(Keys.Enter).Build().Perform();
            return new HomePage(driver);
        }
    }
}