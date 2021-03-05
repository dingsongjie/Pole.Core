// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using MassTransit;
using Pole.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pole.Core
{
    public class DefaultIdGenerator : IIdGenerator
    {
        public string GetGeneratorId()
        {
            return NewId.Next().ToString("D").ToUpperInvariant(); ;
        }
    }
}
