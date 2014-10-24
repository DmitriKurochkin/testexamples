﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestProject.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Registration")]
    public partial class RegistrationFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Registration.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registration", "In order to create an account\r\nAs a user of the website\r\nI want to register on th" +
                    "e website\r\nhttp://localhost:6333/account/register", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[1]I want to register a new user witout filling login name field")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("registration")]
        public virtual void _1IWantToRegisterANewUserWitoutFillingLoginNameField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[1]I want to register a new user witout filling login name field", new string[] {
                        "negative",
                        "registration"});
#line 8
this.ScenarioSetup(scenarioInfo);
#line 9
 testRunner.Given("I am at the register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table1.AddRow(new string[] {
                        "LoginName",
                        ""});
            table1.AddRow(new string[] {
                        "Email",
                        "dmitry.kurochkin@gmail.com"});
            table1.AddRow(new string[] {
                        "Password",
                        "fls7fls7"});
            table1.AddRow(new string[] {
                        "PasswordConfirmation",
                        "fls7fls7"});
#line 10
 testRunner.When("I fill in the following form", ((string)(null)), table1, "When ");
#line 16
 testRunner.And("I click to the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("I should have an regisration error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[2]I want to register a new user witout filling email field")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("registration")]
        public virtual void _2IWantToRegisterANewUserWitoutFillingEmailField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[2]I want to register a new user witout filling email field", new string[] {
                        "negative",
                        "registration"});
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("I am at the register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table2.AddRow(new string[] {
                        "LoginName",
                        "fls7"});
            table2.AddRow(new string[] {
                        "Email",
                        ""});
            table2.AddRow(new string[] {
                        "Password",
                        "fls7fls7"});
            table2.AddRow(new string[] {
                        "PasswordConfirmation",
                        "fls7fls7"});
#line 22
 testRunner.When("I fill in the following form", ((string)(null)), table2, "When ");
#line 28
 testRunner.And("I click to the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.Then("I should have an regisration error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[3]I want to register a new user witout filling password field")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("registration")]
        public virtual void _3IWantToRegisterANewUserWitoutFillingPasswordField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[3]I want to register a new user witout filling password field", new string[] {
                        "negative",
                        "registration"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("I am at the register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table3.AddRow(new string[] {
                        "LoginName",
                        "fls7"});
            table3.AddRow(new string[] {
                        "Email",
                        "dmitry.kurochkin@gmail.com"});
            table3.AddRow(new string[] {
                        "Password",
                        ""});
            table3.AddRow(new string[] {
                        "PasswordConfirmation",
                        "fls7fls7"});
#line 34
 testRunner.When("I fill in the following form", ((string)(null)), table3, "When ");
#line 40
 testRunner.And("I click to the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("I should have an regisration error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[4]I want to register a new user witout filling password confirmation field")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("registration")]
        public virtual void _4IWantToRegisterANewUserWitoutFillingPasswordConfirmationField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[4]I want to register a new user witout filling password confirmation field", new string[] {
                        "negative",
                        "registration"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 45
 testRunner.Given("I am at the register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table4.AddRow(new string[] {
                        "LoginName",
                        "fls7"});
            table4.AddRow(new string[] {
                        "Email",
                        "dmitry.kurochkin@gmail.com"});
            table4.AddRow(new string[] {
                        "Password",
                        "fls7fls7"});
            table4.AddRow(new string[] {
                        "PasswordConfirmation",
                        ""});
#line 46
 testRunner.When("I fill in the following form", ((string)(null)), table4, "When ");
#line 52
 testRunner.And("I click to the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("I should have an regisration error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[5]I want to register a new user")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("registration")]
        public virtual void _5IWantToRegisterANewUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[5]I want to register a new user", new string[] {
                        "positive",
                        "registration"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 57
 testRunner.Given("I am at the register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table5.AddRow(new string[] {
                        "LoginName",
                        "fls"});
            table5.AddRow(new string[] {
                        "Email",
                        "dmitry.kurochkin@gmail.com"});
            table5.AddRow(new string[] {
                        "Password",
                        "flsfls"});
            table5.AddRow(new string[] {
                        "PasswordConfirmation",
                        "flsfls"});
#line 58
 testRunner.When("I fill in the registration form", ((string)(null)), table5, "When ");
#line 65
 testRunner.And("I click to the register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.Then("I should be at the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
