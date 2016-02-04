﻿/* ------------------------------------------------------------------------- */
///
/// Position.cs
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
namespace Cube.Forms
{
    /* --------------------------------------------------------------------- */
    ///
    /// Position
    /// 
    /// <summary>
    /// コントロール中の位置を表すための列挙型です。
    /// </summary>
    /// 
    /// <remarks>
    /// https://msdn.microsoft.com/en-us/library/windows/desktop/ms645618.aspx
    /// </remarks>
    ///
    /* --------------------------------------------------------------------- */
    public enum Position : int
    {
        NoWhere          = 0x00, // HTNOWHERE
        Client           = 0x01, // HTCLIENT
        Caption          = 0x02, // HTCAPTION
        SystemMenu       = 0x03, // HTSYSMENU
        Size             = 0x04, // HTSIZE or HTGROWBOX
        Menu             = 0x05, // HTMENU
        HorizontalScroll = 0x06, // HTHSCROLL
        VerticalScroll   = 0x07, // HTVSCROLL
        Minimize         = 0x08, // HTMINBUTTON or HTREDUCE
        Maximize         = 0x09, // HTMAXBUTTON or HTZOOM
        Left             = 0x0a, // HTLEFT
        Right            = 0x0b, // HTRIGHT
        Top              = 0x0c, // HTTOP
        TopLeft          = 0x0d, // HTTOPLEFT
        TopRight         = 0x0e, // HTTOPRIGHT
        Bottom           = 0x0f, // HTBOTTOM
        BottomLeft       = 0x10, // HTBOTTOMLEFT
        BottomRight      = 0x11, // HTBOTTOMRIGHT
        Border           = 0x12, // HTBORDER
        Close            = 0x14, // HTCLOSE
        Help             = 0x15, // HTHELP
        Transparent      = -1,   // HTTRANSPARENT
        Error            = -2,   // HTERROR
    }
}