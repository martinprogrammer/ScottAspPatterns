using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Decorator
{
    public static class ExtensionMethods
    {
        public static void ApplyCurrencyMultiplier(this IEnumerable<Product> products, decimal exchangeRate)
        {
            products.ToList().ForEach(p => p.Price = new CurrencyPriceDecorator(p.Price, exchangeRate));

        }

        public static void ApplyTradeDiscountMultiplier(this IEnumerable<Product> products)
        {
            products.ToList().ForEach(p => p.Price = new TradeDiscountPriceDecorator(p.Price));
        }
    }
}