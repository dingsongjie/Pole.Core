// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Pole.Core.Process;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pole.Core.Abstraction
{
    public abstract class ProcessorBase : IProcessor
    {
        public abstract string Name { get; }

        public abstract Task Process(ProcessingContext context);

        public override string ToString()
        {
            return Name;
        }
    }
}
