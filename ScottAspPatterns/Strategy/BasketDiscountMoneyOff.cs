using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Strategy
{
    public class BasketDiscountMoneyOff : IBasketDiscountStrategy
    {
        public decimal GetTotalCostAfterApplyingDiscount(Basket basket)
        {
            if (basket.TotalCost > 100)
                return basket.TotalCost - 10m;
            else if (basket.TotalCost > 50)
                return basket.TotalCost - 5m;
            else
                return basket.TotalCost;
        }
    }
}