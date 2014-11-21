using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Decorator
{
    public class TradeDiscountPriceDecorator : IPrice
    {
        private IPrice _basePrice;
        public TradeDiscountPriceDecorator (IPrice price)
        {
            _basePrice = price;
        }
        public decimal Cost
        {
            get
            {
                return _basePrice.Cost * 0.95m;
            }
            set
            {
                _basePrice.Cost = value; ;
            }
        }
    }
}