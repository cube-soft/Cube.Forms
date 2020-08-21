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
using System;
using System.Reflection;
using System.Windows.Forms;

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

            var asm = Assembly.GetExecutingAssembly();
            ContentsControl.Resize += WhenResize;
            DemoButton1.Click += (s, e) => new VersionWindow(asm)
            {
                Icon = Icon,
                Text = Text,
            }.ShowDialog();

            Caption = HeaderCaptionControl;
            Text = $"{ProductName} {ProductVersion}";
        }

        #endregion

        #region Implementations

        /* --------------------------------------------------------------------- */
        ///
        /// WhenResize
        ///
        /// <summary>
        /// リサイズ時に実行されるハンドラです。
        /// </summary>
        ///
        /* --------------------------------------------------------------------- */
        private void WhenResize(object s, EventArgs e)
        {
            if (!(s is Control control)) return;

            var width = control.ClientSize.Width;
            var left  = control.Padding.Left;
            var right = control.Padding.Right;

            DemoButton1.Width = width - left - right;
        }

        #endregion
    }
}