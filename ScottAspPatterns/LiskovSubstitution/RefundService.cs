using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScottAspPatterns.LiskovSubstitution
{
    public class RefundService
    {
        public RefundResponse Refund (RefundRequest refundRequest)
        {
            PaymentServiceBase paymentService =  PaymentServiceFactory.GetPaymentService(refundRequest.Payment);
            
            RefundResponse response = new RefundResponse();

          

            RefundResponse merchantResponse = paymentService.Refund(refundRequest.RefundAmount, refundRequest.PaymentTransactionId);

            
            if (merchantResponse.Message.Contains("A_Success") || merchantResponse.Message.Contains("Auth"))
                response.Success = true;
            else
                response.Success = false;

            return response;



        }
    }
}