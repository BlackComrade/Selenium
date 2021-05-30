using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SpecFlowProject1.Page;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    [Binding]
    public class AddingAProductSteps
    {
        private IWebDriver driver;


        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }
        
        [Given(@"I login")]
        public void GivenILogin()
        {
            LoginPage login = new LoginPage(driver);
            HomePage enterlogin = login.enterlogin();
        }
        
        [Given(@"I click on button All Product")]
        public void GivenIClickOnButtonAllProduct()
        {
            new HomePage(driver).clickallproduct();
        }
        
        [Given(@"I click on button Create New")]
        public void GivenIClickOnButtonCreateNew()
        {
            new AllProductsPage(driver).create();
        }
        
        [Given(@"I enter info of product and create it")]
        public void GivenIEnterInfoOfProductAndCreateIt()
        {
            new CreateNewProduct(driver).createproduct();
        }
        
        [When(@"I click on button Edit of the created product")]
        public void WhenIClickOnButtonEditOfTheCreatedProduct()
        {
            new AllProductsPage(driver).clickproduct();
        }
        
        [Then(@"Check info new product and end test")]
        public void ThenCheckInfoNewProductAndEndTest()
        {
            new CreateNewProduct(driver).cheackproduct();
        }

        [AfterScenario]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
