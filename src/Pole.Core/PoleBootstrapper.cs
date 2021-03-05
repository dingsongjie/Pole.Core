// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Pole.Core.Startup;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pole.Core
{
    public static class PoleBootstrapper
    {
        public static void UsePole(IServiceProvider serviceProvider)
        {
            StartupBuilder.StartPole(serviceProvider).GetAwaiter().GetResult();
        }
    }
}
