using log4net.Appender;
using log4net.Core;
using System;

namespace Log4net.Appenders.Loki
{
    public class LokiAppender : AppenderSkeleton
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Labels { get; set; }

        protected override void Append(LoggingEvent loggingEvent)
        {
            throw new NotImplementedException();
        }
    }
}
