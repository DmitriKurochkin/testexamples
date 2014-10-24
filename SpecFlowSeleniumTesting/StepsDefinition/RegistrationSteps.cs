using NUnit.Framework;
using TechTalk.SpecFlow;

namespace TestProject.StepsDefinition
{
    [Binding]
    class RegistrationSteps : BaseScenarioDefinition
    {
        [Given(@"I am at the register page")]
        public void GivenIamAtTheRegisterPage()
        {
            LoginPage.GoToRegistrationPage();
        }

        [When("I fill in the following form")]
        public void FillInTheFollowingForm(Table table)
        {
            LoginPage.FillInTheLoginForm(table);
        }

        [When(@"I fill in the registration form")]
        public void FillInTheregistrationForm(Table table)
        {
            RegistrationPage.FillInTheRegistrationForm(table);
        }

        [When(@"^I click to the register button")]
        public void ClickRegisterButton()
        {
            RegistrationPage.ClickRegistrationButton();
        }

        [When(@"I will clear a registration form")]
        public void ClearRegistrationForm()
        {
            RegistrationPage.ClearRegistrationForm();
        }

        [Then(@"^I should have an regisration error")]
        public void GiveAnRegistrationError()
        {
            Assert.IsTrue(RegistrationPage.IsRegistrationValidationErrorDisplayed());
        }

        [Then("I should be at the home page")]
        public void ThenIShouldBeAtTheHomePage()
        {
            Assert.AreEqual(CurrentUrl, Baseurl);
        }
    }
}
