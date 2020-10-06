﻿/* ------------------------------------------------------------------------- */
//
// Copyright (c) 2010 CubeSoft, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
/* ------------------------------------------------------------------------- */
namespace Cube.Forms.Demo
{
    /* --------------------------------------------------------------------- */
    ///
    /// MainWindow
    ///
    /// <summary>
    /// Represents the main window.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public partial class MainWindow : BorderlessWindow
    {
        #region Constructors

        /* --------------------------------------------------------------------- */
        ///
        /// MainWindow
        ///
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        public MainWindow()
        {
            InitializeComponent();

            Caption = HeaderCaptionControl;
            Text    = $"{ProductName} {ProductVersion}";

            Behaviors.Add(new FlowLayoutBehavior(ContentsControl));
        }

        #endregion

        #region Implementations

        /* --------------------------------------------------------------------- */
        ///
        /// OnBind
        ///
        /// <summary>
        /// Binds the window with the specified presenter.
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        protected override void OnBind(IPresentable src)
        {
            base.OnBind(src);
            if (!(src is MainViewModel vm)) return;

            DemoButton1.Click += (s, e) => vm.About();
            DemoButton2.Click += (s, e) => vm.Notice();

            Behaviors.Add(new ShowVersionBehavior(vm, this));
            Behaviors.Add(new ShowNoticeBehavior(vm));
        }

        #endregion
    }
}
