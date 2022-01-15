using System;
using System.Collections.Generic;

namespace Produktivkeller.SimpleLogging
{
    public class LogCache
    {
        private static LogCache _instance;

        public Action<string> onNewLog;

        private readonly List<string> _logList;

        private LogCache()
        {
            _logList = new List<string>();
        }

        public static LogCache GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LogCache();
            }

            return _instance;
        }

        public void Add(string log)
        {
            _logList.Add(log);

            onNewLog?.Invoke(log);
        }

        public IEnumerable<string> GetLogList()
        {
            return _logList;
        }

        public object BuildCompleteLog()
        {
            return string.Join("\n", _logList);
        }
    }
}