using System;
using System.Runtime.Serialization;


namespace CafeFlow.Contracts.Dtos
{
    [DataContract]
    public class UpdateStatusRequest
    {
        [DataMember]
        public Guid OrderId { get; set; }

        [DataMember]
        public OrderStatus NewStatus { get; set; }
    }
}
