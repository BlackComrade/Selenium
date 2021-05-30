using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace SpecFlowProject1.Page
{
    class AllProductsPage : AbstractPage
    {
        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create new')]")]
        public IWebElement createnew;
        [FindsBy(How = How.XPath, Using = "//td[a[text()='newpr']]/ following-sibling::td [a[text()='Edit']]")]
        public IWebElement nwproduct;
        [FindsBy(How = How.XPath, Using = "//td[a[text()='newpr']]/ following-sibling::td [a[text()='Remove']]")]
        public IWebElement deleteproduct;
        [FindsBy(How = How.XPath, Using = "//h2[text()='All Products']")]
        public IWebElement nameallproduct;

        public CreateNewProduct create()
        {
            new Actions(driver).Click(createnew).Build().Perform();
            return new CreateNewProduct(driver);
        }
        public CreateNewProduct clickproduct()
        {
            new Actions(driver).Click(nwproduct).Build().Perform();
            return new CreateNewProduct(driver);
        }
        public AllProductsPage delete()
        {
            new Actions(driver).Click(deleteproduct).Build().Perform();
            return new AllProductsPage(driver);
        }

        public AllProductsPage checknameproduct()
        {
            Assert.AreEqual("All Products", nameallproduct.Text);
            return new AllProductsPage(driver);
        }
        public AllProductsPage checknamedeleteproduct()
        {
            Assert.IsFalse(driver.PageSource.Contains("newpr"));
            return new AllProductsPage(driver);
        }

    }
}
