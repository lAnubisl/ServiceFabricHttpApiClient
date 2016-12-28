using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ServiceFabricClient.V1.Parts
{
    public abstract class PartBase
    {
        protected readonly HttpRequestHelper helper;
        protected readonly UrlFactory urlFactory;

        internal PartBase(HttpRequestHelper helper, UrlFactory urlFactory)
        {
            this.helper = helper;
            this.urlFactory = urlFactory;
        }

        protected static async Task<T> RequestAndRead<T>(Task<HttpResponseMessage> requestTask,
            Func<HttpResponseMessage, Task<T>> readTask)
        {
            using (var response = await requestTask.ConfigureAwait(false))
            {
                return await readTask(response).ConfigureAwait(false);
            }
        }
    }
}