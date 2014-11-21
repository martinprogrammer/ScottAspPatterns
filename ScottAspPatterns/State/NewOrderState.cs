using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.State
{
    public class NewOrderState : IOrderState
    {
        public OrderStatus status
        {
            get
            {
                return OrderStatus.New;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool CanShip(Order order)
        {
            return true;
        }

        public void Ship(Order order)
        {
            order.Ship();
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public void Cancel(Order order)
        {
            order.Cancel();
        }
    }
}