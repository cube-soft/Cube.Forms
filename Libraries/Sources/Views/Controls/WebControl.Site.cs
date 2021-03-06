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

namespace Cube.Forms.Controls
{
    partial class WebControl
    {
        /* ----------------------------------------------------------------- */
        ///
        /// ShowUIWebBrowserSite
        ///
        /// <summary>
        /// WebBrowser 上で表示されるメッセージダイアログ等を処理する
        /// ためのクラスです。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        protected class ShowUIWebBrowserSite : WebBrowserSite, IDocHostShowUI
        {
            #region Methods

            /* ------------------------------------------------------------- */
            ///
            /// ShowUIWebBrowserSite
            ///
            /// <summary>
            /// オブジェクトを初期化します。
            /// </summary>
            ///
            /* ------------------------------------------------------------- */
            public ShowUIWebBrowserSite(WebControl host) : base(host)
            {
                Host = host;
            }

            /* ------------------------------------------------------------- */
            ///
            /// Host
            ///
            /// <summary>
            /// 関連付ける WebBrowser オブジェクトを取得します。
            /// </summary>
            ///
            /* ------------------------------------------------------------- */
            public WebControl Host { get; private set; }

            /* ------------------------------------------------------------- */
            ///
            /// ShowMessage
            ///
            /// <summary>
            /// メッセージを表示します。
            /// </summary>
            ///
            /// <returns>
            /// 0 (S_OK) for handled; otherwise pass through.
            /// </returns>
            ///
            /* ------------------------------------------------------------- */
            public int ShowMessage(IntPtr hwnd, string text, string caption,
                int type, string file, int context, out int result)
            {
                var args = new DialogMessage
                {
                    Text    = text,
                    Title   = caption,
                    Buttons = GetButtons(type & 0x0f),
                    Icon    = GetIcon(type & 0xf0),
                    Value   = DialogStatus.Empty,
                };
                Host.OnMessageShowing(args);
                result = (int)args.Value;
                return (args.Value != DialogStatus.Empty) ? 0 : 1;
            }

            /* ------------------------------------------------------------- */
            ///
            /// ShowHelp
            ///
            /// <summary>
            /// ヘルプを表示します。
            /// </summary>
            ///
            /* ------------------------------------------------------------- */
            public int ShowHelp(IntPtr hwnd, string file, int command, int data,
                IntPtr /* POINT */ mouse, object hit) => 1;

            #endregion

            #region Implementations

            /* ------------------------------------------------------------- */
            ///
            /// GetButtons
            ///
            /// <summary>
            /// 表示ボタンを示すオブジェクトを取得します。
            /// </summary>
            ///
            /* ------------------------------------------------------------- */
            private DialogButtons GetButtons(int src)
            {
                foreach (DialogButtons mb in Enum.GetValues(typeof(DialogButtons)))
                {
                    if (src == (int)mb) return mb;
                }
                return DialogButtons.Ok;
            }

            /* ------------------------------------------------------------- */
            ///
            /// GetIcon
            ///
            /// <summary>
            /// 表示アイコンを示すオブジェクトを取得します。
            /// </summary>
            ///
            /* ------------------------------------------------------------- */
            private DialogIcon GetIcon(int src)
            {
                foreach (DialogIcon mi in Enum.GetValues(typeof(DialogIcon)))
                {
                    if (src == (int)mi) return mi;
                }
                return DialogIcon.Error;
            }

            #endregion
        }
    }
}
