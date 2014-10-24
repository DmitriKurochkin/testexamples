using System;
using System.Threading;
using Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using TestProject.Pages;

namespace TestProject.StepsDefinition
{
    [Binding]
    public class BaseScenarioDefinition
    {
        public static IWebDriver Driver;

        public static LoginPage LoginPage;
        public static RegistrationPage RegistrationPage;
        public static TheHomePage HomePage;
        public static EditUserProfilePage ManagePage;

        public string CurrentUrl
        {
            get { return Driver.Url; }
        }

        public string Baseurl
        {
            get { return ConfigurationManager.AppSettings["baseurl"]; }
        }

        public string LoginUrl
        {
            get { return ConfigurationManager.AppSettings["loginurl"]; }
        }

        public string EnLoginUrl
        {
            get { return ConfigurationManager.AppSettings["enLoginUrl"]; }
        }

        public string RuLoginUrl
        {
            get { return ConfigurationManager.AppSettings["ruLoginUrl"]; }
        }

        public string EnHomeUrl
        {
            get { return ConfigurationManager.AppSettings["enHomeUrl"]; }
        }

        public string RuHomeUrl
        {
            get { return ConfigurationManager.AppSettings["ruHomeUrl"]; }
        }

        public string EnManageAccountUrl
        {
            get { return ConfigurationManager.AppSettings["enManageAccountUrl"]; }
        }

        public string RuManageAccountUrl
        {
            get { return ConfigurationManager.AppSettings["ruManageAccountUrl"]; }
        }

        public string ManageAccountUrl
        {
            get { return ConfigurationManager.AppSettings["manageAccountUrl"]; }
        }

        public void  GoToLoginPage()
        {
            Driver.Navigate().GoToUrl(Baseurl);
        }

        public void GoToManagePage()
        {
            Driver.Navigate().GoToUrl(RuManageAccountUrl);
        }


        public static bool WaitUntilElementIsPresent(IWebElement element, int count = 10)
        {
            for (var i = 0; i < count; i++)
            {
                if (element.Displayed) return true;
                Thread.Sleep(1000);
            }
            return false;
        }

        public static string Info(IWebElement element)
        {
            string info = "{";
            try { info += String.Format("Displayed: {0}; ", element.Displayed); }
            catch (Exception) { };
            info += "}";
            return info;
        }

        [BeforeTestRun]
        public static void StartWebDriver()
        {}

        [BeforeFeature]
        public static void StartWebDriverForReal()
        {
            switch (ConfigurationManager.AppSettings["webdriver"])
            {
                case "FireFox":
                    Driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    Driver = new ChromeDriver();
                    break;
                case "IE":
                    Driver = new InternetExplorerDriver();
                    break;
            }
            LoginPage = new LoginPage(Driver);
            RegistrationPage = new RegistrationPage(Driver);
            HomePage = new TheHomePage(Driver);
            ManagePage = new EditUserProfilePage(Driver);
        }

        [BeforeScenario]
        public static void GoToHomePage()
        {
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(3));
            Driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public static void AfterScenario()
        {}

        [AfterFeature]
        public static void KillBrowser()
        {
            Driver.Close();
        }

        [AfterTestRun]
        public static void TerminateWebDriver()
        {
            Driver.Quit();
        }

        [TearDown]
        public void CleanUp()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
        }
    }
}