namespace AutomationTests.Pages.DroppablePage
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class DroppablePage : BasePage<DroppablePageMap>
    {
        public DroppablePage(IWebDriver driver) : base(driver, new DroppablePageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.DROPPABLE_URL;
            }
        }

        public void PerformDefaultDragAndDrop()
        {
            this.Open();
            this.Elements.DefaultTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DraggableView)
                   .ClickAndHold()
                   .MoveToElement(this.Elements.DroppableView)
                   .Release()
                   .Perform();
        }

        public void PerformAcceptDragAndDrop()
        {
            this.Open();
            this.Elements.AcceptTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DraggableNonVaid)
                   .ClickAndHold()
                   .MoveToElement(this.Elements.DroppableAccept)
                   .Release()
                   .Perform();
        }

        public void PerformPreventPropagationDragAndDrop()
        {
            this.Open();
            this.Elements.PreventPropagationTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DraggableProp)
                   .ClickAndHold()
                   .MoveToElement(this.Elements.InnerDroppableGreedy)
                   .Release()
                   .Perform();
        }

        public void PerformRevertDraggablePossition()
        {
            this.Open();
            this.Elements.RevertDraggablePossitionTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DraggableRevert)
                   .ClickAndHold()
                   .MoveToElement(this.Elements.DroppableRevert)
                   .Release()
                   .Perform();
        }

        public void PerformShoppingCartDemo()
        {
            this.Open();
            this.Elements.ShoppingCartTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.Product)
                   .ClickAndHold()
                   .MoveToElement(this.Elements.ShoppingCart)
                   .Release()
                   .Perform();
        }
    }
}
