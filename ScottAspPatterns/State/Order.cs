using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScottAspPatterns.State
{
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState baseState)
        {
            _orderState = baseState;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderDate { get; set; }

        public OrderStatus  OrderStatus()
        {
            return _orderState.status;
        }

        public bool CanCancel()
        {
            return _orderState.CanCancel(this);
        }

        public void Cancel()
        {
            _orderState.Cancel(this);
        }

        public bool CanShip()
        {
            return _orderState.CanShip(this);
        }

        public void Ship()
        {
            _orderState.Ship(this);
        }

        internal void Change(IOrderState state)
        {
            _orderState = state;
        }
    }
}
