namespace ServiceFabricClient.V1.Models
{
    public class ResolveServiceResponse
    {
        /// <summary>
        /// Name of the service.
        /// </summary>
        public string Name { get; set; }

        public Partitioninformation PartitionInformation { get; set; }
        public Endpoint[] Endpoints { get; set; }

        /// <summary>
        /// The version of this resolved service partition result. This version should be passed in the next time the ResolveService call is made via the PreviousRspVersion query parameter.
        /// </summary>
        public string Version { get; set; }
    }
}