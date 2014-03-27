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
	using System.Globalization;

    using Serilog;
    //using log4net.Core;
    //using log4net.Util;

	using Logger = Castle.Core.Logging.ILogger;
    using Serilog.Events;

	[Serializable]
	public class SerilogLogger : MarshalByRefObject, Logger
	{
		private static readonly Type declaringType = typeof(SerilogLogger);

		public SerilogLogger(ILogger logger, SerilogFactory factory)
		{
			Logger = logger;
			Factory = factory;
		}

		internal SerilogLogger()
		{
		}

        //internal SerilogLogger(Log log, SerilogFactory factory) : this(log.Logger, factory)
        //{
        //}

		public bool IsDebugEnabled
		{
            get { return Logger.IsEnabled(LogEventLevel.Debug); }
		}

		public bool IsErrorEnabled
		{
            get { return Logger.IsEnabled(LogEventLevel.Error); }
		}

		public bool IsFatalEnabled
		{
            get { return Logger.IsEnabled(LogEventLevel.Fatal); }
		}

		public bool IsInfoEnabled
		{
            get { return Logger.IsEnabled(LogEventLevel.Information); }
		}

		public bool IsWarnEnabled
		{
            get { return Logger.IsEnabled(LogEventLevel.Warning); }
		}

		protected internal SerilogFactory Factory { get; set; }

		protected internal ILogger Logger { get; set; }

		public override string ToString()
		{
			return Logger.ToString();
		}

		public virtual Logger CreateChildLogger(String name)
		{
            throw new NotImplementedException();
		}

		public void Debug(String message)
		{
			if (IsDebugEnabled)
			{
                Logger.Write(LogEventLevel.Debug, message);
			}
		}

		public void Debug(Func<string> messageFactory)
		{
			if (IsDebugEnabled)
			{
                Logger.Write(LogEventLevel.Debug, messageFactory.Invoke());
			}
		}

		public void Debug(String message, Exception exception)
		{
			if (IsDebugEnabled)
			{
                Logger.Write(LogEventLevel.Debug, message, exception);
			}
		}

		public void DebugFormat(String format, params Object[] args)
		{
			if (IsDebugEnabled)
			{
                Logger.Write(LogEventLevel.Debug, format, args);
			}
		}

		public void DebugFormat(Exception exception, String format, params Object[] args)
		{
			if (IsDebugEnabled)
			{
                Logger.Write(LogEventLevel.Debug, exception, format, args);
			}
		}

		public void DebugFormat(IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsDebugEnabled)
			{
                Logger.Write(LogEventLevel.Debug, format, args);
            }
		}

		public void DebugFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsDebugEnabled)
			{
                Logger.Write(LogEventLevel.Debug, exception, format, args);
            }
		}

		public void Error(String message)
		{
			if (IsErrorEnabled)
			{
                Logger.Write(LogEventLevel.Error, "{type} " + message);
			}
		}

		public void Error(Func<string> messageFactory)
		{
			if (IsErrorEnabled)
			{
                Logger.Write(LogEventLevel.Error, messageFactory.Invoke());
			}
		}

		public void Error(String message, Exception exception)
		{
			if (IsErrorEnabled)
			{
                Logger.Write(LogEventLevel.Error, message, exception);
			}
		}

		public void ErrorFormat(String format, params Object[] args)
		{
			if (IsErrorEnabled)
			{
				Logger.Write(LogEventLevel.Error, format, args);
			}
		}

		public void ErrorFormat(Exception exception, String format, params Object[] args)
		{
			if (IsErrorEnabled)
			{
                Logger.Write(LogEventLevel.Error, exception, format, args);
            }
		}

		public void ErrorFormat(IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsErrorEnabled)
			{
                Logger.Write(LogEventLevel.Error, format, args);
            }
		}

		public void ErrorFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsErrorEnabled)
			{
                Logger.Write(LogEventLevel.Error, exception, format, args);
            }
		}

		public void Fatal(String message)
		{
			if (IsFatalEnabled)
			{
                Logger.Write(LogEventLevel.Fatal, message);
			}
		}

		public void Fatal(Func<string> messageFactory)
		{
			if (IsFatalEnabled)
			{
                Logger.Write(LogEventLevel.Fatal, messageFactory.Invoke());
			}
		}

		public void Fatal(String message, Exception exception)
		{
			if (IsFatalEnabled)
			{
                Logger.Write(LogEventLevel.Fatal, exception, message);
			}
		}

		public void FatalFormat(String format, params Object[] args)
		{
			if (IsFatalEnabled)
			{
                Logger.Write(LogEventLevel.Fatal, format, args);
			}
		}

		public void FatalFormat(Exception exception, String format, params Object[] args)
		{
			if (IsFatalEnabled)
			{
                Logger.Write(LogEventLevel.Fatal, exception, format, args);
			}
		}

		public void FatalFormat(IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsFatalEnabled)
			{
                Logger.Write(LogEventLevel.Fatal, format, args);
			}
		}

		public void FatalFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsFatalEnabled)
			{
                Logger.Write(LogEventLevel.Fatal, exception, format, args);
			}
		}

		public void Info(String message)
		{
			if (IsInfoEnabled)
			{
                Logger.Write(LogEventLevel.Information, message);
			}
		}

		public void Info(Func<string> messageFactory)
		{
			if (IsInfoEnabled)
			{
                Logger.Write(LogEventLevel.Information, messageFactory.Invoke());
			}
		}

		public void Info(String message, Exception exception)
		{
			if (IsInfoEnabled)
			{
                Logger.Write(LogEventLevel.Information, exception, message);
			}
		}

		public void InfoFormat(String format, params Object[] args)
		{
			if (IsInfoEnabled)
			{
                Logger.Write(LogEventLevel.Information, format, args);
			}
		}

		public void InfoFormat(Exception exception, String format, params Object[] args)
		{
			if (IsInfoEnabled)
			{
                Logger.Write(LogEventLevel.Information, exception, format, args);
			}
		}

		public void InfoFormat(IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsInfoEnabled)
			{
                Logger.Write(LogEventLevel.Information, format, args);
			}
		}

		public void InfoFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsInfoEnabled)
			{
                Logger.Write(LogEventLevel.Information, exception, format, args);
			}
		}

		public void Warn(String message)
		{
			if (IsWarnEnabled)
			{
                Logger.Write(LogEventLevel.Warning, message);
			}
		}

		public void Warn(Func<string> messageFactory)
		{
			if (IsWarnEnabled)
			{
                Logger.Write(LogEventLevel.Warning, messageFactory.Invoke());
			}
		}

		public void Warn(String message, Exception exception)
		{
			if (IsWarnEnabled)
			{
                Logger.Write(LogEventLevel.Warning, exception, message);
			}
		}

		public void WarnFormat(String format, params Object[] args)
		{
			if (IsWarnEnabled)
			{
                Logger.Write(LogEventLevel.Warning, format, args);
			}
		}

		public void WarnFormat(Exception exception, String format, params Object[] args)
		{
			if (IsWarnEnabled)
			{
                Logger.Write(LogEventLevel.Warning, exception, format, args);
			}
		}

		public void WarnFormat(IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsWarnEnabled)
			{
                Logger.Write(LogEventLevel.Warning, format, args);
			}
		}

		public void WarnFormat(Exception exception, IFormatProvider formatProvider, String format, params Object[] args)
		{
			if (IsWarnEnabled)
			{
                Logger.Write(LogEventLevel.Warning, exception, format, args);
			}
		}
	}
}