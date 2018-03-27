namespace AutomationTests.Pages.RegistrationPage
{
    internal static class Constants
    {
        //// Common
        internal const string REGISTRATION_URL = "http://demoqa.com/registration/";
        internal const int WAIT_SECCONDS = 20;

        //// Messages
        internal const string ERROR_REQUIRED = "* This field is required";
        internal const string ERROR_PHONE = "* Minimum 10 Digits starting with Country Code";
        internal const string ERROR_EMAIL = "* Invalid email address";
        internal const string ERROR_SHORT_PASSWORD = "* Minimum 8 characters required";
        internal const string ERROR_PASSWORD_NOT_MATCH = "* Fields do not match";

        //// Selectors
        internal const string TITLE_SELECTOR = "title";
        internal const string HEADER_SELECTOR = "entry-title";
        internal const string FIRST_NAME_SELECTOR = "name_3_firstname";
        internal const string LAST_NAME_SELECTOR = "name_3_lastname";
        internal const string MARITAL_STATUS_SELECTOR = "radio_4[]";
        internal const string HOBBYS = "checkbox_5[]";
        internal const string COUNTRY_SELLECTOR = "dropdown_7";
        internal const string MOUNTH_SELECTOR = "mm_date_8";
        internal const string DAY_SELECTOR = "dd_date_8";
        internal const string YEAR_SELECTOR = "yy_date_8";
        internal const string PHONE_SELECTOR = "phone_9";
        internal const string USERNAME_SELECTOR = "username";
        internal const string EMAIL_SELECTOR = "email_1";
        internal const string UPLOAD_BUTTON_SELECTOR = "profile_pic_10";
        internal const string DESCRIPTION_SELECTOR = "description";
        internal const string PASSWORD_SELECTOR = "password_2";
        internal const string CONFIRM_PASSWORD_SELECTOR = "confirm_password_password_2";
        internal const string _SUBMIT_BUTTON_SELECTOR = "pie_submit";
        internal const string SUCCESS_MESSAGE_SELECTOR = "piereg_message";
        internal const string ERROR_NAME_SELECTOR = "//*[@id=\"pie_register\"]/li[1]/div[1]/div[2]/span";
        internal const string ERROR_HOBBIES_SELECTOR = "//*[@id=\"pie_register\"]/li[3]/div/div[2]/span";
        internal const string ERROR_PHONE_SELECTOR = "//*[@id=\"pie_register\"]/li[6]/div/div/span";
        internal const string ERROR_USERNAME_SELECTOR = "//*[@id=\"pie_register\"]/li[7]/div/div/span";
        internal const string ERROR_EMAIL_SELECTOR = "//*[@id=\"pie_register\"]/li[8]/div/div/span";
        internal const string ERROR_PASSWORD_SELECTOR = "//*[@id=\"pie_register\"]/li[11]/div/div/span";
        internal const string ERROR_CONFIRM_PASSWORD_SELECTOR = "//*[@id=\"pie_register\"]/li[12]/div/div/span";
    }
}
