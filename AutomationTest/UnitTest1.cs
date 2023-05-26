using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using Xunit.Abstractions;

namespace AutomationTest
{
    public class AutomationTest1 : IClassFixture<WebDriverConfig>
    {
        private readonly WebDriverConfig webDriverConfig;
        private readonly ITestOutputHelper testOutputHelper;

        public AutomationTest1(WebDriverConfig webDriverConfig, ITestOutputHelper testOutputHelper)
        {
            this.webDriverConfig = webDriverConfig;
            this.testOutputHelper = testOutputHelper;

        }

        [Fact] //1st test ExecuteTest
        public void Test1()
        {
           var driver = webDriverConfig.ChromeDriver;
            //Declare first test
            testOutputHelper.WriteLine("First Test");
            //Navigate to URL
            driver.Navigate().GoToUrl("https://www.google.com/");
            //Maximize Browswer
            driver.Manage().Window.Maximize();
            //Find Element and define webelement search field
            WebElement search = (WebElement)driver.FindElement(By.Name("q"));
            //Perform operation
            search.SendKeys("selenium training");
            //Declare test is complete
            testOutputHelper.WriteLine("Test complete");

        }
    
    }
}


