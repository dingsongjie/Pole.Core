// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.Extensions.DependencyInjection;
using Pole.Core.Abstraction;
using Pole.Core.Serialization;
using Pole.Core.Startup;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pole.Core.Extensions
{
    public static class PoleServiceCollectionExtensions
    {
        public static IServiceCollection AddPole(this IServiceCollection services, Action<StartupConfig> config)
        {
            StartupConfig startupOption = new StartupConfig(services);
            if (startupOption.PoleOptionsConfig == null)
            {
                services.Configure<PoleOptions>(option => { });
            }
            services.AddSingleton<IJsonSerializer, DefaultJsonSerializer>();
            services.AddSingleton<IIdGenerator, DefaultIdGenerator>();

            config(startupOption);
            return services;
        }
    }
}
