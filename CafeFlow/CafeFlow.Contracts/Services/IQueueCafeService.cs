using CafeFlow.Contracts.Dtos;
using System.Collections.Generic;
using System.ServiceModel;

namespace CafeFlow.Contracts.Services
{
    [ServiceContract]
    public interface IQueueCafeService
    {
        [OperationContract]
        List<OrderDto> GetQueue();

        [OperationContract]
        PlaceOrderResponse PlaceOrder(PlaceOrderRequest request);

        [OperationContract]
        OperationResult UpdateStatus(UpdateStatusRequest request);
    }
}
