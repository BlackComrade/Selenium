using NUnit.Framework;
using NUnitTestProject3.Page;
using System;
using System.Collections.Generic;
using System.Text;
using NUnitTestProject3.info;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace NUnitTestProject3.action
{
    class Check 
    {
        public static void ckproduct(IWebElement name, 
                                            IWebElement category, 
                                            IWebElement supplier, 
                                            IWebElement unitprice, 
                                            IWebElement quantityperunit, 
                                            IWebElement unitsinstock, 
                                            IWebElement unitsonorder, 
                                            IWebElement reorderlevel)
         {

             Assert.AreEqual("newpr", name.GetAttribute("value"));
             Assert.IsTrue(category.Text.Contains("Beverages"));
             Assert.IsTrue(supplier.Text.Contains("Karkki Oy"));
             Assert.AreEqual("1,0000", unitprice.GetAttribute("value"));
             Assert.AreEqual("2", quantityperunit.GetAttribute("value"));
             Assert.AreEqual("3", unitsinstock.GetAttribute("value"));
             Assert.AreEqual("4", unitsonorder.GetAttribute("value"));
             Assert.AreEqual("5", reorderlevel.GetAttribute("value"));
         }

    }
}
