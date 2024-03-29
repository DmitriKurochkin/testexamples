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
    ///The TC_CheckPagination recording.
    /// </summary>
    [TestModule("6645da06-8542-4faf-95f1-8dbe7c47dcdf", ModuleType.Recording, 1)]
    public partial class TC_CheckPagination : ITestModule
    {
        /// <summary>
        /// Holds an instance of the RanorexTestMvcSuite.RanorexTestMvcSuiteRepository repository.
        /// </summary>
        public static RanorexTestMvcSuite.RanorexTestMvcSuiteRepository repo = RanorexTestMvcSuite.RanorexTestMvcSuiteRepository.Instance;

        static TC_CheckPagination instance = new TC_CheckPagination();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TC_CheckPagination()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static TC_CheckPagination Instance
        {
            get { return instance; }
        }

#region Variables

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
            
            Key_Sequence_Логин2();
            Delay.Milliseconds(0);
            
            Key_Sequence_Пароль();
            Delay.Milliseconds(0);
            
            Mouse_Click_Войти();
            Delay.Milliseconds(0);
            
            Validate_Text1();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text2();
            Delay.Milliseconds(0);
            
            Validate_Text21();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text3();
            Delay.Milliseconds(0);
            
            Validate_Text31();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text4();
            Delay.Milliseconds(0);
            
            Validate_Text41();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text5();
            Delay.Milliseconds(0);
            
            Validate_Text51();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text6();
            Delay.Milliseconds(0);
            
            Validate_Text61();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text7();
            Delay.Milliseconds(0);
            
            Validate_Text71();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text8();
            Delay.Milliseconds(0);
            
            Validate_Text81();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text9();
            Delay.Milliseconds(0);
            
            Validate_Text91();
            Delay.Milliseconds(0);
            
            Mouse_Click_Text10();
            Delay.Milliseconds(0);
            
            Validate_Text101();
            Delay.Milliseconds(0);
            
            Mouse_Click_Выход();
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
}
