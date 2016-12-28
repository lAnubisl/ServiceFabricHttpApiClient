using System;

namespace ServiceFabricClient.V1.Models
{
    public class Partitioninformation
    {
        /// <summary>
        /// The partition scheme of this service.
        /// </summary>
        public ServicePartitionKind ServicePartitionKind { get; set; }

        /// <summary>
        /// The partition ID
        /// </summary>
        public Guid Id { get; set; }
    }
}