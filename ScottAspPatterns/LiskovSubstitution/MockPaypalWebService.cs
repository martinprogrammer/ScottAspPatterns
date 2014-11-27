using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LiskovSubstitution
{
    public class MockPaypalWebService
    {
        public string ObtainToken(string accountName, string password)
        {
            return "xxxxx-xxxxx-xxxx";
        }

        public string MakeRefund(decimal amount, string transactionId, string token)
        {
            return "Auth:0999";
        }


    }
}