using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeFlow.Contracts.Dtos
{
    public enum OrderStatus
    {
        Pending = 0,
        InProgress = 1,
        Ready = 2, 
        Cancelled = 3
    }
}
