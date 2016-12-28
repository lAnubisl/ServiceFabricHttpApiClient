using System;
using System.Threading.Tasks;
using ServiceFabricClient.V1.Models;

namespace ServiceFabricClient.V1.Parts
{
    public class Service : PartBase
    {
        internal Service(HttpRequestHelper helper, UrlFactory urlFactory) : base(helper, urlFactory)
        {
        }

        public async Task<Result<ResolveServiceResponse>> ResolveAsync(string serviceName)
        {
            if (serviceName == null) throw new ArgumentNullException(nameof(serviceName));
            var requestTask = helper.Get(urlFactory.GetResolveServiceUrl(serviceName));
            return await RequestAndRead(requestTask, r => r.Read<ResolveServiceResponse>()).ConfigureAwait(false);
        }
    }
}