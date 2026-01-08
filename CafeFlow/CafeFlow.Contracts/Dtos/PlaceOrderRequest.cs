using System.Collections.Generic;
using System.Runtime.Serialization;


namespace CafeFlow.Contracts.Dtos
{
    [DataContract]
    public class PlaceOrderRequest
    {
        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public List<string> Items { get; set; }
    }
}
