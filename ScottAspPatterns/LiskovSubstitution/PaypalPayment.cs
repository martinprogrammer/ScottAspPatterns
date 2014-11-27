using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LiskovSubstitution
{
    public class PaypalPayment : PaymentServiceBase
    {
        public string _account;
        public string _password;
        
        public PaypalPayment(string account, string password)
        {
            _account = account;
            _password = password;
        }
        public override RefundResponse Refund(decimal amount, string transactionId)
        {
            MockPaypalWebService payPalWebService = new MockPaypalWebService();
            string token = payPalWebService.ObtainToken(_account, _password);
            RefundResponse refundResponse = new RefundResponse();
            refundResponse.Message = payPalWebService.MakeRefund(amount, transactionId, token);

            if (refundResponse.Message.Contains("Auth"))
                refundResponse.Success = true;
            else
                refundResponse.Success = false;

            return refundResponse;
        }
    }
}