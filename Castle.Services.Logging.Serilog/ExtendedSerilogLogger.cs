// Copyright 2004-2010 Castle Project - http://www.castleproject.org/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.Services.Logging.SerilogIntegration
{
	using System;

	using Castle.Core.Logging;

    using Serilog;

    //using ILogger = log4net.Core.ILogger;
	using Logger = Castle.Core.Logging.ILogger;
	using ExtendedLogger = Castle.Core.Logging.IExtendedLogger;

	public class ExtendedSerilogLogger : SerilogLogger, ExtendedLogger
	{
		private static readonly IContextProperties globalContextProperties = new GlobalContextProperties();
		private static readonly IContextProperties threadContextProperties = new ThreadContextProperties();
		private static readonly IContextStacks threadContextStacks = new ThreadContextStacks();

        //public ExtendedSerilogLogger(Log log, ExtendedSerilogFactory factory) : this(log.Logger, factory)
        //{
        //}

		public ExtendedSerilogLogger(Serilog.ILogger logger, ExtendedSerilogFactory factory)
		{
			Logger = logger;
			Factory = factory;
		}

		/// <summary>
		///   Exposes the Global Context of the extended logger.
		/// </summary>
		public IContextProperties GlobalProperties
		{
			get { return globalContextProperties; }
		}

		/// <summary>
		///   Exposes the Thread Context of the extended logger.
		/// </summary>
		public IContextProperties ThreadProperties
		{
			get { return threadContextProperties; }
		}

		/// <summary>
		///   Exposes the Thread Stack of the extended logger.
		/// </summary>
		public IContextStacks ThreadStacks
		{
			get { return threadContextStacks; }
		}

		protected internal new ExtendedSerilogFactory Factory { get; set; }

		public ExtendedLogger CreateExtendedChildLogger(string name)
		{
            throw new NotImplementedException();
		}

		public override Logger CreateChildLogger(String name)
		{
            throw new NotImplementedException();
		}
	}
}