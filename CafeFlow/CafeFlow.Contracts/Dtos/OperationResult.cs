using System.Runtime.Serialization;


namespace CafeFlow.Contracts.Dtos
{
    [DataContract]
    public class OperationResult
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
