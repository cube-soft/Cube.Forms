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
using System.Drawing;

namespace Cube.Forms
{
    /* --------------------------------------------------------------------- */
    ///
    /// IControl
    ///
    /// <summary>
    /// 各種コントロールのインターフェースです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    [Obsolete("The interface will be removed in the future version.")]
    public interface IControl : IDpiAwarable
    {
        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Enabled
        ///
        /// <summary>
        /// コントロールが有効かどうかを示す値を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        bool Enabled { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Visible
        ///
        /// <summary>
        /// コントロールが表示されているかどうかを示す値を取得または
        /// 設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        bool Visible { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Font
        ///
        /// <summary>
        /// フォントを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        Font Font { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Location
        ///
        /// <summary>
        /// 表示位置を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        Point Location { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Size
        ///
        /// <summary>
        /// 表示サイズを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        Size Size { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Margin
        ///
        /// <summary>
        /// 外側の余白を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        System.Windows.Forms.Padding Margin { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Padding
        ///
        /// <summary>
        /// 内側の余白を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        System.Windows.Forms.Padding Padding { get; set; }

        #endregion

        #region Events

        /* ----------------------------------------------------------------- */
        ///
        /// Click
        ///
        /// <summary>
        /// クリック時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        event EventHandler Click;

        /* ----------------------------------------------------------------- */
        ///
        /// EnabledChanged
        ///
        /// <summary>
        /// Enabled が変更された時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        event EventHandler EnabledChanged;

        /* ----------------------------------------------------------------- */
        ///
        /// VisibleChanged
        ///
        /// <summary>
        /// Visible が変更された時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        event EventHandler VisibleChanged;

        /* ----------------------------------------------------------------- */
        ///
        /// Move
        ///
        /// <summary>
        /// 移動時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        event EventHandler Move;

        /* ----------------------------------------------------------------- */
        ///
        /// Resize
        ///
        /// <summary>
        /// リサイズ時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        event EventHandler Resize;

        #endregion
    }
}
