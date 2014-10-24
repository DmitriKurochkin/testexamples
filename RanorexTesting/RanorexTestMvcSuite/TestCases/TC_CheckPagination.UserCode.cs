﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
// 
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
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
    public partial class TC_CheckPagination
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }
        
        public void Close()
        {
        	BrowserHelper.Close_Application_LoginMozillaFirefox();
        }

        public void Mouse_Click_Выход()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Выход' at 16;7.", repo.IndexMozillaFirefox.ВыходInfo);
            repo.IndexMozillaFirefox.Выход.Click("16;7");
        }

        public void Validate_Text101()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text101'.", repo.IndexMozillaFirefox.Index.Text101Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text101Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text10()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text10' at 7;9.", repo.IndexMozillaFirefox.Index.Text10Info);
            repo.IndexMozillaFirefox.Index.Text10.Click("7;9");
        }

        public void Validate_Text91()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text91'.", repo.IndexMozillaFirefox.Index.Text91Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text91Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text9()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text9' at 3;7.", repo.IndexMozillaFirefox.Index.Text9Info);
            repo.IndexMozillaFirefox.Index.Text9.Click("3;7");
        }

        public void Validate_Text81()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text81'.", repo.IndexMozillaFirefox.Index.Text81Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text81Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text8()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text8' at 3;10.", repo.IndexMozillaFirefox.Index.Text8Info);
            repo.IndexMozillaFirefox.Index.Text8.Click("3;10");
        }

        public void Validate_Text71()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text71'.", repo.IndexMozillaFirefox.Index.Text71Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text71Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text7()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text7' at 3;7.", repo.IndexMozillaFirefox.Index.Text7Info);
            repo.IndexMozillaFirefox.Index.Text7.Click("3;7");
        }

        public void Validate_Text61()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text61'.", repo.IndexMozillaFirefox.Index.Text61Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text61Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text6()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text6' at 4;10.", repo.IndexMozillaFirefox.Index.Text6Info);
            repo.IndexMozillaFirefox.Index.Text6.Click("4;10");
        }

        public void Validate_Text51()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text51'.", repo.IndexMozillaFirefox.Index.Text51Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text51Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text5()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text5' at 5;9.", repo.IndexMozillaFirefox.Index.Text5Info);
            repo.IndexMozillaFirefox.Index.Text5.Click("5;9");
        }

        public void Validate_Text41()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text41'.", repo.IndexMozillaFirefox.Index.Text41Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text41Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text4()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text4' at 4;9.", repo.IndexMozillaFirefox.Index.Text4Info);
            repo.IndexMozillaFirefox.Index.Text4.Click("4;9");
        }

        public void Validate_Text31()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text31'.", repo.IndexMozillaFirefox.Index.Text31Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text31Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text3()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text3' at 3;5.", repo.IndexMozillaFirefox.Index.Text3Info);
            repo.IndexMozillaFirefox.Index.Text3.Click("3;5");
        }

        public void Validate_Text21()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text21'.", repo.IndexMozillaFirefox.Index.Text21Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text21Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Text2()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Index.Text2' at 3;7.", repo.IndexMozillaFirefox.Index.Text2Info);
            repo.IndexMozillaFirefox.Index.Text2.Click("3;7");
        }

        public void Validate_Text1()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (AccessibleRole='Text') on item 'IndexMozillaFirefox.Index.Text1'.", repo.IndexMozillaFirefox.Index.Text1Info);
            Validate.Attribute(repo.IndexMozillaFirefox.Index.Text1Info, "AccessibleRole", "Text");
        }

        public void Mouse_Click_Войти()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.Login.Войти' at 27;17.", repo.LoginMozillaFirefox.Login.ВойтиInfo);
            repo.LoginMozillaFirefox.Login.Войти.Click("27;17");
        }

        public void Key_Sequence_Пароль()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls7fls7' with focus on 'LoginMozillaFirefox.Login.Пароль'.", repo.LoginMozillaFirefox.Login.ПарольInfo);
            repo.LoginMozillaFirefox.Login.Пароль.PressKeys("fls7fls7");
        }

        public void Mouse_Click_Пароль()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.Login.Пароль' at 254;27.", repo.LoginMozillaFirefox.Login.ПарольInfo);
            repo.LoginMozillaFirefox.Login.Пароль.Click("254;27");
        }

        public void Key_Sequence_Логин()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls7' with focus on 'LoginMozillaFirefox.Login.Логин'.", repo.LoginMozillaFirefox.Login.ЛогинInfo);
            repo.LoginMozillaFirefox.Login.Логин.PressKeys("fls7");
        }

        public void Mouse_Click_Логин()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.Login.Логин' at 244;16.", repo.LoginMozillaFirefox.Login.ЛогинInfo);
            repo.LoginMozillaFirefox.Login.Логин.Click("244;16");
        }

        //public void TC_CheckPagination_Open_Browser()
        //{
        //    BrowserHelper.Open_Browser();
        //}

        public void Key_Sequence_Логин2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'LoginMozillaFirefox.Login.Логин'.", repo.LoginMozillaFirefox.Login.ЛогинInfo);
            repo.LoginMozillaFirefox.Login.Логин.PressKeys("{Tab}");
        }

    }
}