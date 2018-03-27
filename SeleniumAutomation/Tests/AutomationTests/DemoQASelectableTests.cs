namespace AutomationTests
{
    using System.Collections.Generic;
    using System.Configuration;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using AutomationTests.Extensions;
    using AutomationTests.Pages.SelectablePage;

    [TestFixture]
    public class DemoQASelectableTests
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            var options = new ChromeOptions();
            options.AddExtension(ConfigurationManager.AppSettings["extAdblockChrome"].ToAbsolutePath());
            this.driver = new ChromeDriver(options);
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEachTest()
        {
            this.driver.Log().Quit();
        }

        [Test]
        public void SelectingItemsFromListShouldProccessCorrectly()
        {
            //// Arrange
            var selecablePage = new SelectablePage(this.driver);
            var selects = new List<int>() { 2, 4, 6 };

            //// Act
            selecablePage.PerformSelectingFromList(selects);

            //// Assert
            selecablePage.AssertSelectingFromList(selects);
        }

        [Test]
        public void SelectingItemsFromGridShouldProccessCorrectly()
        {
            //// Arrange
            var selecablePage = new SelectablePage(this.driver);
            var selects = new List<int>() { 1, 3, 6, 8, 9, 11 };

            //// Act
            selecablePage.PerformSelectingFromGrid(selects);

            //// Assert
            selecablePage.AssertSelectingFromGrid(selects);
        }

        [Test]
        public void SelectingItemsFromSerializeListShouldProccessCorrectly()
        {
            //// Arrange
            var selecablePage = new SelectablePage(this.driver);
            var selects = new List<int>() { 1, 3, 5 };

            //// Act
            selecablePage.PerformSelectingFromSerializeList(selects);

            //// Assert
            selecablePage.AssertSelectingFromSerializeList(selects);
        }
    }
}