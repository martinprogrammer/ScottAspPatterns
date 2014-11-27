using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LiskovSubstitution
{
    public class WorldPayPayment : PaymentServiceBase
    {
        private string _username;
        private string _password;
        private string _productId;

        public WorldPayPayment(string username, string password, string productId)
        {
            _username = username;
            _password = password;
            _productId = productId;
        }
        public override RefundResponse Refund(decimal amount, string transactionId)
        {
            MockWorldPayWebService worldPayService = new MockWorldPayWebService();
            RefundResponse refundResponse = new RefundResponse();
            refundResponse.Message = worldPayService.MakeRefund(amount, transactionId, _username, _password, _productId);
            return refundResponse;
        }
    }
}