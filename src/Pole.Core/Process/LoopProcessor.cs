// Copyright (c) .NET Core Community. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.Extensions.Logging;
using Pole.Core.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pole.Core.Process
{
    public class LoopProcessor : ProcessorBase
    {
        private IProcessor _processor;
        private readonly ILoggerFactory _loggerFactory;
        private readonly ITimeHelper _timeHelper;

        public LoopProcessor(IProcessor processor, ILoggerFactory loggerFactory, ITimeHelper timeHelper)
        {
            _processor = processor;
            _loggerFactory = loggerFactory;
            _timeHelper = timeHelper;
        }
        public override string Name => "LoopProcessor";
        public override async Task Process(ProcessingContext context)
        {
            var logger = _loggerFactory.CreateLogger<LoopProcessor>();

            while (!context.IsStopping)
            {
                try
                {
                    logger.LogDebug($"{_timeHelper.GetAppropriateFormatedDateString()}...{ this.ToString() } process start");

                    await _processor.Process(context);

                    logger.LogDebug($"{_timeHelper.GetAppropriateFormatedDateString()}...{ this.ToString() } process compelete");
                }
                catch (Exception ex)
                {
                    logger.LogError(ex, $"{_timeHelper.GetAppropriateFormatedDateString()}...{ this.ToString() } process error");
                }
            }
        }
        public override string ToString()
        {
            var strArray = new string[2];
            strArray[0] = Name;
            strArray[1] = _processor.Name;
            return string.Join("_", strArray);
        }
    }
}
