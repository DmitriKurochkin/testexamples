using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestProject.StepsDefinition
{
    [Binding]
    public class LoginSteps : BaseScenarioDefinition
    {
        [Given(@"I am at the login page")]
        public void GivenIAmAtTheLoginPage()
        {
            GoToLoginPage();
        }

        [When(@"I fill in the form")]
        public void WhenIFillInTheFollowingForm(Table table)
        {
            LoginPage.FillInTheLoginForm(table);
        }
        
        [When(@"I click this login button")]
        public void WhenIClickTheLoginButton()
        {
            LoginPage.ClickLoginButton();
        }
        
        [Then(@"I should be at user home page")]
        public void ThenIShouldBeAtTheHomePage()
        {
            Assert.AreEqual(CurrentUrl, Baseurl);
        }
        
        [Then(@"I have a login error")]
        public void ThenIHaveALoginError()
        {
            Assert.IsTrue(LoginPage.IsLoginValidationErrorDisplayed());
        }
    }
}
