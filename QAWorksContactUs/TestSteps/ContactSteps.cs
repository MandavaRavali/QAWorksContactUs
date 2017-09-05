using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;


namespace QAWorksContactUs.TestSteps
{
    [Binding]
    public class ContactSteps
    {

        public IWebDriver driver = new FirefoxDriver();

        [Given(@"I am on the Qaworks site")]
        public void GivenIAmOnTheQaworksSite()
        {
            driver.Url = "http://www.qaworks.com/aboutus.aspx";
            Wait(driver, 10);
            
        }

        [When(@"I navigate to Contact page")]
        public void WhenINavigateToContactPage()
        {
            driver.FindElement(By.LinkText("Contact")).Click();
        }


        [Then(@"I should be able to contact qaworks with the following info")]
        public void ThenIShouldBeAbleToContactQaworksWithTheFollowingInfo(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            driver.FindElement(By.Id("ctl00_MainContent_NameBox")).SendKeys(data.name);
            driver.FindElement(By.Id("ctl00_MainContent_MessageBox")).SendKeys(data.message);
            driver.FindElement(By.Id("ctl00_MainContent_EmailBox")).SendKeys(data.email);
            driver.FindElement(By.Id("ctl00_MainContent_SendButton")).Click();
            Wait(driver,5);
            driver.Close();
        }

        public static void Wait(IWebDriver driver, int sec)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(sec);
        }
    }
}
