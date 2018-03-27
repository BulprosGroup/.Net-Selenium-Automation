namespace AutomationTests
{
    using System.Configuration;
    using System.Reflection;
    using NUnit.Framework;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using Data;
    using Models;
    using Pages.RegistrationPage;
    using AutomationTests.Extensions;

    [TestFixture]
    public class DemoQARegistrationTests
    {
        private IWebDriver driver;

        [SetUp]
        public void BeforeEachTest()
        {
            var options = new ChromeOptions();
            options.AddExtension(ConfigurationManager.AppSettings["extAdblockChrome"].ToAbsolutePath());
            this.driver = new ChromeDriver(options);
            this.driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void AfterEachTest()
        {
            this.driver.Log().Quit();
        }

        [Test]
        public void RegistrationWithoutLastNameShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
        }

        [Test]
        public void RegistrationWithoutNamesShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
        }

        [Test]
        public void RegistrationWithoutHobbiesShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertHobbiesErrorMessage();
        }

        [Test]
        public void RegistrationWithShortPhoneNumberShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertPhoneErrorMessage();
        }

        [Test]
        public void RegistrationWithInvalidPhoneNumberShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertPhoneErrorMessage();
        }

        [Test]
        public void RegistrationWithoutUsernameShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertUsernameErrorMessage();
        }

        [Test]
        public void RegistrationWithInvalidEmailShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertInvalidEmailErrorMessage();
        }

        [Test]
        public void RegistrationWithoutEmailShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertEmailErrorMessage();
        }

        [Test]
        public void RegistrationWithoutPasswordsShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertPasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithShortPasswordsShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertShortPasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithoutConfirmPasswordsShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertConfirmPasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithDiferentPasswordsShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertDiferentPasswordsErrorMessage();
        }

        [Test]
        public void RegistrationWithoutLastNameAndHobbiesShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertHobbiesErrorMessage();
        }

        [Test]
        public void RegistrationWithoutLastNameAndUsernameShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertUsernameErrorMessage();
        }

        [Test]
        public void RegistrationWithoutLastNameAndEmailShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertEmailErrorMessage();
        }

        [Test]
        public void RegistrationWithoutLastNameAndPasswordShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertPasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithoutLastNameAndConfirmPasswordShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertConfirmPasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithoutNamesAndHobbiesShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertHobbiesErrorMessage();
        }

        [Test]
        public void RegistrationWithoutNamesAndUsernameShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertUsernameErrorMessage();
        }

        [Test]
        public void RegistrationWithoutNamesAndEmailShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertEmailErrorMessage();
        }

        [Test]
        public void RegistrationWithoutNamesAndPasswordShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertPasswordErrorMessage();
        }

        [Test]
        public void RegistrationWithoutNamesAndConfirmPasswordShoulNotBeProcessed()
        {
            //// Arrange
            var registrationPage = new RegistrationPage(this.driver);
            var dataReader = new DataReader<RegistrationUser>();
            var user = dataReader.GetData(MethodBase.GetCurrentMethod().Name);

            //// Act
            registrationPage.Open();
            registrationPage.SubmitForm(user);

            //// Assert
            registrationPage.AssertNamesErrorMessage();
            registrationPage.AssertConfirmPasswordErrorMessage();
        }
    }
}