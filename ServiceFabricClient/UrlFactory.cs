namespace ServiceFabricClient
{
    public class UrlFactory
    {
        private readonly string baseUrl;
        private readonly string apiVersion;

        internal UrlFactory(string baseUrl, string apiVersion)
        {
            this.baseUrl = baseUrl;
            this.apiVersion = apiVersion;
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/rest/api/servicefabric/resolve-a-service
        /// </summary>
        /// <returns></returns>
        internal string GetResolveServiceUrl(string serviceName)
        {
            return $"{baseUrl}/Services/{serviceName}/$/ResolvePartition?api-version={apiVersion}";
        }
    }
}