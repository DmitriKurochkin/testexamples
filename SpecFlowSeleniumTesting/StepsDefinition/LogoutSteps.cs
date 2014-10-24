using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestProject.StepsDefinition
{
    [Binding]
    public class LogoutSteps : BaseScenarioDefinition
    {
        [Given(@"I have login as test user")]
        public void LoginAsTestUser(Table table)
        {
            LoginPage.LoginAsActualTestUser(table);
        }

        [Given(@"I am at the home page")]
        public void GivenIAmAtTheLoginPage()
        {
            GoToLoginPage();
        }

        [When(@"I click logout button")]
        public void WhenIClickLogoutButton()
        {
            HomePage.Logout();
        }
        
        [Then(@"I am at the login page")]
        public void ThenIAmAtTheLoginPage()
        {
            Assert.AreEqual(CurrentUrl, LoginUrl);
        }
    }
}
