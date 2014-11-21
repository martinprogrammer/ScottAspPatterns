using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Strategy
{
    public class BasketDiscountPercentageOff : IBasketDiscountStrategy
    {

        public decimal GetTotalCostAfterApplyingDiscount(Basket basket)
        {
            return basket.TotalCost * 0.95m;
        }
    }
}