using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace CafeFlow.Contracts.Dtos
{
    [DataContract]
    public class OrderDto
    {
        [DataMember]
        public Guid Id { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public List<string> Items { get; set; }

        [DataMember]
        public OrderStatus Status { get; set; }

        [DataMember]
        public DateTime CreatedAtUtc { get; set; }
    }
}
