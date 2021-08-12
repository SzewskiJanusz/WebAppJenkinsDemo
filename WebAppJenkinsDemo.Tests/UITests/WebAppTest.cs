using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppJenkinsDemo.Tests.UITests
{
    [TestFixture]
    public class WebAppTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("no-sandbox");
            options.AddArgument("--allow-insecure-localhost");
            _driver = new ChromeDriver(options);
            _driver.Navigate().GoToUrl("http://localhost:44359/");
            _driver.Manage().Window.Minimize();
        }

        [Test]
        public void Can_GoToContact_CheckAddress()
        {
            _driver.FindElement(By.XPath("//a[contains(.,'Contact')]")).Click();

            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            wait.Until(x => x.FindElement(By.XPath("//address[contains(.,'Redmond, WA 98052-6399')]")));
        }
    }
}
