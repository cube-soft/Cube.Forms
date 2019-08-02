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
using Cube.FileSystem;
using System;

namespace Cube.Forms
{
    /* --------------------------------------------------------------------- */
    ///
    /// OverwriteMode
    ///
    /// <summary>
    /// 上書き方法を示す列挙型です。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    [Flags]
    public enum OverwriteMode
    {
        /// <summary>問い合わせ</summary>
        Query = 0x000,
        /// <summary>キャンセル</summary>
        Cancel = 0x002,
        /// <summary>はい</summary>
        Yes = 0x006,
        /// <summary>いいえ</summary>
        No = 0x007,
        /// <summary>リネーム</summary>
        Rename = 0x010,
        /// <summary>操作用マスク</summary>
        Operations = 0x01f,

        /// <summary>常に同じ操作を適用するオプション</summary>
        Always = 0x100,
        /// <summary>常にはい</summary>
        AlwaysYes = Always | Yes,
        /// <summary>常にいいえ</summary>
        AlwaysNo = Always | No,
        /// <summary>常にリネーム</summary>
        AlwaysRename = Always | Rename,
    }

    /* --------------------------------------------------------------------- */
    ///
    /// OverwriteInfo
    ///
    /// <summary>
    /// 上書き対象となる項目の情報を保持するためのクラスです。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class OverwriteEventArgs : EventArgs
    {
        #region Constructors

        /* ----------------------------------------------------------------- */
        ///
        /// OverwriteEventArgs
        ///
        /// <summary>
        /// オブジェクトを初期化します。
        /// </summary>
        ///
        /// <param name="src">上書き元の情報</param>
        /// <param name="dest">上書き先の情報</param>
        ///
        /* ----------------------------------------------------------------- */
        public OverwriteEventArgs(Entity src, Entity dest)
        {
            Source      = src;
            Destination = dest;
        }

        #endregion

        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Source
        ///
        /// <summary>
        /// 上書き元の情報を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public Entity Source { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// Destination
        ///
        /// <summary>
        /// 上書き先の情報を取得します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public Entity Destination { get; }

        /* ----------------------------------------------------------------- */
        ///
        /// Result
        ///
        /// <summary>
        /// 上書き方法を取得または設定します。
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public OverwriteMode Result { get; set; } = OverwriteMode.Cancel;

        #endregion
    }

    /* --------------------------------------------------------------------- */
    ///
    /// OverwriteEventHandler
    ///
    /// <summary>
    /// 上書き確認ダイアログを表示するための delegate です。
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    [Serializable]
    public delegate void OverwriteEventHandler(object sender, OverwriteEventArgs e);
}
