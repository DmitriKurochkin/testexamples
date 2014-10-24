using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace TestProject.StepsDefinition
{
    class CheckPaginationSteps : BaseScenarioDefinition
    {
        [Given("I am at the start page")]
        public void GivenIAmAtTheLoginPage()
        {
            GoToLoginPage();
        }

        [When("I fill into the following form")]
        public void FillInTheFollowingForm(Table table)
        {
            LoginPage.FillInTheLoginForm(table);
        }

        [When("I click login button")]
        public void AndIClickTheLoginButton()
        {
            LoginPage.ClickLoginButton();
        }

        [Then("I should be at home page")]
        public void ThenIShouldBeAtTheHomePage()
        {
            Assert.AreEqual(CurrentUrl, Baseurl);
        }

        [Then(@"^I click paginators, all that are there")]
        public void CheckPaginators()
        {
            HomePage.ClickPagination();
            Info(HomePage.FirstSortingContentBtn);
            Assert.IsTrue(HomePage.PageIsSwitched);
        }
    }
}
