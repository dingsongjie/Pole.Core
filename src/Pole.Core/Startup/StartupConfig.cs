// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pole.Core.Startup
{
    public class StartupConfig
    {
        public StartupConfig(IServiceCollection services)
        {
            Services = services;
        }
        public IServiceCollection Services { get; }
        public Action<PoleOptions> PoleOptionsConfig { get; set; }
    }
}
