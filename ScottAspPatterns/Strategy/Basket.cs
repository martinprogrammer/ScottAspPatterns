using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Strategy
{
    public class Basket
    {
        private IBasketDiscountStrategy _strategy;

        public Basket(DiscountType discount)
        {
            _strategy = BasketDiscountFactory.GetDiscount(discount);
        }
        public decimal TotalCost { get; set; }

        public decimal GetTotalCostAfterDiscount()
        {
            return _strategy.GetTotalCostAfterApplyingDiscount(this);
        }
    }
}