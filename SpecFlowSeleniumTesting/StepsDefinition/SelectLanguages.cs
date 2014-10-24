using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestProject.StepsDefinition
{
    [Binding]
    class SelectLanguages : BaseScenarioDefinition
    {
        [Given(@"I go to the login page")]
        public void IGoToTheLoginPage()
        {
            GoToLoginPage();
        }

        [Given(@"I have login as below user")]
        public void IHaveLoginAsBelowUser(Table table)
        {
            LoginPage.LoginAsBelowTestUser(table);
        }

        [Given(@"I go to the edit my profile page")]
        public void GoToEditMyProfilePage()
        {
            HomePage.ClickEditMyProfileBtn();
        }

        [Given(@"^Language on this page is 'Ru'")]
        public void CheckThatLanguageIsRu()
        {
            Assert.IsTrue(LoginPage.IsRuLanguageBarDisplayed());
        }

        [Given(@"I am on the home page")]
        public void IAmAtTheHomePage()
        {
            GoToLoginPage();
        }

        [When(@"I change the language to 'En'")]
        public void ClickEnButton()
        {
            LoginPage.ClickEnLanguageBar();
        }

        [When(@"I change the language to 'Ru'")]
        public void ClickRuButton()
        {
            LoginPage.ClickEnLanguageBar();
        }

        [Then(@"^Language on the login page is changed to english")]
        public void CheckLanguageIsChangedToEnOnTheLoginPage()
        {
            Assert.AreEqual(CurrentUrl, EnLoginUrl);
        }

        [Then(@"^Language on the login page is changed to russian")]
        public void CheckLanguageIsChangedToRuOnTheLoginPage()
        {
            Assert.AreEqual(CurrentUrl, RuLoginUrl);
        }

        [Then(@"Language on this page is changed to english")]
        public void CheckLanguageIsChangedToEnglish()
        {
            Assert.AreEqual(CurrentUrl, EnHomeUrl);
        }

        [Then(@"Language on this page is changed to russian")]
        public void CheckLanguageIsChangedToRussian()
        {
            Assert.AreEqual(CurrentUrl, RuHomeUrl);
        }

        [Then(@"Language on the edit profile page is changed to russian")]
        public void CheckLanguageOnTheEditProfilePageIsChangedToRu()
        {
            Assert.AreEqual(CurrentUrl, RuManageAccountUrl);
        }

        [Then(@"Language on the edit profile page is changed to english")]
        public void CheckLanguageOnTheEditProfilePageIsChangedToEn()
        {
            Assert.AreEqual(CurrentUrl, EnManageAccountUrl);
        }
    }
}
