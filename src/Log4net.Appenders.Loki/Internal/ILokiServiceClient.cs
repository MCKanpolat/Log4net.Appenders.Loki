using System.Net.Http;
using System.Threading.Tasks;

namespace Log4net.Appenders.Loki.Internal
{
    internal interface ILokiServiceClient
    {
        Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content);
        void SetCredentials(string username, string password);
    }
}