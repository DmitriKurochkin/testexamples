using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestProject.StepsDefinition
{
    [Binding]
    public class EditUserProfileSteps : BaseScenarioDefinition
    {
        [Given(@"I have login as user")]
        public void GivenIHaveLoginAsUser(Table table)
        {
            LoginPage.LoginAsBelowTestUser(table);
        }

        [When(@"^I should try to edit first user profile")]
        public void WhenEditUserProfile(Table table)
        {
            HomePage.EditUserProfile(table);
        }
        
        [When(@"I submit changes")]
        public void WhenIClickTheSubmitButton()
        {
            HomePage.ClickSubmitButton();
        }
        
        [Then(@"Edited form will be saved")]
        public void ThenEditedFormWillBeSaved(Table table)
        {
            WaitUntilElementIsPresent(HomePage.ToChangeLoginName(), 5);
            Assert.IsTrue(HomePage.IsBaseTestNameSaved(table));
        }
    }
}