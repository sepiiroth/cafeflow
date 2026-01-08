using System;
using System.Runtime.Serialization;

namespace CafeFlow.Contracts.Dtos
{
    [DataContract]
    public class PlaceOrderResponse
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public Guid? OrderId { get; set; }
    }
}
