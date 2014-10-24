using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestProject.Pages
{
    public class EditUserProfilePage
    {
        private readonly IWebDriver driver;

        public EditUserProfilePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By exitButtonSelector = By.XPath("html/body/div/p[1]/a[2]");
        private readonly By primaryLanguageBarSelector = By.CssSelector(".label.label-primary");//By.XPath("html/body/div/text/a[1]");
        private readonly By defaultLanguageBarSelector = By.CssSelector(".label.label-default");//By.XPath("html/body/div/text/a[2]");
        private readonly By validationEditFormErrorSelector = By.CssSelector(".field-validation-valid");
        private readonly By firstNameValidationFormSelector = By.XPath(".//*[@id='FirstName']");//By.CssSelector("FirstName");
        private readonly By lastNameValidationFormSelector = By.XPath(".//*[@id='LastName']");//By.CssSelector("LastName");
        private readonly By emailValidationFormSelector = By.XPath(".//*[@id='Email']");//By.CssSelector("Email");
        private readonly By firstNameValidationErrorSelector = By.XPath("/html/body/div/form[2]/div[1]/div/span/span");
        private readonly By lastNameValidationErrorErrorSelector = By.XPath("html/body/div/form[2]/div[2]/div/span/span");
        private readonly By emailValidationErrorSelector = By.XPath("html/body/div/form[2]/div[3]/div/span/span");
        private readonly By confirmButtonSelector = By.CssSelector(".btn.btn-info.btn-sm");//By.XPath("html/body/div/form[2]/div[4]/div/input");
        private readonly By backwardButtonSelector = By.CssSelector(".col-sm-offset-2.col-sm-10>a");//By.XPath("html/body/div/form[2]/div[4]/div/a");
        
        private IWebElement ExitButton
        {
            get { return driver.FindElement(exitButtonSelector); }
        }

        private IWebElement PrimaryLanguageBar
        {
            get { return driver.FindElement(primaryLanguageBarSelector); }
        }

        private IWebElement DefaultLanguageBar
        {
            get { return driver.FindElement(defaultLanguageBarSelector); }
        }

        private IWebElement ValidationEditFormError
        {
            get { return driver.FindElement(validationEditFormErrorSelector); }
        }

        private IWebElement FirstNameValidationForm
        {
            get { return driver.FindElement(firstNameValidationFormSelector); }
        }

        private IWebElement LastNameValidationForm
        {
            get { return driver.FindElement(lastNameValidationFormSelector); }
        }

        private IWebElement EmailValidationForm
        {
            get { return driver.FindElement(emailValidationFormSelector); }
        }

        private IWebElement FirstNameValidationError
        {
            get { return driver.FindElement(firstNameValidationErrorSelector); }
        }

        private IWebElement LastNameValidationError
        {
            get { return driver.FindElement(lastNameValidationErrorErrorSelector); }
        }

        public IWebElement LastNameValidationErrorText()
        {
            return LastNameValidationError;
        }

        private IWebElement EmailValidationError
        {
            get { return driver.FindElement(emailValidationErrorSelector); }
        }
        
        private IWebElement ConfirmButton
        {
            get { return driver.FindElement(confirmButtonSelector); }
        }

        private IWebElement BackwardButton
        {
            get { return driver.FindElement(backwardButtonSelector); }
        }

        public EditUserProfilePage ClickBackwardBtn()
        {
            BackwardButton.Click();
            return this;
        }

        public EditUserProfilePage ClickConfirmBtn()
        {
            ConfirmButton.Click();
            return this;
        }

        public bool IsValidationEditFormError()
        {
            return ValidationEditFormError.Displayed;
        }
        
        public bool IsEmailValidationError()
        {
            return EmailValidationError.Displayed;
        }

        public bool IsLastNameValidationError()
        {
            return LastNameValidationError.Displayed;
        }

        public bool IsFirstNameValidationError()
        {
            return FirstNameValidationError.Displayed;
        }

        public EditUserProfilePage FillIntoTheManageAccountForm(Table table)
        {
            FillIntoFirstNameForm(table);
            FillIntoLastNameForm(table);
            FillIntoEmailForm(table);
            ClickConfirmBtn();

            return this;
        }

        public EditUserProfilePage FillIntoFirstNameForm(Table table)
        {
            FirstNameValidationForm.Clear();
            FirstNameValidationForm.SendKeys(table.Rows[0]["value"]);

            return this;
        }

        public EditUserProfilePage FillIntoLastNameForm(Table table)
        {
            LastNameValidationForm.Clear();
            LastNameValidationForm.SendKeys(table.Rows[1]["value"]);

            return this;
        }

        public EditUserProfilePage FillIntoEmailForm(Table table)
        {
            EmailValidationForm.Clear();
            EmailValidationForm.SendKeys(table.Rows[2]["value"]);

            return this;
        }

        public EditUserProfilePage ClickExitButton()
        {
            ExitButton.Click();
            return this;
        }

        public EditUserProfilePage ClickPrimatyLanguageBar()
        {
            PrimaryLanguageBar.Click();
            return this;
        }

        public EditUserProfilePage ClickDefaultLanguageBar()
        {
            DefaultLanguageBar.Click();
            return this;
        }
    }
}
