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
    [NUnit.Framework.DescriptionAttribute("ManageMyProfile")]
    public partial class ManageMyProfileFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ManageMyProfile.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ManageMyProfile", "", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("[1]Try to edit my profile without filling one mandatory field")]
        [NUnit.Framework.CategoryAttribute("negative")]
        [NUnit.Framework.CategoryAttribute("profile_management")]
        public virtual void _1TryToEditMyProfileWithoutFillingOneMandatoryField()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[1]Try to edit my profile without filling one mandatory field", new string[] {
                        "negative",
                        "profile_management"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table1.AddRow(new string[] {
                        "LoginName",
                        "fls9"});
            table1.AddRow(new string[] {
                        "Password",
                        "fls9fls9"});
#line 7
 testRunner.Given("I have login as below testuser", ((string)(null)), table1, "Given ");
#line 11
 testRunner.And("I go to manage my profile", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table2.AddRow(new string[] {
                        "LoginName",
                        "fls9"});
            table2.AddRow(new string[] {
                        "Password",
                        ""});
            table2.AddRow(new string[] {
                        "Email",
                        "fls9@fls.com"});
#line 12
 testRunner.When("I should try to edit my profile without password", ((string)(null)), table2, "When ");
#line 17
 testRunner.Then("I will get a password validation error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table3.AddRow(new string[] {
                        "LoginName",
                        "fls9"});
            table3.AddRow(new string[] {
                        "Password",
                        "fls9fls9"});
            table3.AddRow(new string[] {
                        "Email",
                        ""});
#line 18
 testRunner.When("I should try to edit my profile without email", ((string)(null)), table3, "When ");
#line 23
 testRunner.Then("I will get an email validation error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("[2]Edit my profile")]
        [NUnit.Framework.CategoryAttribute("positive")]
        [NUnit.Framework.CategoryAttribute("profile_management")]
        public virtual void _2EditMyProfile()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("[2]Edit my profile", new string[] {
                        "positive",
                        "profile_management"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("I am at the manage profile page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "field",
                        "value"});
            table4.AddRow(new string[] {
                        "LoginName",
                        "fls9"});
            table4.AddRow(new string[] {
                        "Password",
                        "fls9fls9"});
            table4.AddRow(new string[] {
                        "Email",
                        "fls9@fls.com"});
#line 29
 testRunner.When("I should try to edit my profile correctly", ((string)(null)), table4, "When ");
#line 34
 testRunner.Then("the result will be saved and I will be redirected to the home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion