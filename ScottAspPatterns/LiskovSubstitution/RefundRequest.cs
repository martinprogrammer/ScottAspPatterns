using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LiskovSubstitution
{
    public class RefundRequest
    {
        public PaymentType Payment { get; set; }
        public string PaymentTransactionId  { get; set; }
        public decimal RefundAmount { get; set; }
    }
}