using Microsoft.Extensions.DependencyInjection;
// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;

namespace Pole.Core
{
    public class PoleOptions
    {
        public IServiceCollection Services { get; private set; }
    }
}
