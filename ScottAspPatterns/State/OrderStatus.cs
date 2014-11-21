using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.State
{
    public enum OrderStatus
    {
        New = 0,
        Shipped = 1,
        Canceled = 2
    }
}