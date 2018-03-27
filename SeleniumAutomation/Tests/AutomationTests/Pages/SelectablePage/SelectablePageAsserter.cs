namespace AutomationTests.Pages.SelectablePage
{
    using System.Collections.Generic;
    using NUnit.Framework;

    public static class SelectablePageAsserter
    {
        public static void AssertSelectingFromList(this SelectablePage page, IList<int> selects)
        {
            for (int i = 0; i < page.Elements.SelectableList.Count; i++)
            {
                if (selects.Contains(i + 1))
                {
                    Assert.IsTrue(page.Elements.SelectableList[i].GetAttribute("class").Contains("ui-selected"));
                }
                else
                {
                    Assert.IsFalse(page.Elements.SelectableList[i].GetAttribute("class").Contains("ui-selected"));
                }
            }
        }

        public static void AssertSelectingFromGrid(this SelectablePage page, IList<int> selects)
        {
            for (int i = 0; i < page.Elements.SelectableGrid.Count; i++)
            {
                if (selects.Contains(i + 1))
                {
                    Assert.IsTrue(page.Elements.SelectableGrid[i].GetAttribute("class").Contains("ui-selected"));
                }
                else
                {
                    Assert.IsFalse(page.Elements.SelectableGrid[i].GetAttribute("class").Contains("ui-selected"));
                }
            }
        }

        public static void AssertSelectingFromSerializeList(this SelectablePage page, IList<int> selects)
        {
            for (int i = 0; i < page.Elements.SerializeList.Count; i++)
            {
                if (selects.Contains(i + 1))
                {
                    Assert.IsTrue(page.Elements.SerializeList[i].GetAttribute("class").Contains("ui-selected"));
                    Assert.IsTrue(page.Elements.SerializeResult.Text.Contains((i + 1).ToString()));
                }
                else
                {
                    Assert.IsFalse(page.Elements.SerializeList[i].GetAttribute("class").Contains("ui-selected"));
                    Assert.IsFalse(page.Elements.SerializeResult.Text.Contains((i + 1).ToString()));
                }
            }
        }
    }
}
