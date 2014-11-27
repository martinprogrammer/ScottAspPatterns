using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LiskovSubstitution
{
    public abstract class PaymentServiceBase
    {
        public abstract RefundResponse Refund(decimal amount, string transactionId);
    }
}