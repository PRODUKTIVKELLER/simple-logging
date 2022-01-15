using System;
using System.Collections.Generic;

namespace Produktivkeller.SimpleLogging
{
    public static class LogManager
    {
        private const LogLevel LOG_LEVEL          = LogLevel.Debug;
        private const string   DATE_FORMAT_STRING = "yyyy.MM.dd HH:mm:ss,ffff";
        private const string   LOG_FORMAT_STRING  = "{0} [{1}] {2}";
        private const string   PLACEHOLDER        = "{}";

        private static readonly IOutput Output = new UnityLogOutput();

        private static readonly LogFormatter LogFormatter =
            new LogFormatter(DATE_FORMAT_STRING, LOG_FORMAT_STRING, PLACEHOLDER);

        private static readonly Dictionary<Type, ILog> Loggers = new Dictionary<Type, ILog>();

        public static ILog GetLogger(Type type)
        {
            if (!Loggers.ContainsKey(type))
            {
                Loggers[type] = new Log(type, LOG_LEVEL, Output, LogFormatter);
            }

            return Loggers[type];
        }
    }
}