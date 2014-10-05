// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILogWrapper.cs">
//   Copyright (c) 2014. Under MIT license.
// </copyright>
// <summary>
//   A Wrapper for logging frameworks (based on Log4Net ILog interface)
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Loggy
{
    using System;

    public interface ILogWrapper
    {
        void Debug(object message);

        void Debug(object message, Exception exception);

        void DebugFormat(string format, params object[] args);

        void Error(object message);

        void Error(object message, Exception exception);

        void ErrorFormat(string format, params object[] args);

        void Fatal(object message);

        void Fatal(object message, Exception exception);

        void FatalFormat(string format, params object[] args);

        void Info(object message);

        void Info(object message, Exception exception);

        void InfoFormat(string format, params object[] args);

        void Warn(object message);

        void Warn(object message, Exception exception);

        void WarnFormat(string format, params object[] args);

        void AddProperty(string name, string value);

        void ClearProperties();
    }
}
