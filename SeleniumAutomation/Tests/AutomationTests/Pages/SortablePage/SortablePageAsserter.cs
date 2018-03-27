namespace AutomationTests.Pages.SortablePage
{
    using System.Linq;
    using NUnit.Framework;

    public static class SortablePageAsserter
    {
        public static void AssertSortingList(this SortablePage page)
        {
            Assert.AreEqual(Constants.EXPECTED_FIRST_LIST_ITEM, page.Elements.SorableList.First().Text);
        }

        public static void AssertSortingConnectedLists(this SortablePage page)
        {
            Assert.IsTrue(page.Elements.ConnectListTwo.Skip(1).First().GetAttribute("class").Contains("ui-state-default"));
        }

        public static void AssertSortingGrid(this SortablePage page)
        {
            Assert.AreEqual(Constants.EXPECTED_FIRST_GRID_ITEM, page.Elements.SorableGrid.First().Text);
        }
    }
}
