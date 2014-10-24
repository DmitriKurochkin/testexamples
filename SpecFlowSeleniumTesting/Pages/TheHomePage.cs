using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestProject.Pages
{
    public class TheHomePage
    {
        private readonly IWebDriver driver;

        public TheHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private readonly By FirstSortingContentSelector = By.XPath(".//*[@id='content']/a[4]");
        private readonly By FirstUserEditProfileBtnSelector = By.XPath(".//*[@id='static-1']/a");
        private readonly By FirstUserFirstNameFieldSelector = By.Name("FirstName");
        private readonly By FirstUserLastNameFieldSelector = By.Name("LastName");
        private readonly By FirstUserEmailFieldSelector = By.Name("Email");
        private readonly By TextOfSavedUserOnPageSelector = By.XPath(".//*[@id='fname-1']");
        private readonly By LogoutButtonSelector = By.XPath("html/body/div/p[1]/a[2]");
        private readonly By SubminButtonSelector = By.XPath(".//*[@id='form-1']/input[6]");
        private readonly By EditMyProfileSelector = By.XPath("html/body/div/p[1]/a[1]");

        private IWebElement SubminButton
        {
            get { return driver.FindElement(SubminButtonSelector); }
        }

        private IWebElement EditMyProfile
        {
            get { return driver.FindElement(EditMyProfileSelector); }
        }

        private IWebElement EditProfileBtn 
        {
            get { return driver.FindElement(FirstUserEditProfileBtnSelector); }
        }

        private IWebElement FirstUserFirstNameField
        {
            get { return driver.FindElement(FirstUserFirstNameFieldSelector); }
        }

        private IWebElement FirstUserLastNameField
        {
            get { return driver.FindElement(FirstUserLastNameFieldSelector); }
        }

        private IWebElement FirstUserEmailField
        {
            get { return driver.FindElement(FirstUserEmailFieldSelector); }
        }

        private IWebElement ChangedLoginNameText
        {
            get { return driver.FindElement(TextOfSavedUserOnPageSelector); }
        }

        private IWebElement LogoutButton
        {
            get { return driver.FindElement(LogoutButtonSelector); }
        }

        public IWebElement FirstSortingContentBtn
        {
            get { return driver.FindElement(FirstSortingContentSelector); }
        }

        private IWebElement FirstUserEditProfileBtn
        {
            get { return driver.FindElement(FirstUserEditProfileBtnSelector); }
        }

        private IWebElement SubmintButton
        {
            get { return driver.FindElement(SubminButtonSelector); }
        }

        public IWebElement ToChangeLoginName()
        {
            return ChangedLoginNameText;
        }

        public bool PageIsSwitched
        {
            get { return driver.FindElement(FirstSortingContentSelector).Displayed; }
        }

        public TheHomePage ClickPagination()
        {
            FirstSortingContentBtn.Click();
            return this;
        }

        public bool IsBaseTestNameSaved(Table table)
        {
            return (ChangedLoginNameText.Text == table.Rows[0]["value"]);
        }

        public TheHomePage ClickEditProfileBtn()
        {
            EditProfileBtn.Click();
            return this;
        }

        public void FillInTheEditProfileForm(TechTalk.SpecFlow.Table table)
        {
            foreach (var row in table.Rows)
            {
                var textField = driver.FindElement(By.Name(row["field"]));
                textField.SendKeys(row["value"]);
            }
        }

        public TheHomePage Logout()
        {
            LogoutButton.Click();
            return this;
        }

        public TheHomePage EditProfile(string FirstName, string LastName, string Email)
        {
            FirstUserEditProfileBtn.Click();
            FirstUserFirstNameField.Clear();
            FirstUserFirstNameField.SendKeys(FirstName);
            FirstUserLastNameField.Clear();
            FirstUserLastNameField.SendKeys(LastName);
            FirstUserEmailField.Clear();
            FirstUserEmailField.SendKeys(Email);
            SubmintButton.Click();
            
            return new TheHomePage(driver);
        }

        public TheHomePage ClickEditMyProfileBtn()
        {
            EditMyProfile.Click();
            return this;
        }

        public TheHomePage CheckPaginators()
        {
            FirstSortingContentBtn.Click();
            return this;
        }

        public void EditUserProfile(Table table)
        {
            ClickEditProfileBtn();
            FirstUserFirstNameField.Clear();
            FirstUserLastNameField.Clear();
            FirstUserEmailField.Clear();
            FillInTheEditProfileForm(table);
        }

        public TheHomePage ClickSubmitButton()
        {
            SubminButton.Click();
            return this;
        }
    }
}
