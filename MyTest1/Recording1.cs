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

namespace MyTest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording1 recording.
    /// </summary>
    [TestModule("85e48076-ee90-419d-8a8c-a4a9098bee83", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyTest1Repository repository.
        /// </summary>
        public static MyTest1Repository repo = MyTest1Repository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.EnterYourName' at 45;11.", repo.RxMainFrame.EnterYourNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.EnterYourName.Click("45;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.EnterYourName' at 45;11.", repo.RxMainFrame.EnterYourNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.EnterYourName.Click("45;11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'tahir' with focus on 'RxMainFrame.EnterYourName'.", repo.RxMainFrame.EnterYourNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.EnterYourName.PressKeys("tahir");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'RxMainFrame.BtnSubmitUserName' at 58;10.", repo.RxMainFrame.BtnSubmitUserNameInfo, new RecordItemIndex(3));
            repo.RxMainFrame.BtnSubmitUserName.MoveTo("58;10");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'RxMainFrame.BtnSubmitUserName' at 134;101.", repo.RxMainFrame.BtnSubmitUserNameInfo, new RecordItemIndex(4));
            repo.RxMainFrame.BtnSubmitUserName.MoveTo("134;101");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.BtnSubmitUserName' at 42;18.", repo.RxMainFrame.BtnSubmitUserNameInfo, new RecordItemIndex(5));
            repo.RxMainFrame.BtnSubmitUserName.Click("42;18");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxButtonExit' at 29;12.", repo.RxMainFrame.RxButtonExitInfo, new RecordItemIndex(6));
            repo.RxMainFrame.RxButtonExit.Click("29;12");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
