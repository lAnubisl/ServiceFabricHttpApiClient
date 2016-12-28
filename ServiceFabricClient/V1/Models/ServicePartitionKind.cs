namespace ServiceFabricClient.V1.Models
{
    public enum ServicePartitionKind
    {
        /// <summary>
        /// Indicates the partition kind is invalid.
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// Indicates that the partition is based on string names, and is a SingletonPartitionInformation 
        /// object, that was originally created via SingletonPartitionSchemeDescription.
        /// </summary>
        Singleton = 1,
        /// <summary>
        /// Indicates that the partition is based on Int64 key ranges, and is an Int64RangePartitionInformation 
        /// object that was originally created via UniformInt64RangePartitionSchemeDescription.
        /// </summary>
        Int64Range = 2,
        /// <summary>
        /// Indicates that the partition is based on string names, and is a NamedPartitionInformation object, 
        /// that was originally created via NamedPartitionSchemeDescription. 
        /// </summary>
        Named = 3
    }
}