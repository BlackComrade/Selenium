using OpenQA.Selenium;
using SpecFlowProject1.info;

namespace SpecFlowProject1.action
{
    class Create
    {
        public static void NewProduct(IWebElement name,
                                            IWebElement category,
                                            IWebElement supplier,
                                            IWebElement unitprice,
                                            IWebElement quantityperunit,
                                            IWebElement unitsinstock,
                                            IWebElement unitsonorder,
                                            IWebElement reorderlevel)
        {
            infoProduct product = new infoProduct();

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
