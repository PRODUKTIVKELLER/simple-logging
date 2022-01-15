using UnityEngine;

namespace Produktivkeller.SimpleLogging
{
    public class UnityLogOutput : IOutput
    {
        public void Write(LogLevel logLevel, string message)
        {
            LogCache.GetInstance().Add(message);

            switch (logLevel)
            {
                case LogLevel.Debug:
                    Debug.Log(message);
                    break;
                case LogLevel.Warn:
                    Debug.LogWarning(message);
                    break;
                case LogLevel.Error:
                    Debug.LogError(message);
                    break;
            }
        }
    }
}