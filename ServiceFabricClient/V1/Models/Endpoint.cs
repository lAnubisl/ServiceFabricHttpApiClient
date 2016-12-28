namespace ServiceFabricClient.V1.Models
{
    public class Endpoint
    {
        /// <summary>
        /// This corresponds to the role of the replica.
        /// </summary>
        public ServiceEndpointRole Kind { get; set; }

        /// <summary>
        /// This corresponds to the endpoint address of the replica.
        /// </summary>
        public string Address { get; set; }
    }
}