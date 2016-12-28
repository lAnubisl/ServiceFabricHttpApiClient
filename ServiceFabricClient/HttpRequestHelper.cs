using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ServiceFabricClient
{
    public class HttpRequestHelper
    {
        private readonly WebRequestHandler webRequestHandler;

        public HttpRequestHelper()
        {
        }

        public HttpRequestHelper(X509Certificate clientCertificate, bool allowUntrusedServerCertificate)
        {
            webRequestHandler = new WebRequestHandler();
            webRequestHandler.ClientCertificates.Add(clientCertificate);
            if (allowUntrusedServerCertificate)
            {
                webRequestHandler.ServerCertificateValidationCallback = (_, __, ___, ____) => true;
            }
        }

        internal Task<HttpResponseMessage> Get(string url)
        {
            return DoRequest(new HttpRequestMessage(HttpMethod.Get, url));
        }

        private async Task<HttpResponseMessage> DoRequest(HttpRequestMessage request)
        {
            using (var client = GetClient())
            {
                return await client.SendAsync(request).ConfigureAwait(false);
            }
        }

        private HttpClient GetClient()
        {
            return webRequestHandler != null 
                ? new HttpClient(webRequestHandler, false) 
                : new HttpClient();
        }
    }
}