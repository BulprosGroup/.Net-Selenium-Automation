namespace AutomationTests.Pages.SortablePage
{
    using System;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class SortablePage : BasePage<SortablePageMap>
    {
        public SortablePage(IWebDriver driver) : base(driver, new SortablePageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.SORTABLE_URL;
            }
        }

        public void PerformSortingList()
        {
            this.Open();
            this.Elements.DefaultTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.SorableList.Last())
                   .ClickAndHold()
                   .MoveToElement(this.Elements.SorableList.First())
                   .Release()
                   .Perform();
        }

        public void PerformSortingConnectedLists()
        {
            this.Open();
            this.Elements.ConnectListsTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.ConnectListOne.First())
                   .ClickAndHold()
                   .MoveToElement(this.Elements.ConnectListTwo.First())
                   .Release()
                   .Perform();
        }

        internal void PerformSortingGrid()
        {
            this.Open();
            this.Elements.DisplayAsGridTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.SorableGrid.Last())
                   .ClickAndHold()
                   .MoveToElement(this.Elements.SorableGrid.First())
                   .Release()
                   .Perform();
        }
    }
}
