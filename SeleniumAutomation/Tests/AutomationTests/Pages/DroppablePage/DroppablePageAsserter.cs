namespace AutomationTests.Pages.DroppablePage
{
    using NUnit.Framework;

    public static class DroppablePageAsserter
    {
        public static void AssertDefaultDragAndDrop(this DroppablePage page)
        {
            Assert.AreEqual(Constants.DROPPED, page.Elements.DroppableView.Text);
        }

        public static void AssertAcceptDragAndDrop(this DroppablePage page)
        {
            Assert.AreNotEqual(Constants.DROPPED, page.Elements.DroppableAccept.Text);
        }

        public static void AssertPreventPropagationDragAndDrop(this DroppablePage page)
        {
            Assert.AreEqual(Constants.DROPPED, page.Elements.InnerDroppableGreedy.Text);
            Assert.AreNotEqual(Constants.DROPPED, page.Elements.OuterDroppable.Text);
        }

        public static void AssertRevertDraggablePossition(this DroppablePage page)
        {
            Assert.AreEqual(Constants.DROPPED, page.Elements.DroppableRevert.Text);
        }

        public static void AssertShoppingCartDemo(this DroppablePage page)
        {
            Assert.AreEqual(page.Elements.Product.Text, page.Elements.ShoppingCart.Text);
        }
    }
}
