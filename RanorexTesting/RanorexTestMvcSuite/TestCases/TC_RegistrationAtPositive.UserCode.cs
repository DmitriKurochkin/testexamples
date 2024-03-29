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
using System.Diagnostics;
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
    public partial class TC_RegistrationAtPositive
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Mouse_Click_Выход()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'IndexMozillaFirefox.Выход' at 23;11.", repo.IndexMozillaFirefox.ВыходInfo);
            repo.IndexMozillaFirefox.Выход.Click("23;11");
        }

        public void Validate_Fls999333()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='http://localhost:6333/account/manage') on item 'MozillaFirefox.Fls999333'.", repo.MozillaFirefox.Fls999333Info);
            Validate.Attribute(repo.MozillaFirefox.Fls999333Info, "Text", "http://localhost:6333/account/manage");
        }

        public void Mouse_Click_Зарегистрироваться2()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться' at 59;15.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ЗарегистрироватьсяInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться.Click("59;15");
        }

        public void Key_Sequence_ПодтверждениеПароля2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls999333' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароля'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароляInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароля.PressKeys("fls999333");
        }

        public void Key_Sequence_ПодтверждениеПароля()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls999333' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароля'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароляInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароля.PressKeys("fls999333");
        }

        public void Mouse_Click_ПодтверждениеПароля()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароля' at 228;13.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароляInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПодтверждениеПароля.Click("228;13");
        }

        public void Key_Sequence_Пароль3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls999333' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.PressKeys("fls999333");
        }

        public void Key_Sequence_Пароль2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '333' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.PressKeys("333");
        }

        public void Key_Sequence_Пароль()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls999' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.PressKeys("fls999");
        }

        public void Mouse_Click_Пароль()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль' at 233;18.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.Click("233;18");
        }

        public void Key_Sequence_Email6()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '.com' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys(".com");
        }

        public void Key_Sequence_Email5()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("fls");
        }

        public void Key_Sequence_Email4()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}@{LShiftKey up}' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("{LShiftKey down}@{LShiftKey up}");
        }

        public void Key_Sequence_Email3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '222' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("222");
        }

        public void Key_Sequence_Email2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '999' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("999");
        }

        public void Key_Sequence_Email()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("fls");
        }

        public void Mouse_Click_Email()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MozillaFirefox.HttpLocalhost6333AccountRegister.Email' at 211;22.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Email.Click("211;22");
        }

        public void Key_Sequence_Логин3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '333' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("333");
        }

        public void Key_Sequence_Логин2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '999' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("999");
        }

        public void Key_Sequence_Логин()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("fls");
        }

        public void Mouse_Click_Логин()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MozillaFirefox.HttpLocalhost6333AccountRegister.Логин' at 90;18.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Логин.Click("90;18");
        }

        public void Mouse_Click_Зарегистрироваться()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.Login.Зарегистрироваться' at 62;14.", repo.LoginMozillaFirefox.Login.ЗарегистрироватьсяInfo);
            repo.LoginMozillaFirefox.Login.Зарегистрироваться.Click("62;14");
        }

        //public void TC_RegistrationAtPositive_Open_Browser()
        //{
        //    BrowserHelper.Open_Browser();

        //}
        
        public void Close_Application_LoginMozillaFirefox()
        {
            //BrowserHelper.Close_Application_LoginMozillaFirefox();
            BrowserHelper.Kill_Browser();
        }

        public void Key_Sequence_Login()
        {
        	var randomNumForLogin = new Random();
                    
#region --- Merged from "Key_Sequence_Логин()" ---
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls' with focus on 'MozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.MozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.MozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("fls" + randomNumForLogin.Next(10000));
#endregion
        }

        public void Validate_Find()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Find') on item 'IndexMozillaFirefox.Find'.", repo.IndexMozillaFirefox.FindInfo);
            Validate.Attribute(repo.IndexMozillaFirefox.FindInfo, "Text", "Find");
        }

    }
}