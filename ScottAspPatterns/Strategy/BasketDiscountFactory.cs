using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Strategy
{
    public class BasketDiscountFactory
    {
        public static IBasketDiscountStrategy GetDiscount(DiscountType discount)
        {
            switch (discount)
            {
                case DiscountType.MoneyOff:
                    return new BasketDiscountMoneyOff();
                case DiscountType.PercentageOff:
                    return new BasketDiscountPercentageOff();
                default:
                    return new NoBasketDiscount();


            }
        }
    }
}