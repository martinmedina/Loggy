// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Log4NetWrapper.cs">
//   Copyright (c) 2014. Under MIT licence.
// </copyright>
// <summary>
//   An ILogWrapper implementation using Log4Net.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Loggy.Log4Net
{
    using System;
    using System.Diagnostics;

    using log4net;

    public class Log4NetWrapper : ILogWrapper
    {
        private readonly string eventSourceName;

        private readonly ILog logger;

        public Log4NetWrapper(Type type, string eventSourceName)
        {
            this.logger = LogManager.GetLogger(type);
            this.eventSourceName = eventSourceName;
        }

        public void Debug(object message)
        {
            try
            {
                this.logger.Debug(message);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Debug(object message, Exception exception)
        {
            try
            {
                this.logger.Debug(message, exception);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void DebugFormat(string format, params object[] args)
        {
            try
            {
                this.logger.DebugFormat(format, args);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Error(object message)
        {
            try
            {
                this.logger.Error(message);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Error(object message, Exception exception)
        {
            try
            {
                this.logger.Error(message, exception);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void ErrorFormat(string format, params object[] args)
        {
            try
            {
                this.logger.ErrorFormat(format, args);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Fatal(object message)
        {
            try
            {
                this.logger.Fatal(message);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Fatal(object message, Exception exception)
        {
            try
            {
                this.logger.Fatal(message, exception);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void FatalFormat(string format, params object[] args)
        {
            try
            {
                this.logger.FatalFormat(format, args);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Info(object message)
        {
            try
            {
                this.logger.Info(message);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Info(object message, Exception exception)
        {
            try
            {
                this.logger.Info(message, exception);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void InfoFormat(string format, params object[] args)
        {
            try
            {
                this.logger.InfoFormat(format, args);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Warn(object message)
        {
            try
            {
                this.logger.Warn(message);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void Warn(object message, Exception exception)
        {
            try
            {
                this.logger.Warn(message, exception);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void WarnFormat(string format, params object[] args)
        {
            try
            {
                this.logger.WarnFormat(format, args);
            }
            catch (Exception ex)
            {
                EventLog.WriteEntry(this.eventSourceName, ex.ToString(), EventLogEntryType.Error);
            }
        }

        public void AddProperty(string name, string value)
        {
            GlobalContext.Properties[name] = value;
        }

        public void ClearProperties()
        {
            GlobalContext.Properties.Clear();
        }
    }
}
