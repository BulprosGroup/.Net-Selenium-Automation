namespace AutomationTests
{
    using System.Configuration;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using AutomationTests.Extensions;
    using AutomationTests.Pages.DroppablePage;

    [TestFixture]
    public class DemoQADroppableTests
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
        public void DragAndDropItemShouldProcessedCorrectly()
        {
            //// Arrange 
            var droppablePage = new DroppablePage(this.driver);

            //// Act
            droppablePage.PerformDefaultDragAndDrop();

            //// Assert
            droppablePage.AssertDefaultDragAndDrop();
        }

        [Test]
        public void DragAndDropWithAcceptShouldProcessedCorrectly()
        {
            //// Arrange 
            var droppablePage = new DroppablePage(this.driver);

            //// Act
            droppablePage.PerformAcceptDragAndDrop();

            //// Assert
            droppablePage.AssertAcceptDragAndDrop();
        }

        [Test]
        public void DragAndDropWithPreventPropagationShouldProcessedCorrectly()
        {
            //// Arrange 
            var droppablePage = new DroppablePage(this.driver);

            //// Act
            droppablePage.PerformPreventPropagationDragAndDrop();

            //// Assert
            droppablePage.AssertPreventPropagationDragAndDrop();
        }

        [Test]
        public void DragAndDropWithRevertDraggablePossitionShouldProcessedCorrectly()
        {
            //// Arrange 
            var droppablePage = new DroppablePage(this.driver);

            //// Act
            droppablePage.PerformRevertDraggablePossition();

            //// Assert
            droppablePage.AssertRevertDraggablePossition();
        }

        [Test]
        public void DragAndDropForShoppingCartDemoShouldProcessedCorrectly()
        {
            //// Arrange 
            var droppablePage = new DroppablePage(this.driver);

            //// Act
            droppablePage.PerformShoppingCartDemo();

            //// Assert
            droppablePage.AssertShoppingCartDemo();
        }
    }
}