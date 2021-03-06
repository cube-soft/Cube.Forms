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
using System.Windows.Forms;

namespace Cube.Forms.Behaviors
{
    /* --------------------------------------------------------------------- */
    ///
    /// CloseBehavior
    ///
    /// <summary>
    /// Provides functionality to close the window.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class CloseBehavior : MessageBehavior<CloseMessage>
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// CloseBehavior
        ///
        /// <summary>
        /// Initializes a new instance of the CloseBehavior class
        /// with the specified arguments.
        /// </summary>
        ///
        /// <param name="view">Source view.</param>
        /// <param name="vm">Presentable object.</param>
        ///
        /* ----------------------------------------------------------------- */
        public CloseBehavior(Form view, IPresentable vm) : base(vm)
        {
            _view = view;
        }

        #endregion

        #region Implementations

        /* ----------------------------------------------------------------- */
        ///
        /// Invoke
        ///
        /// <summary>
        /// Closes the provided window.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected override void Invoke(CloseMessage e) => _view?.Close();

        /* ----------------------------------------------------------------- */
        ///
        /// Dispose
        ///
        /// <summary>
        /// Releases the unmanaged resources used by the object and
        /// optionally releases the managed resources.
        /// </summary>
        ///
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources;
        /// false to release only unmanaged resources.
        /// </param>
        ///
        /* ----------------------------------------------------------------- */
        protected override void Dispose(bool disposing)
        {
            if (disposing) _view = null;
            base.Dispose(disposing);
        }

        #endregion

        #region Fields
        private Form _view;
        #endregion
    }
}
