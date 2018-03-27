namespace AutomationTests.Pages.DraggablePage
{
    using AutomationTests.Extensions;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class DraggablePage : BasePage<DraggablePageMap>
    {
        public DraggablePage(IWebDriver driver) : base(driver, new DraggablePageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.DRAGGABLE_URL;
            }
        }

        public void PerformDefaultDrag(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.DefaultTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DefaultDragElement)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Release()
                   .Perform();
        }

        public void PerformConstraintMovementDrag(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.ContrainMovementTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.ConstraintMovementElement)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Release()
                   .Perform();
        }

        public void PerformDragWithCursorChange(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.CursorStyleTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.CursorStyleElement)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Perform();
        }

        public void PerformEventsDrag(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.EventsTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DragEventElement)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Release()
                   .Perform();
        }

        public void PerformDragAndSort(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.DraggableAndSortableTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DraggableBoxElement)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Release()
                   .Perform();
        }
    }
}
