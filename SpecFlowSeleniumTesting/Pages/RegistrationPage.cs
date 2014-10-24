using System;
using OpenQA.Selenium;

namespace TestProject.Pages
{
    public class RegistrationPage
    {
        private readonly IWebDriver driver;

        public RegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public readonly By LoginFieldSelector = By.Name("LoginName");
        public readonly By PasswordFieldSelector = By.Name("Password");
        public readonly By LoginButtonSelector= By.CssSelector(".btn.btn-info.btn-sm");
        public readonly By LoginErrorSelector = By.XPath("html/body/div/div/ul/li");
        public readonly By RuLanguageBarSelector = By.CssSelector(".label.label-primary");
        public readonly By EnLanguageBarSelector = By.CssSelector(".label.label-default");
        public readonly By RememberMeCheckBoxSelector = By.XPath("html/body/div/form/div[3]/div/div/label");
        public readonly By EmailFieldSelector = By.CssSelector("#Email");
        public readonly By ConfirmPasswordFiledSelector = By.CssSelector("#PasswordConfirmation");
        public readonly By RegistrationButtonSelector = By.CssSelector(".btn.btn-info.btn-sm");
        public readonly By FieldValidationErrorSelector = By.CssSelector(".field-validation-error>span");

        private IWebElement LoginForm
        {
            get { return driver.FindElement(LoginFieldSelector); }
        }

        private IWebElement EmailForm 
        {
            get { return driver.FindElement(EmailFieldSelector); }
        }

        private IWebElement PasswordForm
        {
            get { return driver.FindElement(PasswordFieldSelector); }
        }

        private IWebElement ConfirmPasswordForm
        {
            get { return driver.FindElement(ConfirmPasswordFiledSelector); }
        }

        private IWebElement RegistrationButton
        {
            get { return driver.FindElement(RegistrationButtonSelector); }
        }

        private IWebElement FieldValidationError
        {
            get { return driver.FindElement(FieldValidationErrorSelector); }
        }

        public void FillInTheRegistrationForm(TechTalk.SpecFlow.Table table)
        {
            var randomNumForLogin = new Random();
            table.Rows[0]["value"] = table.Rows[0]["value"] + randomNumForLogin.Next(10000);
                
            foreach (var row in table.Rows)
            {
                var textField = driver.FindElement(By.Name(row["field"]));
                textField.SendKeys(row["value"]);
            }
        }

        public bool IsRegistrationValidationErrorDisplayed()
        {
            return FieldValidationError.Displayed;
        }

        public RegistrationPage ClickRegistrationButton()
        {
            RegistrationButton.Click();
            return this;
        }

        public RegistrationPage ClearLoginForm()
        {
            LoginForm.Clear();
            return this;
        }

        public RegistrationPage ClearEmailForm()
        {
            EmailForm.Clear();
            return this;
        }

        public RegistrationPage ClearPasswordForm()
        {
            PasswordForm.Clear();
            return this;
        }

        public RegistrationPage ClearConfirmPasswordForm()
        {
            ConfirmPasswordForm.Clear();
            return this;
        }

        public RegistrationPage Do(string UserName, string Email, string Password, string ConfirmPassword)
        {
            LoginForm.SendKeys(UserName);
            EmailForm.SendKeys(Email);
            PasswordForm.SendKeys(Password);
            ConfirmPasswordForm.SendKeys(ConfirmPassword);
            driver.FindElement(RegistrationButtonSelector).Click();
            RegistrationButton.Click();

            return this;
        }

        public void ClearRegistrationForm()
        {
            ClearLoginForm();
            ClearEmailForm();
            ClearPasswordForm();
            ClearConfirmPasswordForm();
        }
    }
}