using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.Template
{
    public class NoQuibblesReturn : ReturnProcessTemplate
    {
        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            throw new NotImplementedException();
        }

        protected override void CalculateRefundFor(ReturnOrder returnOrder)
        {
            returnOrder.AmountToRefund = returnOrder.PricePaid;
        }
    }
}