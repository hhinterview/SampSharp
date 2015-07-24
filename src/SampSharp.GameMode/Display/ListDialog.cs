﻿// SampSharp
// Copyright 2015 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using SampSharp.GameMode.Definitions;

namespace SampSharp.GameMode.Display
{
    public class ListDialog : Dialog
    {
        private readonly List<string> _items = new List<string>();

        /// <summary>
        ///     Initializes a new instance of the Dialog class.
        /// </summary>
        /// <param name="caption">
        ///     The title at the top of the dialog. The length of the caption can not exceed more than 64
        ///     characters before it starts to cut off.
        /// </param>
        /// <param name="button1">The text on the left button.</param>
        /// <param name="button2">The text on the right button. Leave it blank to hide it.</param>
        public ListDialog(string caption, string button1, string button2 = null)
        {
            if (caption == null) throw new ArgumentNullException("caption");
            if (button1 == null) throw new ArgumentNullException("button1");
            Button1 = button1;
            Button2 = button2;
            Caption = caption;
            Style = DialogStyle.List;
        }

        public IList<string> Items
        {
            get { return _items; }
        }

        #region Overrides of Dialog

        /// <summary>
        ///     Gets the info displayed in the box.
        /// </summary>
        protected override string Info
        {
            get { return string.Join("\n", Items); }
        }

        #endregion
    }
}