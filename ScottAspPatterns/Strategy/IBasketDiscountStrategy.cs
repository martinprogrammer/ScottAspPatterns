using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Strategy
{
    public interface IBasketDiscountStrategy
    {
        decimal GetTotalCostAfterApplyingDiscount(Basket basket);
    }
}