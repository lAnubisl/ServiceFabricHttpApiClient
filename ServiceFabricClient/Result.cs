using System.Net;

namespace ServiceFabricClient
{
    public class Result<T> where T : class
    {
        internal Result(T model, HttpStatusCode httpStatusCode)
        {
            Model = model;
            HttpStatusCode = httpStatusCode;
        }

        public T Model { get; }

        public HttpStatusCode HttpStatusCode { get; }

        public bool Success => Model != null;
    }
}