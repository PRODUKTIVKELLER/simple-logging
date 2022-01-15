namespace Produktivkeller.SimpleLogging
{
    public interface IOutput
    {
        void Write(LogLevel logLevel, string message);
    }
}