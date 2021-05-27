using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using NUnit.Framework;
using NUnitTestProject3.action;

namespace NUnitTestProject3.Page
{
    class CreateNewProduct : AbstractPage
    {
        public CreateNewProduct(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Id, Using = "ProductName")]
        public IWebElement name;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        public IWebElement category;
        [FindsBy(How = How.Id, Using = "SupplierId")]
        public IWebElement supplier;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        public IWebElement unitprice;
        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        public IWebElement quantityperunit;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        public IWebElement unitsinstock;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        public IWebElement unitsonorder;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        public IWebElement reorderlevel;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement ready;



        public CreateNewProduct createproduct()
        {
            Create.NewProduct(name, category, supplier, unitprice, quantityperunit, unitsinstock, unitsonorder, reorderlevel);
            ready.Click();
            return new CreateNewProduct(driver);
        }

       public CreateNewProduct cheackproduct()
        {
            Check.ckproduct(name, category, supplier, unitprice, quantityperunit, unitsinstock, unitsonorder, reorderlevel);
            return new CreateNewProduct(driver);
        }
    }
}
