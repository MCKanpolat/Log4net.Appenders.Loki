namespace Log4net.Appenders.Loki.Internal
{
    public class Label : ILabel
    {
        public Label(string key, string value)
        {
            Key = key;
            Value = value;
        }

        public string Key { get; }

        public string Value { get; }
    }
}
