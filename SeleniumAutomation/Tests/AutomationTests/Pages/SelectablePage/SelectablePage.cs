namespace AutomationTests.Pages.SelectablePage
{
    using System;
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class SelectablePage : BasePage<SelectablePageMap>
    {
        public SelectablePage(IWebDriver driver) : base(driver, new SelectablePageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.SELECTABLE_URL;
            }
        }

        public void PerformSelectingFromList(IList<int> selects)
        {
            this.Open();
            this.PerformSelecting(selects, this.Elements.DefaultTab, this.Elements.SelectableList);
        }

        public void PerformSelectingFromGrid(IList<int> selects)
        {
            this.Open();
            this.PerformSelecting(selects, this.Elements.DisplayAsGridTab, this.Elements.SelectableGrid);
        }

        public void PerformSelectingFromSerializeList(IList<int> selects)
        {
            this.Open();
            this.PerformSelecting(selects, this.Elements.SerializeTab, this.Elements.SerializeList);
        }

        private void PerformSelecting(IList<int> selects, IWebElement tab, IList<IWebElement> list)
        {
            tab.Click();
            var builder = new Actions(this.Driver);
            builder.KeyDown(Keys.Control);

            for (int i = 0; i < list.Count; i++)
            {
                if (selects.Contains(i + 1))
                {
                    builder.MoveToElement(list[i]).Click();
                }
            }

            builder.KeyUp(Keys.Control).Perform();
        }
    }
}
