// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Log4NetWrapperFactory.cs">
//   Copyright (c) 2014. Under MIT license.
// </copyright>
// <summary>
//   Factory that allows the creation of Log4NetWrapper instances.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Loggy.Log4Net
{
    using System;

    using log4net;
    using log4net.Config;

    public class Log4NetWrapperFactory
    {
        private static bool isConfigured;
        
        public static ILogWrapper GetLogger(Type type)
        {
            if (!isConfigured)
            {
                Configure();
                isConfigured = true;
            }

            return new Log4NetWrapper(type, type.Namespace);
        }

        public static void Shutdown()
        {
            LogManager.Shutdown();
        }

        private static void Configure()
        {
            XmlConfigurator.Configure();
        }
    }
}
