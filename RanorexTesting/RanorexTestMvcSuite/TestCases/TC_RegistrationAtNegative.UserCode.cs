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
    public partial class TC_RegistrationAtNegative
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_ВведитеЛогин2()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеЛогин'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеЛогинInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеЛогинInfo);
        }

        public void Key_Sequence_Логин4()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("{Delete}");
        }

        public void Mouse_Up_Логин1()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин1' at 136;17.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин1Info);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин1.MoveTo("136;17");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }

        public void Mouse_Down_Логин()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин' at 210;15.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин.MoveTo("210;15");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
        }

        public void Mouse_Click_Логин2()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин' at 210;15.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин.Click("210;15");
        }

        public void Key_Sequence_Email6()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls.com' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("fls.com");
        }

        public void Key_Sequence_Email5()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '777333{LShiftKey down}@{LShiftKey up}' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("777333{LShiftKey down}@{LShiftKey up}");
        }

        public void Key_Sequence_Email4()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("fls");
        }

        public void Mouse_Click_Email2()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email' at 84;21.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.Click("84;21");
        }

        public void Validate_ВведитеEmail3()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmail'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmailInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmailInfo);
        }

        public void Mouse_Click_Зарегистрироваться6()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться' at 38;15.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЗарегистрироватьсяInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться.Click("38;15");
        }

        public void Key_Sequence_Email3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("{Delete}");
        }

        public void Mouse_Up_None()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.None' at 187;41.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.NoneInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.None.MoveTo("187;41");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
        }

        public void Mouse_Down_Email()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email' at 226;16.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.MoveTo("226;16");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
        }

        public void Validate_ПаролиНеСовпадают()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ПаролиНеСовпадают'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ПаролиНеСовпадаютInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ПаролиНеСовпадаютInfo);
        }

        public void Mouse_Click_Зарегистрироваться5()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться' at 68;14.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЗарегистрироватьсяInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться.Click("68;14");
        }

        public void Key_Sequence_Пароль3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '333' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.PressKeys("333");
        }

        public void Key_Sequence_Пароль2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '777' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.PressKeys("777");
        }

        public void Key_Sequence_Пароль()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.PressKeys("fls");
        }

        public void Mouse_Click_Пароль()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль' at 169;21.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ПарольInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Пароль.Click("169;21");
        }

        public void Validate_ВведитеПароль3()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПароль'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПарольInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПарольInfo);
        }

        public void Mouse_Click_Зарегистрироваться4()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться' at 58;15.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЗарегистрироватьсяInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться.Click("58;15");
        }

        public void Key_Sequence_Email2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}@{LShiftKey up}fls.com' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("{LShiftKey down}@{LShiftKey up}fls.com");
        }

        public void Key_Sequence_Email()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls777333' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.PressKeys("fls777333");
        }

        public void Mouse_Click_Email()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email' at 133;18.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.EmailInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Email.Click("133;18");
        }

        public void Validate_ВведитеПароль2()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПароль'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПарольInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПарольInfo);
        }

        public void Validate_ВведитеEmail2()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmail'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmailInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmailInfo);
        }

        public void Mouse_Click_Зарегистрироваться3()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться' at 53;15.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЗарегистрироватьсяInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться.Click("53;15");
        }

        public void Key_Sequence_Логин3()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '333' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("333");
        }

        public void Key_Sequence_Логин2()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '777' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("777");
        }

        public void Key_Sequence_Логин()
        {
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fls' with focus on 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин.PressKeys("fls");
        }

        public void Mouse_Click_Логин()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин' at 107;13.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЛогинInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Логин.Click("107;13");
        }

        public void Validate_ВведитеПароль()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПароль'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПарольInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеПарольInfo);
        }

        public void Validate_ВведитеEmail()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmail'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmailInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеEmailInfo);
        }

        public void Validate_ВведитеЛогин()
        {
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеЛогин'.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеЛогинInfo);
            Validate.Exists(repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ВведитеЛогинInfo);
        }

        public void Mouse_Click_Зарегистрироваться2()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться' at 40;13.", repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.ЗарегистрироватьсяInfo);
            repo.LoginMozillaFirefox.HttpLocalhost6333AccountRegister.Зарегистрироваться.Click("40;13");
        }

        public void Mouse_Click_Зарегистрироваться()
        {
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'LoginMozillaFirefox.Login.Зарегистрироваться' at 67;6.", repo.LoginMozillaFirefox.Login.ЗарегистрироватьсяInfo);
            repo.LoginMozillaFirefox.Login.Зарегистрироваться.Click("67;6");
        }

        //public void TC_RegistrationAtNegative_Open_Browser()
        //{
        //    BrowserHelper.Open_Browser();
        //}
        
        public void Close_Application_LoginMozillaFirefox()
        {
            //BrowserHelper.Close_Application_LoginMozillaFirefox();
            BrowserHelper.Kill_Browser();

        }

    }
}