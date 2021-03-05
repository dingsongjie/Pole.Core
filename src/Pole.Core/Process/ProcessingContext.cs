// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Pole.Core.Process
{
    public class ProcessingContext
    {
        public ProcessingContext(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
        }
        public CancellationToken CancellationToken { get; }
        public bool IsStopping => CancellationToken.IsCancellationRequested;
    }
}
