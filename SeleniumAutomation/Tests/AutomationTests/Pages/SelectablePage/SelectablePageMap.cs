namespace AutomationTests.Pages.SelectablePage
{
    using System;
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class SelectablePageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public SelectablePageMap(IWebDriver driver)
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

        public IWebElement DisplayAsGridTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.DISPLAY_AS_GRID_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.DISPLAY_AS_GRID_TAB_SELECTOR));
            }
        }

        public IWebElement SerializeTab
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SERIALIZE_TAB_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SERIALIZE_TAB_SELECTOR));
            }
        }

        public IList<IWebElement> SelectableList
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SELECTABLE_LIST_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SELECTABLE_LIST_SELECTOR)).FindElements(By.TagName(Constants.SELECTABLE_LISTS_TAG_NAME_SELECTOR));
            }
        }

        public IList<IWebElement> SelectableGrid
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SELECTABLE_GRID_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SELECTABLE_GRID_SELECTOR)).FindElements(By.TagName(Constants.SELECTABLE_LISTS_TAG_NAME_SELECTOR));
            }
        }

        public IList<IWebElement> SerializeList
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SELECTABLE_SERIALIZIZE_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SELECTABLE_SERIALIZIZE_SELECTOR)).FindElements(By.TagName(Constants.SELECTABLE_LISTS_TAG_NAME_SELECTOR));
            }
        }

        public IWebElement SerializeResult
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.Id(Constants.SELECT_RESULT_SELECTOR)));
                return this.driver.FindElement(By.Id(Constants.SELECT_RESULT_SELECTOR));
            }
        }
    }
}
