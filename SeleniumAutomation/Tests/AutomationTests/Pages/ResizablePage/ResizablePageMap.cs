namespace AutomationTests.Pages.ResizablePage
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class ResizablePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public ResizablePageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }

        public IWebElement DefaultTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DEFAULT_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.DEFAULT_TAB_SELECTOR));
            }
        }

        public IWebElement ConstraintResizeTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.CONSTRAINT_RESIZE_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.CONSTRAINT_RESIZE_TAB_SELECTOR));
            }
        }

        public IWebElement MinMaxSizeTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.MIN_MAX_SIZE_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.MIN_MAX_SIZE_TAB_SELECTOR));
            }
        }

        public IWebElement DefaultResizableBox
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DEFAULT_RESIZABLE_BOX)));
                return this.driver.FindElement(By.Id(Constants.DEFAULT_RESIZABLE_BOX));
            }
        }

        public IWebElement DefaultResizeAngle
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.DEFAULT_RESIZE_ANGLE)));
                return this.driver.FindElement(By.XPath(Constants.DEFAULT_RESIZE_ANGLE));
            }
        }

        public IWebElement ConstraintResizableBox
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.CONSTRAINT_RESIZABLE_BOX)));
                return this.driver.FindElement(By.Id(Constants.CONSTRAINT_RESIZABLE_BOX));
            }
        }

        public IWebElement ConstraintResizeAngle
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.CONSTRAINT_RESIZE_ANGLE)));
                return this.driver.FindElement(By.XPath(Constants.CONSTRAINT_RESIZE_ANGLE));
            }
        }

        public IWebElement MinMaxResizableBox
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.MIN_MAX_RESIZABLE_BOX)));
                return this.driver.FindElement(By.Id(Constants.MIN_MAX_RESIZABLE_BOX));
            }
        }

        public IWebElement MinMaxResizeAngle
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.MIN_MAX_RESIZE_ANGLE)));
                return this.driver.FindElement(By.XPath(Constants.MIN_MAX_RESIZE_ANGLE));
            }
        }
    }
}
