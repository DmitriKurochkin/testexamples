/*
 * Created by Ranorex
 * User: DKurochkin
 * Date: 11.08.2014
 * Time: 15:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Configuration;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace RanorexTestMvcSuite.TestCases
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("3F7401DA-DC91-4009-A0A7-589659FBA307", ModuleType.UserCode, 1)]
    public class BrowserHelper : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BrowserHelper()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }

        static readonly string AssignmentBrowser = ConfigurationManager.AppSettings["browser"];

        static readonly string AssignmentUrl = ConfigurationManager.AppSettings["baseurl"];

        static readonly RanorexTestMvcSuiteRepository Repo = RanorexTestMvcSuiteRepository.Instance;
        
        public static void Close_Application_LoginMozillaFirefox()
        {
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'LoginMozillaFirefox'.", Repo.LoginMozillaFirefox.SelfInfo);
            Host.Local.CloseApplication(Repo.LoginMozillaFirefox.Self, new Duration(0));
        }
        
        public static void Close_Application_IndexMozillaFirefox()
        {
        	Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'IndexMozillaFirefox'.", Repo.IndexMozillaFirefox.SelfInfo);
        	Host.Local.CloseApplication(Repo.IndexMozillaFirefox.Self, new Duration(0));
        }

        public static void Open_Browser(string browser, string url)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(browser);
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            startInfo.Arguments = url;
            Process.Start(startInfo);
        }

        public static void Kill_Browser()
        {
            Host.Local.KillBrowser(AssignmentBrowser);
        }
    }
}
