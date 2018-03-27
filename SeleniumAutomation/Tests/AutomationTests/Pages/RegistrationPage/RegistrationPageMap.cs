namespace AutomationTests.Pages.RegistrationPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;

    public class RegistrationPageMap
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public RegistrationPageMap(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(this.driver, TimeSpan.FromSeconds(Constants.WAIT_SECCONDS));
        }

        public IWebElement Title
        {
            get
            {
                return this.driver.FindElement(By.TagName(Constants.TITLE_SELECTOR));
            }
        }

        public IWebElement Header
        {
            get
            {
                return this.driver.FindElement(By.ClassName(Constants.HEADER_SELECTOR));
            }
        }

        public IWebElement FirstName
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.FIRST_NAME_SELECTOR));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.LAST_NAME_SELECTOR));
            }
        }

        public List<IWebElement> MaritalStatus
        {
            get
            {
                return this.driver.FindElements(By.Name(Constants.MARITAL_STATUS_SELECTOR)).ToList();
            }
        }

        public List<IWebElement> Hobbys
        {
            get
            {
                return this.driver.FindElements(By.Name(Constants.HOBBYS)).ToList();
            }
        }

        private IWebElement CountryDD
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.COUNTRY_SELLECTOR));
            }
        }

        public SelectElement CountryOption
        {
            get
            {
                return new SelectElement(CountryDD);
            }
        }

        private IWebElement MounthDD
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.MOUNTH_SELECTOR));
            }
        }

        public SelectElement MounthOption
        {
            get
            {
                return new SelectElement(MounthDD);
            }
        }

        private IWebElement DayDD
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.DAY_SELECTOR));
            }
        }

        public SelectElement DayOption
        {
            get
            {
                return new SelectElement(DayDD);
            }
        }

        private IWebElement YearDD
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.YEAR_SELECTOR));
            }
        }

        public SelectElement YearOption
        {
            get
            {
                return new SelectElement(YearDD);
            }
        }

        public IWebElement Phone
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.PHONE_SELECTOR));
            }
        }

        public IWebElement UserName
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.USERNAME_SELECTOR));
            }
        }

        public IWebElement Email
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.EMAIL_SELECTOR));
            }
        }

        public IWebElement UploadButton
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.UPLOAD_BUTTON_SELECTOR));
            }
        }

        public IWebElement Description
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.DESCRIPTION_SELECTOR));
            }
        }

        public IWebElement Password
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.PASSWORD_SELECTOR));
            }
        }

        public IWebElement ConfirmPassword
        {
            get
            {
                return this.driver.FindElement(By.Id(Constants.CONFIRM_PASSWORD_SELECTOR));
            }
        }

        public IWebElement SubmitButton
        {
            get
            {
                return this.driver.FindElement(By.Name(Constants._SUBMIT_BUTTON_SELECTOR));
            }
        }

        public IWebElement SuccessMessage
        {
            get
            {
                return this.driver.FindElement(By.ClassName(Constants.SUCCESS_MESSAGE_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForNames
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.ERROR_NAME_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_NAME_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForHobbies
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.ERROR_HOBBIES_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_HOBBIES_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForPhone
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.ERROR_PHONE_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_PHONE_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForUsername
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.ERROR_USERNAME_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_USERNAME_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForEmail
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.ERROR_EMAIL_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_EMAIL_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForPassword
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.ERROR_PASSWORD_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_PASSWORD_SELECTOR));
            }
        }

        public IWebElement ErrorMessagesForConfirmPassword
        {
            get
            {
                this.wait.Until(d => d.FindElement(By.XPath(Constants.ERROR_CONFIRM_PASSWORD_SELECTOR)));
                return this.driver.FindElement(By.XPath(Constants.ERROR_CONFIRM_PASSWORD_SELECTOR));
            }
        }
    }
}
