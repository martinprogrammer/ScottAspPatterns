using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.State
{
    public class CanceledOrderState : IOrderState
    {
        public OrderStatus status
        {
            get
            {
                return OrderStatus.Canceled;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("This order cannot be shipped.  It's been canceled");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("This order has already been canceled");
        }
    }
}