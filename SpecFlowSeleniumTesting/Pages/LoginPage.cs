using Configuration;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestProject.Pages
{
    public class LoginPage
    {
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly IWebDriver driver;

        private string Baseurl
        {
            get { return ConfigurationManager.AppSettings["baseurl"]; }
        }

        private readonly By LoginFieldSelector = By.Name("LoginName");
        private readonly By PasswordFieldSelector = By.Name("Password");
        private readonly By LoginButtonSelector= By.CssSelector(".btn.btn-info.btn-sm");
        private readonly By RuLanguageBarSelector = By.CssSelector(".label.label-primary");
        private readonly By EnLanguageBarSelector = By.CssSelector(".label.label-default");
        private readonly By RegistrationButtonSelector = By.CssSelector(".col-sm-offset-2.col-sm-10>a");
        private readonly By SubminButtonSelector = By.XPath(".//*[@id='form-1']/input[6]");
        private readonly By LoginvalidationErrorSelector = By.CssSelector(".validation-summary-errors>ul>li");

        private IWebElement SubminButton 
        {
            get { return driver.FindElement(SubminButtonSelector); }
        }

        private IWebElement LoginForm
        {
            get { return driver.FindElement(LoginFieldSelector); }
        }

        private IWebElement PasswordForm
        {
            get { return driver.FindElement(PasswordFieldSelector); }
        }

        private IWebElement LoginButton
        {
            get { return driver.FindElement(LoginButtonSelector); }
        }

        private IWebElement RegistrationButton
        {
            get { return driver.FindElement(RegistrationButtonSelector); }
        }

        private IWebElement RuLanguageBar
        {
            get { return driver.FindElement(RuLanguageBarSelector); }
        }
        
        private IWebElement EnLanguageBar
        {
            get { return driver.FindElement(EnLanguageBarSelector); }
        }

        private IWebElement LoginvalidationError
        {
            get { return driver.FindElement(LoginvalidationErrorSelector); }
        }

        public bool IsLoginValidationErrorDisplayed()
        {
            return LoginvalidationError.Displayed;
        }

        public LoginPage LoginAsBelowTestUser(Table table)
        {
            GoToLoginPage();
            FillInTheLoginForm(table);
            ClickLoginButton();
            return this;
        }

        public LoginPage ClearLoginForm()
        {
            LoginForm.Clear();
            return this;
        }

        public LoginPage ClearPasswordForm()
        {
            PasswordForm.Clear();
            return this;
        }

        public void FillInTheLoginForm(TechTalk.SpecFlow.Table table)
        {
            foreach (var row in table.Rows)
            {
                var textField = driver.FindElement(By.Name(row["field"]));
                textField.SendKeys(row["value"]);
            }
        }

        public LoginPage ClickSubmitButton()
        {
            SubminButton.Click();
            return this;
        }

        public LoginPage ClickLoginButton()
        {
            LoginButton.Click();
            return this;
        }

        public LoginPage GoToLoginPage()
        {
            driver.Navigate().GoToUrl(Baseurl);
            return this;
        }

        public LoginPage Register()
        {
            RegistrationButton.Click();
            return this;
        }

        public LoginPage ClickRegistrationBtn()
        {
            RegistrationButton.Click();
            return this;
        }

        public LoginPage ClickEnLanguageBar()
        {
            EnLanguageBar.Click();
            return this;
        }

        public LoginPage LoginAsActualTestUser(Table table)
        {
            GoToLoginPage();
            FillInTheLoginForm(table);
            ClickLoginButton();

            return this;
        }

        public bool IsRuLanguageBarDisplayed()
        {
            return RuLanguageBar.Displayed;
        }

        public LoginPage GoToRegistrationPage()
        {
            GoToLoginPage();
            ClickRegistrationBtn();

            return this;
        }
    }
}