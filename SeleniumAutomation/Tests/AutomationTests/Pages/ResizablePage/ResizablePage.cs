namespace AutomationTests.Pages.ResizablePage
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Interactions;

    public class ResizablePage : BasePage<ResizablePageMap>
    {
        public ResizablePage(IWebDriver driver) : base(driver, new ResizablePageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.RESIZABLE_URL;
            }
        }

        public void PerformDefaultResize(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.DefaultTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.DefaultResizeAngle)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Release()
                   .Perform();
        }

        public void PerformConstraintResize(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.ConstraintResizeTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.ConstraintResizeAngle)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Release()
                   .Perform();
        }

        public void PerformMinConstraintResize(int offsetX, int offsetY)
        {
            this.Open();
            this.Elements.MinMaxSizeTab.Click();
            var builder = new Actions(this.Driver);
            builder.MoveToElement(this.Elements.MinMaxResizeAngle)
                   .ClickAndHold()
                   .MoveByOffset(offsetX, offsetY)
                   .Release()
                   .Perform();
        }
    }
}
