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

namespace Cube.Forms
{
    /* --------------------------------------------------------------------- */
    ///
    /// Notice
    ///
    /// <summary>
    /// Represents the information of a notice.
    /// </summary>
    ///
    /* --------------------------------------------------------------------- */
    public class Notice
    {
        #region Properties

        /* ----------------------------------------------------------------- */
        ///
        /// Priority
        ///
        /// <summary>
        /// Gets or sets the priority of the notice.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public NoticePriority Priority { get; set; } = NoticePriority.Normal;

        /* ----------------------------------------------------------------- */
        ///
        /// Title
        ///
        /// <summary>
        /// Gets or sets the title of the notice.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public string Title { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Message
        ///
        /// <summary>
        /// Gets or sets the message of the notice.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public string Message { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// Value
        ///
        /// <summary>
        /// Gets or sets the user data of the notice.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public object Value { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// DisplayTime
        ///
        /// <summary>
        /// Gets or sets the time to display the notice.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public TimeSpan DisplayTime { get; set; }

        /* ----------------------------------------------------------------- */
        ///
        /// InitialDelay
        ///
        /// <summary>
        /// Gets or sets the time to delay the display of the notice.
        /// </summary>
        ///
        /* ----------------------------------------------------------------- */
        public TimeSpan InitialDelay { get; set; }

        #endregion
    }
}
