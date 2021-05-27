using NUnitTestProject3.info;
using NUnitTestProject3.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace NUnitTestProject3.action
{
    class Create : AbstractPage
    {
        public Create(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        
        }
        public static void NewProduct(IWebElement name, 
                                            IWebElement category, 
                                            IWebElement supplier, 
                                            IWebElement unitprice, 
                                            IWebElement quantityperunit, 
                                            IWebElement unitsinstock, 
                                            IWebElement unitsonorder, 
                                            IWebElement reorderlevel)
        {
            InfoProduct product = new InfoProduct();

            name.SendKeys(product.name);
            category.SendKeys(product.category);
            supplier.SendKeys(product.supplier);
            unitprice.SendKeys(product.unitprice);
            quantityperunit.SendKeys(product.quantityperunit);
            unitsinstock.SendKeys(product.unitsinstock);
            unitsonorder.SendKeys(product.unitsonorder);
            reorderlevel.SendKeys(product.reorderlevel);

        }
    }

}
