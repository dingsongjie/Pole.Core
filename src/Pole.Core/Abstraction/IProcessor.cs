using Pole.Core.Process;
// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pole.Core.Abstraction
{
    public interface IProcessor
    {
        string Name { get; }
        Task Process(ProcessingContext context);
    }
}
