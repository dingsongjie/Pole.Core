// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole.Core.Startup
{
    public static class StartupBuilder
    {
        static List<StartupTask> tasks = new List<StartupTask>();
        public static void Register(Func<IServiceProvider, Task> method)
        {
            tasks.Add(new StartupTask(method));
        }
        internal static Task StartPole(IServiceProvider serviceProvider)
        {
            tasks = tasks.ToList();
            return Task.WhenAll(tasks.Select(value => value.Func(serviceProvider)));
        }
    }
}
