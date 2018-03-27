namespace AutomationTests.Pages.DraggablePage
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class DraggablePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public DraggablePageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }

        public IWebElement DefaultTab
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.DEFAULT_TAB_SELECTOR));
            }
        }

        public IWebElement ContrainMovementTab
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.CONSTRAIN_MOVEMENT_TAB_SELECTOR));
            }
        }

        public IWebElement CursorStyleTab
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.CURSOR_STYLE_TAB_SELECTOR));
            }
        }

        public IWebElement EventsTab
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.EVENTS_TAB_SELECTOR));
            }
        }

        public IWebElement DraggableAndSortableTab
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.DRAGGABLE_AND_SORTABLE_TAB_SELECTOR));
            }
        }

        public IWebElement BodyElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.TagName(Constants.BODY_ELEMENT)));
                return this.driver.FindElement(By.TagName(Constants.BODY_ELEMENT));
            }
        }

        public IWebElement DefaultDragElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DEFAULT_DRAG_ELEMENT)));
                return this.driver.FindElement(By.Id(Constants.DEFAULT_DRAG_ELEMENT));
            }
        }

        public IWebElement ConstraintMovementElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.CONSTRAINT_MOVEMENT_ELEMENT)));
                return this.driver.FindElement(By.Id(Constants.CONSTRAINT_MOVEMENT_ELEMENT));
            }
        }

        public IWebElement CursorStyleElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.CURSOR_STYLE_ELEMENT)));
                return this.driver.FindElement(By.Id(Constants.CURSOR_STYLE_ELEMENT));
            }
        }

        public IWebElement DragEventElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DRAG_EVENT_ELEMENT)));
                return this.driver.FindElement(By.Id(Constants.DRAG_EVENT_ELEMENT));
            }
        }

        public IWebElement EventStartElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.EVENT_START_ELEMENT)));
                return this.driver.FindElement(By.XPath(Constants.EVENT_START_ELEMENT));
            }
        }

        public IWebElement EventDragElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.EVENT_DRAG_ELEMENT)));
                return this.driver.FindElement(By.XPath(Constants.EVENT_DRAG_ELEMENT));
            }
        }

        public IWebElement EventStopElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.EVENT_STOP_ELEMENT)));
                return this.driver.FindElement(By.XPath(Constants.EVENT_STOP_ELEMENT));
            }
        }
        public IWebElement DraggableBoxElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DRAGGABLE_BOX_ELEMENT)));
                return this.driver.FindElement(By.Id(Constants.DRAGGABLE_BOX_ELEMENT));
            }
        }

        public IWebElement DragMeDownElement
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.DRAG_ME_DOWN_ELEMENT)));
                return this.driver.FindElement(By.XPath(Constants.DRAG_ME_DOWN_ELEMENT));
            }
        }
    }
}
