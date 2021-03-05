// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pole.Core.Startup
{
    public class StartupTask
    {
        public StartupTask(Func<IServiceProvider, Task> func)
        {
            Func = func;
        }
        public Func<IServiceProvider, Task> Func { get; }
    }
}
