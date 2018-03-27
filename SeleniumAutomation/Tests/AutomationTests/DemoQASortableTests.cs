namespace AutomationTests
{
    using System.Configuration;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using AutomationTests.Extensions;
    using AutomationTests.Pages.SortablePage;

    [TestFixture]
    public class DemoQASortableTests
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
        public void SortingListItemsShouldProccessCorrectly()
        {
            //// Arrange
            var sortablePage = new SortablePage(this.driver);

            //// Act
            sortablePage.PerformSortingList();

            //// Assert
            sortablePage.AssertSortingList();
        }

        [Test]
        public void SortingConnectedListsShouldProccessCorrectly()
        {
            //// Arrange
            var sortablePage = new SortablePage(this.driver);

            //// Act
            sortablePage.PerformSortingConnectedLists();

            //// Assert
            sortablePage.AssertSortingConnectedLists();
        }

        [Test]
        public void SortingGridItemsShouldProccessCorrectly()
        {
            //// Arrange
            var sortablePage = new SortablePage(this.driver);

            //// Act
            sortablePage.PerformSortingGrid();

            //// Assert
            sortablePage.AssertSortingGrid();
        }
    }
}