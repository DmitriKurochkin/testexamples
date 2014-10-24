﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
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
using Ranorex.Core.Repository;

namespace RanorexTestMvcSuite.TestCases
{
    /// <summary>
    ///The TC_LoginAtNegative recording.
    /// </summary>
    [TestModule("d5c50568-48a1-451a-b984-369e6b3b7cb9", ModuleType.Recording, 1)]
    public partial class TC_LoginAtNegative : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexTestMvcSuite.RanorexTestMvcSuiteRepository repository.
        /// </summary>
        public static RanorexTestMvcSuite.RanorexTestMvcSuiteRepository repo = RanorexTestMvcSuite.RanorexTestMvcSuiteRepository.Instance;

        static TC_LoginAtNegative instance = new TC_LoginAtNegative();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TC_LoginAtNegative()
        {
            loginFieldValidationMessage = "Введите логин";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TC_LoginAtNegative Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable loginFieldValidationMessage.
        /// </summary>
        [TestVariable("07073ce4-fcf1-495c-8330-6bda2fbedbff")]
        public string loginFieldValidationMessage
        {
            get { return repo.loginFieldValidationMessage; }
            set { repo.loginFieldValidationMessage = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Enter.
        /// </summary>
        [TestVariable("a9bd6d78-8cdf-49d7-a11f-8bb031c9a39b")]
        public string Enter
        {
            get { return repo.Enter; }
            set { repo.Enter = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable LoginField.
        /// </summary>
        [TestVariable("872dd417-e85a-423d-960c-f8447a8f63f6")]
        public string LoginField
        {
            get { return repo.LoginField; }
            set { repo.LoginField = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.1.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Mouse_Click_Логин();
            Delay.Milliseconds(0);
            
            Key_Sequence_Логин();
            Delay.Milliseconds(0);
            
            Mouse_Click_Войти();
            Delay.Milliseconds(0);
            
            Validate_ВведитеПароль1();
            Delay.Milliseconds(0);
            
            Mouse_Down_Логин();
            Delay.Milliseconds(0);
            
            Mouse_Up_Логин1();
            Delay.Milliseconds(0);
            
            Key_Sequence_Логин2();
            Delay.Milliseconds(0);
            
            Validate_ВведитеЛогин();
            Delay.Milliseconds(0);
            
            Mouse_Click_Пароль(loginFieldValidationMessage);
            Delay.Milliseconds(0);
            
            Key_Sequence_Пароль();
            Delay.Milliseconds(0);
            
            Mouse_Click_Войти2();
            Delay.Milliseconds(0);
            
            Validate_ВведитеЛогин2();
            Delay.Milliseconds(0);
            
            MergedUserCodeMethod();
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
}