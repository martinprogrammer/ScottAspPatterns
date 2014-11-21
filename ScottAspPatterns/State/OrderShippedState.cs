using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.State
{
    public class OrderShippedState : IOrderState
    {
        public OrderStatus status
        {
            get
            {
                return OrderStatus.Shipped;
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
            throw new NotImplementedException("This order has already been shipped");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("You cannot cancel shipped order");
        }
    }
}