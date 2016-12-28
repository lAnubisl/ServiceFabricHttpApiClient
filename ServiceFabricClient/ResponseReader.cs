using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ServiceFabricClient
{
    internal static class ResponseReader
    {
        internal static async Task<Result<T>> Read<T>(this HttpResponseMessage response) where T : class
        {
            try
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    return new Result<T>(null, response.StatusCode);    
                }

                var json = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<T>(json);
                return new Result<T>(model, response.StatusCode);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}