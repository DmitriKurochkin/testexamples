using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestProject.StepsDefinition
{
    [Binding]
    public class ManageMyProfileSteps : BaseScenarioDefinition
    {
        [Given(@"I go to manage my profile")]
        public void GivenIGoToManageMyProfile()
        {
            HomePage.ClickEditMyProfileBtn();
        }

        [Given(@"I am at the manage profile page")]
        public void GivenIAmAtTheManagePage()
        {
            GoToManagePage();
        }

        [When(@"I should try to edit my profile without login")]
        public void WhenIShouldTryToEditMyProfileWithoutLogin(Table table)
        {
            ManagePage.FillIntoTheManageAccountForm(table);
        }
        
        [When(@"I should try to edit my profile without password")]
        public void WhenIShouldTryToEditMyProfileWithoutPassword(Table table)
        {
            ManagePage.FillIntoTheManageAccountForm(table);
        }
        
        [When(@"I should try to edit my profile without email")]
        public void WhenIShouldTryToEditMyProfileWithoutEmail(Table table)
        {
            ManagePage.FillIntoTheManageAccountForm(table);
        }
        
        [Then(@"I will get a password validation error")]
        public void ThenIWillGetAPasswordValidationError()
        {
            WaitUntilElementIsPresent(ManagePage.LastNameValidationErrorText(), 3);
            Assert.IsTrue(ManagePage.IsLastNameValidationError());
        }
        
        [Then(@"I will get an email validation error")]
        public void ThenIWillGetAnEmailValidationError()
        {
            Assert.IsTrue(ManagePage.IsEmailValidationError());
        }

        [Given(@"I have login as below testuser")]
        public void GivenIHaveLoginAsBelowTestuser(Table table)
        {
            LoginPage.LoginAsBelowTestUser(table);
        }

        [When(@"I should try to edit my profile correctly")]
        public void WhenIShouldTryToEditMyProfileCorrectly(Table table)
        {
            ManagePage.FillIntoTheManageAccountForm(table);
        }

        [Then(@"the result will be saved and I will be redirected to the home page")]
        public void ThenTheResultWillBeSavedAtTheMain()
        {
            Assert.AreEqual(CurrentUrl, RuHomeUrl);
        }
    }
}
