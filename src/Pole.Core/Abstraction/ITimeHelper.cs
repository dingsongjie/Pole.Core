// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Pole.Core.Abstraction
{
    public interface ITimeHelper
    {
        DateTime GetUTCNow();

        /// <summary>
        /// "UTC :{_timeHelper.GetNow().ToString("yyyy-MM-dd HH:mm:ss.fff")}"
        /// </summary>
        /// <returns></returns>
        string GetAppropriateFormatedDateString();
    }
}
