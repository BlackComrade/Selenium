using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace NUnitTestProject1
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/Account/Login?ReturnUrl=%2F");
        }

        public void login()
        {
            IWebElement log = driver.FindElement(By.XPath("//input [@id ='Name' ]"));
            IWebElement pas = driver.FindElement(By.XPath("//input [@id ='Password' ]"));
            IWebElement btn = driver.FindElement(By.XPath("//input [@type = 'submit' ]"));

            log.SendKeys("user");
            pas.SendKeys("user");
            btn.Click();
        }

        [Test]
        public void Test1_Login()
        {
            login();

            IWebElement allproduct = driver.FindElement(By.XPath("(//a [@href = '/Product'])[1]"));
            allproduct.Click();
            IWebElement nameproduct  = driver.FindElement(By.XPath("//h2[text()='All Products']"));
            Assert.AreEqual("All Products", nameproduct.Text);
        }

        [Test]
        public void Test2_CreateProduct()
        {
            login();

            IWebElement allproduct = driver.FindElement(By.XPath("(//a [@href = '/Product'])[1]"));
            allproduct.Click();
            IWebElement creatnew = driver.FindElement(By.XPath("//a [@class = 'btn btn-default']"));
            creatnew.Click();
           
            IWebElement name = driver.FindElement(By.XPath("//input [@id ='ProductName']"));           
            IWebElement category = driver.FindElement(By.XPath("//select[@id='CategoryId']"));            
            IWebElement supplier = driver.FindElement(By.XPath("//select[@id='SupplierId']"));           
            IWebElement unitprice = driver.FindElement(By.XPath("//input [@id ='UnitPrice']"));           
            IWebElement quantityperunit = driver.FindElement(By.XPath("//input [@id ='QuantityPerUnit']"));
            IWebElement unitsinstock = driver.FindElement(By.XPath("//input [@id ='UnitsInStock']"));
            IWebElement unitsonorder = driver.FindElement(By.XPath("//input [@id ='UnitsOnOrder']"));
            IWebElement reorderlevel = driver.FindElement(By.XPath("//input [@id ='ReorderLevel']"));
            IWebElement ready = driver.FindElement(By.XPath("//input [@class = 'btn btn-default']"));
            

            name.SendKeys("newpr");
            category.SendKeys("Beverages");
            supplier.SendKeys("Exotic Liquids");
            unitprice.SendKeys("1");
            quantityperunit.SendKeys("2");
            unitsinstock.SendKeys("3");
            unitsonorder.SendKeys("4");
            reorderlevel.SendKeys("5");
            ready.Click();

            IWebElement nameproduct = driver.FindElement(By.XPath("//h2[text()='All Products']"));
            Assert.AreEqual("All Products", nameproduct.Text);
        }

        [Test]
        public void Test3_CheckProduct()
        {
            login();

            IWebElement allproduct = driver.FindElement(By.XPath("(//a [@href = '/Product'])[1]"));
            allproduct.Click();
            IWebElement nameproduct = driver.FindElement(By.XPath("//td[a[text()='newpr']]/ following-sibling::td [a[text()='Edit']]"));
            nameproduct.Click();
           
            IWebElement name = driver.FindElement(By.XPath("//input [@id ='ProductName']"));           
            IWebElement category = driver.FindElement(By.XPath("//select[@id='CategoryId']"));            
            IWebElement supplier = driver.FindElement(By.XPath("//select[@id='SupplierId']"));           
            IWebElement unitprice = driver.FindElement(By.XPath("//input [@id ='UnitPrice']"));           
            IWebElement quantityperunit = driver.FindElement(By.XPath("//input [@id ='QuantityPerUnit']"));           
            IWebElement unitsinstock = driver.FindElement(By.XPath("//input [@id ='UnitsInStock']"));          
            IWebElement unitsonorder = driver.FindElement(By.XPath("//input [@id ='UnitsOnOrder']"));        
            IWebElement reorderlevel = driver.FindElement(By.XPath("//input [@id ='ReorderLevel']"));

            Assert.AreEqual("newpr", name.GetAttribute("value"));
            Assert.IsTrue(category.Text.Contains("Beverages"));
            Assert.IsTrue(supplier.Text.Contains("Exotic Liquids"));
            Assert.AreEqual("1,0000", unitprice.GetAttribute("value"));
            Assert.AreEqual("2", quantityperunit.GetAttribute("value"));
            Assert.AreEqual("3", unitsinstock.GetAttribute("value"));
            Assert.AreEqual("4", unitsonorder.GetAttribute("value"));
            Assert.AreEqual("5", reorderlevel.GetAttribute("value"));

        }

        [Test]
        public void Test4_DeleteProduct()
        {
            login();

            IWebElement logout = driver.FindElement(By.XPath("//a [@href='/Account/Logout']"));
            logout.Click();
            
            IWebElement allproduct = driver.FindElement(By.XPath("(//a [@href = '/Product'])[1]"));
            allproduct.Click();
            IWebElement nameproduct = driver.FindElement(By.XPath("//h2[text()='All Products']"));
            Assert.AreEqual("All Products", nameproduct.Text);

        }
        
        [Test]   
        public void Test5_Logout()
        {
            login();

            IWebElement allproduct = driver.FindElement(By.XPath("(//a [@href = '/Product'])[1]"));
            allproduct.Click();
            IWebElement nameproduct = driver.FindElement(By.XPath("//td[a[text()='newpr']]/ following-sibling::td [a[text()='Remove']]"));
            nameproduct.Click();
            driver.SwitchTo().Alert().Accept();
            Assert.IsFalse(driver.PageSource.Contains("newpr"));

        }


        [TearDown]

        public void TearDown()
        {
            driver.Quit();
        }
    }
}
