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
    /// MockView
    ///
    /// <summary>
    /// IForm を最小構成で実装した Mock クラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class MockView : IForm
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
        public bool Enabled
        {
            get => _enabled;
            set
            {
                if (_enabled == value) return;
                _enabled = value;
                EnabledChanged?.Invoke(this, EventArgs.Empty);
            }
        }

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
        public bool Visible
        {
            get => _visible;
            set
            {
                if (_visible == value) return;
                _visible = value;
                VisibleChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Font
        ///
        /// <summary>
        /// フォントを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public Font Font { get; set; } = SystemFonts.DefaultFont;

        /* ----------------------------------------------------------------- */
        ///
        /// Location
        ///
        /// <summary>
        /// 表示位置を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public Point Location
        {
            get => _location;
            set
            {
                if (_location == value) return;
                _location = value;
                Move?.Invoke(this, EventArgs.Empty);
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Size
        ///
        /// <summary>
        /// 表示サイズを取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public Size Size
        {
            get => _size;
            set
            {
                if (_size == value) return;
                _size = value;
                Resize?.Invoke(this, EventArgs.Empty);
            }
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Margin
        ///
        /// <summary>
        /// 外側の余白を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public System.Windows.Forms.Padding Margin { get; set; } =
            new System.Windows.Forms.Padding(0);

        /* ----------------------------------------------------------------- */
        ///
        /// Padding
        ///
        /// <summary>
        /// 内側の余白を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public System.Windows.Forms.Padding Padding { get; set; } =
            new System.Windows.Forms.Padding(0);

        /* ----------------------------------------------------------------- */
        ///
        /// Dpi
        ///
        /// <summary>
        /// DPI の値を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public double Dpi
        {
            get => _dpi;
            set
            {
                if (_dpi == value) return;
                var prev = _dpi;
                _dpi = value;
                DpiChanged?.Invoke(this, ValueEventArgs.Create(prev, value));
            }
        }

        #endregion

        #region Events

        /* ----------------------------------------------------------------- */
        ///
        /// Load
        ///
        /// <summary>
        /// オブジェクトがロードされた時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler Load;

        /* ----------------------------------------------------------------- */
        ///
        /// Activated
        ///
        /// <summary>
        /// View がアクティブ化した時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler Activated;

        /* ----------------------------------------------------------------- */
        ///
        /// Deactivate
        ///
        /// <summary>
        /// View が非アクティブ化した時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler Deactivate;

        /* ----------------------------------------------------------------- */
        ///
        /// Click
        ///
        /// <summary>
        /// クリック時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler Click;

        /* ----------------------------------------------------------------- */
        ///
        /// EnabledChanged
        ///
        /// <summary>
        /// Enabled が変更された時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler EnabledChanged;

        /* ----------------------------------------------------------------- */
        ///
        /// VisibleChanged
        ///
        /// <summary>
        /// Visible が変更された時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler VisibleChanged;

        /* ----------------------------------------------------------------- */
        ///
        /// Move
        ///
        /// <summary>
        /// 移動時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler Move;

        /* ----------------------------------------------------------------- */
        ///
        /// Resize
        ///
        /// <summary>
        /// リサイズ時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event EventHandler Resize;

        /* ----------------------------------------------------------------- */
        ///
        /// DpiChanged
        ///
        /// <summary>
        /// DPI 変更時に発生するイベントです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public event ValueChangedEventHandler<double> DpiChanged;

        #endregion

        #region Methods

        /* ----------------------------------------------------------------- */
        ///
        /// Activate
        ///
        /// <summary>
        /// View をアクティブ化します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public virtual void Activate() => Activated?.Invoke(this, EventArgs.Empty);

        /* ----------------------------------------------------------------- */
        ///
        /// Close
        ///
        /// <summary>
        /// View を閉じます。
        /// </summary>
        ///
        /// <remarks>
        /// MockView では、Visible プロパティを false に設定します。
        /// </remarks>
        ///
        /* ----------------------------------------------------------------- */
        public virtual void Close()
        {
            Deactivate?.Invoke(this, EventArgs.Empty);
            Visible = false;
        }

        /* ----------------------------------------------------------------- */
        ///
        /// Show
        ///
        /// <summary>
        /// View を表示します。
        /// </summary>
        ///
        /// <remarks>
        /// MockView では Load イベントを発生させた後、Visible プロパティを
        /// true に設定します。
        /// </remarks>
        ///
        /* ----------------------------------------------------------------- */
        public virtual void Show()
        {
            Load?.Invoke(this, EventArgs.Empty);
            Visible = true;
            Activate();
        }

        /* ----------------------------------------------------------------- */
        ///
        /// OnClick
        ///
        /// <summary>
        /// Click イベントを発生させます。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected virtual void OnClick(EventArgs e) => Click.Invoke(this, e);

        #endregion

        #region Fields
        private bool _enabled = true;
        private bool _visible = false;
        private Point _location;
        private Size _size;
        private double _dpi = 96.0;
        #endregion
    }
}