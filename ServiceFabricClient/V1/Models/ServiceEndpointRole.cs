namespace ServiceFabricClient.V1.Models
{
    public enum ServiceEndpointRole
    {
        Invalid = 0,
        Stateless = 1,
        StatefulPrimary = 2,
        StatefulSecondary = 3
    }
}