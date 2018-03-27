namespace AutomationTests.Pages.DroppablePage
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class DroppablePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public DroppablePageMap(IWebDriver driver)
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

        public IWebElement AcceptTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.ACCEPT_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.ACCEPT_TAB_SELECTOR));
            }
        }

        public IWebElement PreventPropagationTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.PREVENT_PROPAGATION_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.PREVENT_PROPAGATION_TAB_SELECTOR));
            }
        }

        public IWebElement RevertDraggablePossitionTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.REVERT_DRAGGABLE_POSITION_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.REVERT_DRAGGABLE_POSITION_TAB_SELECTOR));
            }
        }

        public IWebElement ShoppingCartTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SHOPING_CART_DEMO_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SHOPING_CART_DEMO_TAB_SELECTOR));
            }
        }

        public IWebElement DraggableView
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DRAGGABLE_VIEW_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.DRAGGABLE_VIEW_SELECTOR));
            }
        }

        public IWebElement DroppableView
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.DROPPABLE_VIEW_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.DROPPABLE_VIEW_SELECTOR));
            }
        }

        public IWebElement DraggableNonVaid
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DRAGGABLE_NON_VALID_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.DRAGGABLE_NON_VALID_SELECTOR));
            }
        }

        public IWebElement DroppableAccept
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.DROPPABLE_ACCEPT_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.DROPPABLE_ACCEPT_SELECTOR));
            }
        }

        public IWebElement DraggableProp
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DRAGGABLE_PROP_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.DRAGGABLE_PROP_SELECTOR));
            }
        }

        public IWebElement InnerDroppableGreedy
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.INNER_DROPPABLE_GREEDY_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.INNER_DROPPABLE_GREEDY_SELECTOR));
            }
        }

        public IWebElement OuterDroppable
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.OUTER_DROPPABLE_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.OUTER_DROPPABLE_SELECTOR));
            }
        }

        public IWebElement DraggableRevert
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DRAGGABLE_REVERT_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.DRAGGABLE_REVERT_SELECTOR));
            }
        }

        public IWebElement DroppableRevert
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.DROPPABLE_REVERT_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.DROPPABLE_REVERT_SELECTOR));
            }
        }

        public IWebElement Product
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.PRODUCT_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.PRODUCT_SELECTOR));
            }
        }

        public IWebElement ShoppingCart
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.SHOPPING_CART_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.SHOPPING_CART_SELECTOR));
            }
        }
    }
}
