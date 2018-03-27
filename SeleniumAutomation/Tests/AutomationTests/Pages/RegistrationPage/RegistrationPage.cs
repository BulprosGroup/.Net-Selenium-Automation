namespace AutomationTests.Pages.RegistrationPage
{
    using OpenQA.Selenium;
    using Models;
    using Extensions;

    public class RegistrationPage : BasePage<RegistrationPageMap>
    {
        public RegistrationPage(IWebDriver driver) : base(driver, new RegistrationPageMap(driver))
        {
        }

        public override string Url
        {
            get
            {
                return Constants.REGISTRATION_URL;
            }
        }

        public void SubmitForm(RegistrationUser user)
        {
            this.Elements.FirstName.Type(user.FirstName);
            this.Elements.LastName.Type(user.LastName);
            this.Elements.MaritalStatus.ClickOnElements(user.MaritalStatus);
            this.Elements.Hobbys.ClickOnElements(user.Hobbies);
            this.Elements.CountryOption.SelectByText(user.Country);
            this.Elements.MounthOption.SelectByText(user.BirthMonth);
            this.Elements.DayOption.SelectByText(user.BirthDay);
            this.Elements.YearOption.SelectByText(user.BirthYear);
            this.Elements.Phone.Type(user.Phone);
            this.Elements.UserName.Type(user.Username);
            this.Elements.Email.Type(user.Email);
            this.Elements.UploadButton.Click();
            this.Driver.SwitchTo().ActiveElement().SendKeys(user.Picture.ToAbsolutePath());
            this.Elements.Description.Type(user.Description);
            this.Elements.Password.Type(user.Password);
            this.Elements.ConfirmPassword.Type(user.ConfirmPassword);
            this.Elements.SubmitButton.Click();
        }
    }
}
