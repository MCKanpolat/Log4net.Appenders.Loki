using System;
using System.Text;

namespace Log4net.Appenders.Loki.Internal
{
    internal static class Utils
    {
        public static string ToBase64String(this string source)
        {
            var textByte = Encoding.UTF8.GetBytes(source);
            return Convert.ToBase64String(textByte);
        }
    }
}
