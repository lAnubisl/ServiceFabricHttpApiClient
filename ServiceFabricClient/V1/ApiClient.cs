using System.Security.Cryptography.X509Certificates;
using ServiceFabricClient.V1.Parts;

namespace ServiceFabricClient.V1
{
    public class ApiClient
    {
        private readonly HttpRequestHelper helper;
        private readonly UrlFactory urlFactory;

        public ApiClient(X509Certificate clientCertificate, bool allowUntrustedServerCertificate, string baseUrl)
        {
            helper = new HttpRequestHelper(clientCertificate, allowUntrustedServerCertificate);
            urlFactory = new UrlFactory(baseUrl, "1.0");
            Service = new Service(helper, urlFactory);
        }

        public ApiClient(string baseUrl)
        {
            helper = new HttpRequestHelper();
            urlFactory = new UrlFactory(baseUrl, "1.0");
            Service = new Service(helper, urlFactory);
        }

        public Service Service { get; }
    }
}