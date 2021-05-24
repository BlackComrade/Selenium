using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace SeleniumWebPageObject
{
    class CreateNewProduct : AbstractPage
    {
        public CreateNewProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Id, Using = "ProductName")]
        private IWebElement name;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        private IWebElement category;
        [FindsBy(How = How.Id, Using = "SupplierId")]
        private IWebElement supplier;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitprice;
        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        private IWebElement quantityperunit;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement unitsinstock;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement unitsonorder;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement reorderlevel;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement ready;



        public CreateNewProduct createproduct()
        {
            new Actions(driver).Click(name).SendKeys("newpr").Build().Perform();
            new Actions(driver).Click(category).SendKeys("Beverages").Build().Perform();
            new Actions(driver).Click(supplier).SendKeys("Karkki Oy").Build().Perform();
            new Actions(driver).Click(unitprice).SendKeys("1").Build().Perform();
            new Actions(driver).Click(quantityperunit).SendKeys("2").Build().Perform();
            new Actions(driver).Click(unitsinstock).SendKeys("3").Build().Perform();
            new Actions(driver).Click(unitsonorder).SendKeys("4").Build().Perform();
            new Actions(driver).Click(reorderlevel).SendKeys("5").Build().Perform();
            ready.Click();
            return new CreateNewProduct(driver);
        }

        public CreateNewProduct cheackproduct()
        {

            Assert.AreEqual("newpr", name.GetAttribute("value"));
            Assert.IsTrue(category.Text.Contains("Beverages"));
            Assert.IsTrue(supplier.Text.Contains("Karkki Oy"));
            Assert.AreEqual("1,0000", unitprice.GetAttribute("value"));
            Assert.AreEqual("2", quantityperunit.GetAttribute("value"));
            Assert.AreEqual("3", unitsinstock.GetAttribute("value"));
            Assert.AreEqual("4", unitsonorder.GetAttribute("value"));
            Assert.AreEqual("5", reorderlevel.GetAttribute("value"));
            return new CreateNewProduct(driver);
        }
    }
}