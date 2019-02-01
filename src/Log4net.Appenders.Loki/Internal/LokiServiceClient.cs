using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Log4net.Appenders.Loki.Internal
{
    //xyz.com/api/prom/push
    internal class LokiServiceClient : IDisposable, ILokiServiceClient
    {
        protected readonly HttpClient _httpClient;

        public LokiServiceClient(string baseAddress)
        {
            if (string.IsNullOrWhiteSpace(baseAddress))
            {
                throw new ArgumentNullException(nameof(baseAddress));
            }

            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseAddress)
            };
        }

        public void SetCredentials(string username, string password)
        {
            var credential = $"{username}:{password}";
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credential.ToBase64String());
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            return await _httpClient.PostAsync(requestUri, content);
        }

        #region IDisposable Support
        private bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _httpClient?.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion


    }
}