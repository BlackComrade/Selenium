using NUnit.Framework;
using NUnitTestProject3.Page;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnitTestProject3.action;

namespace NUnitTestProject3.test
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            //driver.Manage().Window.Maximize();

        }

        [Test]
        public void Test1_Login()
        {
            LoginPage login = new LoginPage(driver);
            HomePage enterlogin = login.enterlogin();
            AllProductsPage click = enterlogin.clickallproduct();
            AllProductsPage check = click.checknameproduct();
        }

        [Test]
        public void Test2_CreateProduct()
        {
            LoginPage login = new LoginPage(driver);
            HomePage enterlogin = login.enterlogin();
            AllProductsPage click = enterlogin.clickallproduct();
            CreateNewProduct createNew = click.create();
            CreateNewProduct create = createNew.createproduct();
        }



        [Test]
        public void Test3_CheckProduct()
        {
            LoginPage login = new LoginPage(driver);
            HomePage enterlogin = login.enterlogin();
            AllProductsPage click = enterlogin.clickallproduct();
            CreateNewProduct clickproduct = click.clickproduct();
            CreateNewProduct checkproduct = clickproduct.cheackproduct();
        }



        [Test]
        public void Test4_DeleteProduct()
        {
            LoginPage login = new LoginPage(driver);
            HomePage enterlogin = login.enterlogin();
            AllProductsPage click = enterlogin.clickallproduct();
            AllProductsPage deleteproduct = click.delete();
            driver.SwitchTo().Alert().Accept();
            AllProductsPage checkdelete = deleteproduct.checknamedeleteproduct();
        }


        [Test]
        public void Test5_Logout()
        {
            LoginPage login = new LoginPage(driver);
            HomePage enterlogin = login.enterlogin();
            LoginPage logout = enterlogin.LogOut();
            AllProductsPage click = enterlogin.clickallproduct();
            AllProductsPage check = click.checknameproduct();
        }

        [TearDown]

        public void tearDown()
        {
            driver.Quit();
        }
    }

}

