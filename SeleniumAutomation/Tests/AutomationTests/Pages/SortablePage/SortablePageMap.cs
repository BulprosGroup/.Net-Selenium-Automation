namespace AutomationTests.Pages.SortablePage
{
    using System;
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class SortablePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SortablePageMap(IWebDriver driver)
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

        public IWebElement ConnectListsTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.CONNECT_LISTS_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.CONNECT_LISTS_TAB_SELECTOR));
            }
        }

        public IWebElement DisplayAsGridTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DISPLAY_AS_GRID_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.DISPLAY_AS_GRID_TAB_SELECTOR));
            }
        }

        public IList<IWebElement> SorableList
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SORTABLE_LIST_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SORTABLE_LIST_SELECTOR)).FindElements(By.TagName(Constants.SORTABLE_LISTS_TAG_NAME_SELECTOR));
            }
        }

        public IList<IWebElement> ConnectListOne
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.CONNECT_LIST_ONE_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.CONNECT_LIST_ONE_SELECTOR)).FindElements(By.TagName(Constants.SORTABLE_LISTS_TAG_NAME_SELECTOR));
            }
        }

        public IList<IWebElement> ConnectListTwo
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.CONNECT_LIST_TWO_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.CONNECT_LIST_TWO_SELECTOR)).FindElements(By.TagName(Constants.SORTABLE_LISTS_TAG_NAME_SELECTOR));
            }
        }

        public IList<IWebElement> SorableGrid
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SORTABLE_GRID_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SORTABLE_GRID_SELECTOR)).FindElements(By.TagName(Constants.SORTABLE_LISTS_TAG_NAME_SELECTOR));
            }
        }
    }
}
