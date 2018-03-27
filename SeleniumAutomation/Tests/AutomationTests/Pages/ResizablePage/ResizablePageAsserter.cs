namespace AutomationTests.Pages.ResizablePage
{
    using NUnit.Framework;

    public static class ResizablePageAsserter
    {
        public static void AssertDefaultResize(this ResizablePage page, int offsetX, int offsetY)
        {
            decimal defaultSize = 132.6m;
            Assert.IsTrue(page.Elements.DefaultResizableBox.GetAttribute("style").Contains($"width: {defaultSize + offsetX}px"));
            Assert.IsTrue(page.Elements.DefaultResizableBox.GetAttribute("style").Contains($"height: {defaultSize + offsetY}px"));
        }

        public static void AssertConstraintResize(this ResizablePage page)
        {
            int maxWidth = 180;
            int maxHeight = 137;
            Assert.IsTrue(page.Elements.ConstraintResizableBox.GetAttribute("style").Contains($"width: {maxWidth}"));
            Assert.IsTrue(page.Elements.ConstraintResizableBox.GetAttribute("style").Contains($"height: {maxHeight}"));
        }

        public static void AssertMinConstraintResize(this ResizablePage page)
        {
            decimal minWidth = 200m;
            decimal minHeight = 150m;
            Assert.IsTrue(page.Elements.MinMaxResizableBox.GetAttribute("style").Contains($"width: {minWidth}px"));
            Assert.IsTrue(page.Elements.MinMaxResizableBox.GetAttribute("style").Contains($"height: {minHeight}px"));
        }
    }
}
