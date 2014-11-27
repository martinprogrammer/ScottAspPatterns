using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LiskovSubstitution
{
    public class MockWorldPayWebService
    {
        public string MakeRefund(decimal amount, string transactionId, string username, string password, string productId)
        {
            return "A_Success-09901";
        }
    }
}