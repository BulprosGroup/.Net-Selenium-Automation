namespace AutomationTests.Pages.DraggablePage
{
    using NUnit.Framework;

    public static class DraggablePageAsserter
    {
        public static void AssertDefaultDragIsPerformed(this DraggablePage page, int offsetX, int offsetY)
        {
            Assert.IsTrue(page.Elements.DefaultDragElement.GetAttribute("style").Contains($"left: {offsetX}px"));
            Assert.IsTrue(page.Elements.DefaultDragElement.GetAttribute("style").Contains($"top: {offsetY}px"));
        }

        public static void AssertConstraintMovementDrag(this DraggablePage page, int offsetX, int offsetY)
        {
            Assert.IsTrue(page.Elements.ConstraintMovementElement.GetAttribute("style").Contains($"left: {offsetX}px"));
            Assert.IsTrue(page.Elements.ConstraintMovementElement.GetAttribute("style").Contains($"top: 0px"));
        }

        public static void AssertDragWithCursorChange(this DraggablePage page, int offsetX, int offsetY)
        {
            Assert.AreEqual("move", page.Elements.BodyElement.GetCssValue("cursor"));
        }

        public static void AssertEventsDrag(this DraggablePage page, int offsetX, int offsetY)
        {
            Assert.AreEqual("1", page.Elements.EventStartElement.Text);
            Assert.AreEqual("1", page.Elements.EventDragElement.Text);
            Assert.AreEqual("1", page.Elements.EventStopElement.Text);
        }

        public static void AssertDragAndSort(this DraggablePage page, int offsetX, int offsetY)
        {
            Assert.IsTrue(page.Elements.DragMeDownElement.Displayed);
            Assert.AreEqual("Drag me down", page.Elements.DragMeDownElement.Text);
        }
    }
}
