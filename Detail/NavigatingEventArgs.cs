﻿/* ------------------------------------------------------------------------- */
///
/// NavigatingEventArgs.cs
/// 
/// Copyright (c) 2010 CubeSoft, Inc.
/// 
/// Licensed under the Apache License, Version 2.0 (the "License");
/// you may not use this file except in compliance with the License.
/// You may obtain a copy of the License at
///
///  http://www.apache.org/licenses/LICENSE-2.0
///
/// Unless required by applicable law or agreed to in writing, software
/// distributed under the License is distributed on an "AS IS" BASIS,
/// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
/// See the License for the specific language governing permissions and
/// limitations under the License.
///
/* ------------------------------------------------------------------------- */
using System;

namespace Cube.Forms
{
    /* --------------------------------------------------------------------- */
    ///
    /// NavigatingEventArgs
    /// 
    /// <summary>
    /// Web ブラウザにおいて、画面遷移が発生した時の引数を保持するための
    /// クラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class NavigatingEventArgs : System.ComponentModel.CancelEventArgs
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// NavigatingEventArgs
        /// 
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public NavigatingEventArgs(string url, string frame, bool cancel = false)
            : base(cancel)
        {
            Url = url;
            Frame = frame;
        }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Url
        /// 
        /// <summary>
        /// 遷移先の URL を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public string Url { get; private set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Frame
        /// 
        /// <summary>
        /// 遷移先のターゲットフレームを取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public string Frame { get; private set; }

        #endregion
    }
}
