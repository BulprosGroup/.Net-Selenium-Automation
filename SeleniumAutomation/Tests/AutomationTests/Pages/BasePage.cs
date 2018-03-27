namespace AutomationTests.Pages
{
    using OpenQA.Selenium;

    public abstract class BasePage<T> where T : class
    {
        public BasePage(IWebDriver driver, T elements)
        {
            this.Driver = driver;
            this.Elements = elements;
        }

        public IWebDriver Driver { get; private set; }

        public T Elements { get; private set; }

        public abstract string Url { get; }

        public virtual void Open(string part = "")
        {
            this.Driver.Navigate().GoToUrl($"{this.Url}{part}");
        }
    }
}
