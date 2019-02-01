namespace Log4net.Appenders.Loki.Internal
{
    public interface ILabel
    {
        string Key { get; }
        string Value { get; }
    }
}